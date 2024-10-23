using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using DAL;
namespace modbusStart
{
    public partial class ModbusStation : Form
    {
        //枚举类型
        public enum DataFormat
        { 
             ABCD,
             BACD,
             CDAB,
             DCBA
        
        }
        public enum StoreArea
        {
            输出线圈0X,
            输入状态1X,
            输出寄存器4X,
            输入寄存器3X

        }

        public enum VarType
        { 
            Bit,
            Short,
            UShort,
            Int,
            UInt,
            Float

         }

        //数据位
        public int[] Databits = { 7, 8 };



        public ModbusStation()
        {
            InitializeComponent();
            this.Load += ModbusStation_Load;
        }

        //创建一个通讯对象
        private modbusrtu ObjModbusRtu = new modbusrtu();
        //系统当前时间

        private string CurrentTime
        {

            get { return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); }
        }
        //创建链接标志

        private bool IsConnected = false;

        private void ModbusStation_Load(object sender, EventArgs e)
        {
            //初始化控件

            //端口号

            string[] PortList = SerialPort.GetPortNames();

            if (PortList.Length > 0)
            {
                this.comPort.Items.AddRange(PortList);
                this.comPort.SelectedIndex = 0;
            
            }

            //波特率
            this.comBound.DataSource = new string[] { "2400", "9600", "19200", "38400", "115200" };
            //校验位
            this.comParity.DataSource = Enum.GetNames(typeof(Parity));
            //数据格式
            this.comDataFormat.DataSource = Enum.GetNames(typeof(DataFormat));
            //寄存器区
            this.comStoreAre .DataSource = Enum.GetNames(typeof(StoreArea));
            //停止位
            this.comStopbit.DataSource = Enum.GetNames(typeof(StopBits));
            this.comStopbit.SelectedIndex = 1;

            //数据位
            this.comDatabits.DataSource = Databits;
            this.comDatabits.SelectedIndex = 1;
            //数据类型
            this.comVarType.DataSource = Enum.GetNames(typeof(VarType));
        }
        private void Fun_Connected()
        {
            //判断是否已经链接

            if (IsConnected)
            {
                AddLog(1, "ModbusRTU已经连接，请勿重复连接");
                return;
            }
            //如果没有建立连接，则建立

            try
            {
                ObjModbusRtu.OpenMycom(this.comPort.Text.Trim(),
                    int.Parse(this.comBound.Text.Trim()), (Parity)(Enum.Parse(typeof(Parity), this.comParity.SelectedItem.ToString(), false)),
                    int.Parse(this.comDatabits.Text.Trim()), (StopBits)(Enum.Parse(typeof(StopBits), this.comStopbit.SelectedItem.ToString(), false)));


            }
            catch (Exception ex)
            {
                IsConnected = false;
                AddLog(1, "ModbusRTU连接失败：" + ex.Message);
                return;

            }

            IsConnected = true;
            AddLog(0, "ModbusRTU连接成功");

        }

        private void Fun_CloseConnected()
        {
            ObjModbusRtu.CloseMycom();
            IsConnected = false;
            AddLog(0, "断开连接ModbusRTU");

        }

        private void AddLog(int Type, string info)
        {
          
            ListViewItem lst = new ListViewItem("   " + CurrentTime, Type);
            lst.SubItems.Add(info);
            this.listInfo.Items.Insert(0, lst);


        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                AddLog(1, "请检查连接");
                return;
            
            }

            ushort DevAdd = 0;
            ushort Address = 0;
            ushort Length = 0;
            if (!ushort.TryParse(this.textSlaveID.Text.Trim(), out DevAdd))
            {
                AddLog(1, "从站ID必须为正整数");
                return;
            }
            if (!ushort.TryParse(this.textStartArea .Text.Trim(), out Address))
            {
                AddLog(1, "起始地址必须为正整数");
                return;
            }
            if (!ushort.TryParse(this.textLength .Text.Trim(), out Length))
            {
                AddLog(1, "查询长度必须为正整数");
                return;
            }
            //获取选择的变量类型
            VarType vartype = (VarType)(Enum.Parse(typeof(VarType), this.comVarType.SelectedItem.ToString(), false));

            //获取选择的地址
            StoreArea storearea = (StoreArea)(Enum.Parse(typeof(StoreArea), this.comStoreAre.SelectedItem. ToString(), false));
            //创建接收字节数组
            byte[] result = null;

            switch (vartype)
            {
                case VarType.Bit:
                    switch (storearea)
                    {
                        case StoreArea.输出线圈0X:
                            result = ObjModbusRtu.ReadOutputStatus(DevAdd, Address, Length);
                             break;
                        case StoreArea.输入状态1X:

                            break;
                        case StoreArea.输入寄存器3X:

                            break;
                        case StoreArea.输出寄存器4X:

                            AddLog(1, "读取失败，存储区类型不正确");
                            return;
                    }

                    string binarstring = string.Empty;  //只读
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            char[] Tempc = Convert.ToString(item, 2).PadLeft(8, '0').ToCharArray();
                            Array.Reverse(Tempc);//翻转字节顺序

                            binarstring += new string (Tempc);

                        }
                        AddLog(0, "读取成功，结果为" + binarstring.Substring(0, Length));
                    }
                    else
                    {
                        AddLog(1, "读取失败，请检查设置");

                    }

                    break;



            }


        }

        private void butnConnect_Click(object sender, EventArgs e)
        {

            Fun_Connected();

        }

        private void butnDisconnect_Click(object sender, EventArgs e)
        {

            Fun_CloseConnected();

        }
    }
}
