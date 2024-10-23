
namespace modbusStart
{
    partial class ModbusStation
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModbusStation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butnDisconnect = new System.Windows.Forms.Button();
            this.butnConnect = new System.Windows.Forms.Button();
            this.comDatabits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comDataFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comBound = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comStopbit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.ComChooseLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listInfo = new System.Windows.Forms.ListView();
            this.infotime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textLength = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textStartArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comVarType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comStoreAre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSlaveID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butnDisconnect);
            this.groupBox1.Controls.Add(this.butnConnect);
            this.groupBox1.Controls.Add(this.comDatabits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comParity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comDataFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comBound);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comStopbit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comPort);
            this.groupBox1.Controls.Add(this.ComChooseLabel);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通信参数";
            // 
            // butnDisconnect
            // 
            this.butnDisconnect.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butnDisconnect.Location = new System.Drawing.Point(657, 79);
            this.butnDisconnect.Name = "butnDisconnect";
            this.butnDisconnect.Size = new System.Drawing.Size(94, 44);
            this.butnDisconnect.TabIndex = 13;
            this.butnDisconnect.Text = "断开连接";
            this.butnDisconnect.UseVisualStyleBackColor = true;
            this.butnDisconnect.Click += new System.EventHandler(this.butnDisconnect_Click);
            // 
            // butnConnect
            // 
            this.butnConnect.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butnConnect.Location = new System.Drawing.Point(657, 19);
            this.butnConnect.Name = "butnConnect";
            this.butnConnect.Size = new System.Drawing.Size(94, 44);
            this.butnConnect.TabIndex = 12;
            this.butnConnect.Text = "建立连接";
            this.butnConnect.UseVisualStyleBackColor = true;
            this.butnConnect.Click += new System.EventHandler(this.butnConnect_Click);
            // 
            // comDatabits
            // 
            this.comDatabits.FormattingEnabled = true;
            this.comDatabits.Location = new System.Drawing.Point(516, 91);
            this.comDatabits.Name = "comDatabits";
            this.comDatabits.Size = new System.Drawing.Size(81, 23);
            this.comDatabits.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(441, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "数据位";
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Location = new System.Drawing.Point(516, 31);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(81, 23);
            this.comParity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(441, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "校验位";
            // 
            // comDataFormat
            // 
            this.comDataFormat.FormattingEnabled = true;
            this.comDataFormat.Location = new System.Drawing.Point(327, 90);
            this.comDataFormat.Name = "comDataFormat";
            this.comDataFormat.Size = new System.Drawing.Size(81, 23);
            this.comDataFormat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "数据格式";
            // 
            // comBound
            // 
            this.comBound.FormattingEnabled = true;
            this.comBound.Location = new System.Drawing.Point(307, 31);
            this.comBound.Name = "comBound";
            this.comBound.Size = new System.Drawing.Size(81, 23);
            this.comBound.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "波特率";
            // 
            // comStopbit
            // 
            this.comStopbit.FormattingEnabled = true;
            this.comStopbit.Location = new System.Drawing.Point(95, 87);
            this.comStopbit.Name = "comStopbit";
            this.comStopbit.Size = new System.Drawing.Size(81, 23);
            this.comStopbit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "停止位";
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(95, 31);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(81, 23);
            this.comPort.TabIndex = 1;
            // 
            // ComChooseLabel
            // 
            this.ComChooseLabel.AutoSize = true;
            this.ComChooseLabel.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComChooseLabel.Location = new System.Drawing.Point(20, 35);
            this.ComChooseLabel.Name = "ComChooseLabel";
            this.ComChooseLabel.Size = new System.Drawing.Size(69, 19);
            this.ComChooseLabel.TabIndex = 0;
            this.ComChooseLabel.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listInfo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.buttonWrite);
            this.groupBox2.Controls.Add(this.textLength);
            this.groupBox2.Controls.Add(this.buttonRead);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textStartArea);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comVarType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comStoreAre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textSlaveID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(22, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读写测试";
            // 
            // listInfo
            // 
            this.listInfo.BackColor = System.Drawing.SystemColors.Control;
            this.listInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.infotime,
            this.info});
            this.listInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listInfo.HideSelection = false;
            this.listInfo.Location = new System.Drawing.Point(25, 274);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(741, 146);
            this.listInfo.SmallImageList = this.imageList1;
            this.listInfo.TabIndex = 19;
            this.listInfo.UseCompatibleStateImageBehavior = false;
            this.listInfo.View = System.Windows.Forms.View.Details;
            // 
            // infotime
            // 
            this.infotime.Text = "日志时间";
            this.infotime.Width = 341;
            // 
            // info
            // 
            this.info.Text = "日志信息";
            this.info.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.ico");
            this.imageList1.Images.SetKeyName(1, "warning.ico");
            this.imageList1.Images.SetKeyName(2, "error.ico");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(33, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "读写信息：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 28);
            this.textBox1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "写入数值（空格分隔）：";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(587, 167);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(94, 44);
            this.buttonWrite.TabIndex = 15;
            this.buttonWrite.Text = "写入";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(358, 107);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 28);
            this.textLength.TabIndex = 10;
            this.textLength.Text = "1";
            this.textLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(587, 107);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(94, 44);
            this.buttonRead.TabIndex = 14;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "读写长度：";
            // 
            // textStartArea
            // 
            this.textStartArea.Location = new System.Drawing.Point(120, 107);
            this.textStartArea.Name = "textStartArea";
            this.textStartArea.Size = new System.Drawing.Size(100, 28);
            this.textStartArea.TabIndex = 8;
            this.textStartArea.Text = "0";
            this.textStartArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "起始地址：";
            // 
            // comVarType
            // 
            this.comVarType.FormattingEnabled = true;
            this.comVarType.Location = new System.Drawing.Point(641, 45);
            this.comVarType.Name = "comVarType";
            this.comVarType.Size = new System.Drawing.Size(121, 26);
            this.comVarType.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "变量类型";
            // 
            // comStoreAre
            // 
            this.comStoreAre.FormattingEnabled = true;
            this.comStoreAre.Location = new System.Drawing.Point(386, 45);
            this.comStoreAre.Name = "comStoreAre";
            this.comStoreAre.Size = new System.Drawing.Size(121, 26);
            this.comStoreAre.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "寄存器地址";
            // 
            // textSlaveID
            // 
            this.textSlaveID.Location = new System.Drawing.Point(120, 45);
            this.textSlaveID.Name = "textSlaveID";
            this.textSlaveID.Size = new System.Drawing.Size(100, 28);
            this.textSlaveID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "从站地址：";
            // 
            // ModbusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModbusStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModbusRTU通讯平台";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comDataFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comStopbit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.Label ComChooseLabel;
        private System.Windows.Forms.Button butnDisconnect;
        private System.Windows.Forms.Button butnConnect;
        private System.Windows.Forms.ComboBox comDatabits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSlaveID;
        private System.Windows.Forms.TextBox textStartArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comVarType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comStoreAre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listInfo;
        private System.Windows.Forms.ColumnHeader infotime;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.ImageList imageList1;
    }
}

