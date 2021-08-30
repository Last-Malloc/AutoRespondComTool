
namespace SendCodeServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listKey = new System.Windows.Forms.ListBox();
            this.keyAdd = new System.Windows.Forms.Button();
            this.keyDelete = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkIllegalTipForKey = new System.Windows.Forms.CheckBox();
            this.keyCopy = new System.Windows.Forms.Button();
            this.checkIllegalTipForValue = new System.Windows.Forms.CheckBox();
            this.valueCopy = new System.Windows.Forms.Button();
            this.listValue = new System.Windows.Forms.ListBox();
            this.valueDele = new System.Windows.Forms.Button();
            this.valueAdd = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboSendSocket = new System.Windows.Forms.ComboBox();
            this.checkIllegalTipForSend = new System.Windows.Forms.CheckBox();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textSend = new System.Windows.Forms.TextBox();
            this.radioChar = new System.Windows.Forms.RadioButton();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.textDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkAutoSend = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textClientIP = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.textClientPort = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.textPort = new System.Windows.Forms.TextBox();
            this.listRecent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listKey
            // 
            this.listKey.FormattingEnabled = true;
            this.listKey.ItemHeight = 20;
            this.listKey.Location = new System.Drawing.Point(12, 12);
            this.listKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listKey.Name = "listKey";
            this.listKey.Size = new System.Drawing.Size(418, 364);
            this.listKey.TabIndex = 0;
            this.listKey.SelectedIndexChanged += new System.EventHandler(this.listKey_SelectedIndexChanged);
            // 
            // keyAdd
            // 
            this.keyAdd.Location = new System.Drawing.Point(12, 455);
            this.keyAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyAdd.Name = "keyAdd";
            this.keyAdd.Size = new System.Drawing.Size(120, 29);
            this.keyAdd.TabIndex = 1;
            this.keyAdd.Text = "添加键";
            this.keyAdd.UseVisualStyleBackColor = true;
            this.keyAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // keyDelete
            // 
            this.keyDelete.Location = new System.Drawing.Point(161, 455);
            this.keyDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyDelete.Name = "keyDelete";
            this.keyDelete.Size = new System.Drawing.Size(120, 29);
            this.keyDelete.TabIndex = 2;
            this.keyDelete.Text = "删除键";
            this.keyDelete.UseVisualStyleBackColor = true;
            this.keyDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(12, 422);
            this.textKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(418, 27);
            this.textKey.TabIndex = 3;
            this.textKey.TextChanged += new System.EventHandler(this.textKey_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.checkIllegalTipForKey);
            this.splitContainer1.Panel1.Controls.Add(this.keyCopy);
            this.splitContainer1.Panel1.Controls.Add(this.listKey);
            this.splitContainer1.Panel1.Controls.Add(this.textKey);
            this.splitContainer1.Panel1.Controls.Add(this.keyAdd);
            this.splitContainer1.Panel1.Controls.Add(this.keyDelete);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.checkIllegalTipForValue);
            this.splitContainer1.Panel2.Controls.Add(this.valueCopy);
            this.splitContainer1.Panel2.Controls.Add(this.listValue);
            this.splitContainer1.Panel2.Controls.Add(this.valueDele);
            this.splitContainer1.Panel2.Controls.Add(this.valueAdd);
            this.splitContainer1.Panel2.Controls.Add(this.textValue);
            this.splitContainer1.Size = new System.Drawing.Size(885, 495);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 6;
            // 
            // checkIllegalTipForKey
            // 
            this.checkIllegalTipForKey.BackColor = System.Drawing.Color.Transparent;
            this.checkIllegalTipForKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIllegalTipForKey.Location = new System.Drawing.Point(12, 392);
            this.checkIllegalTipForKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkIllegalTipForKey.Name = "checkIllegalTipForKey";
            this.checkIllegalTipForKey.Size = new System.Drawing.Size(165, 31);
            this.checkIllegalTipForKey.TabIndex = 13;
            this.checkIllegalTipForKey.Text = "非法字符提示";
            this.checkIllegalTipForKey.UseVisualStyleBackColor = false;
            // 
            // keyCopy
            // 
            this.keyCopy.Location = new System.Drawing.Point(310, 455);
            this.keyCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyCopy.Name = "keyCopy";
            this.keyCopy.Size = new System.Drawing.Size(120, 29);
            this.keyCopy.TabIndex = 4;
            this.keyCopy.Text = "复制键";
            this.keyCopy.UseVisualStyleBackColor = true;
            this.keyCopy.Click += new System.EventHandler(this.keyCopy_Click);
            // 
            // checkIllegalTipForValue
            // 
            this.checkIllegalTipForValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIllegalTipForValue.Location = new System.Drawing.Point(14, 342);
            this.checkIllegalTipForValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkIllegalTipForValue.Name = "checkIllegalTipForValue";
            this.checkIllegalTipForValue.Size = new System.Drawing.Size(165, 29);
            this.checkIllegalTipForValue.TabIndex = 14;
            this.checkIllegalTipForValue.Text = "非法字符提示";
            this.checkIllegalTipForValue.UseVisualStyleBackColor = true;
            // 
            // valueCopy
            // 
            this.valueCopy.Location = new System.Drawing.Point(298, 455);
            this.valueCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueCopy.Name = "valueCopy";
            this.valueCopy.Size = new System.Drawing.Size(120, 29);
            this.valueCopy.TabIndex = 6;
            this.valueCopy.Text = "复制值";
            this.valueCopy.UseVisualStyleBackColor = true;
            this.valueCopy.Click += new System.EventHandler(this.valueCopy_Click);
            // 
            // listValue
            // 
            this.listValue.FormattingEnabled = true;
            this.listValue.ItemHeight = 20;
            this.listValue.Location = new System.Drawing.Point(14, 12);
            this.listValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listValue.Name = "listValue";
            this.listValue.Size = new System.Drawing.Size(404, 324);
            this.listValue.TabIndex = 4;
            // 
            // valueDele
            // 
            this.valueDele.Location = new System.Drawing.Point(156, 455);
            this.valueDele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueDele.Name = "valueDele";
            this.valueDele.Size = new System.Drawing.Size(120, 29);
            this.valueDele.TabIndex = 4;
            this.valueDele.Text = "删除值";
            this.valueDele.UseVisualStyleBackColor = true;
            this.valueDele.Click += new System.EventHandler(this.valueDele_Click);
            // 
            // valueAdd
            // 
            this.valueAdd.Location = new System.Drawing.Point(14, 455);
            this.valueAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueAdd.Name = "valueAdd";
            this.valueAdd.Size = new System.Drawing.Size(120, 29);
            this.valueAdd.TabIndex = 5;
            this.valueAdd.Text = "添加值";
            this.valueAdd.UseVisualStyleBackColor = true;
            this.valueAdd.Click += new System.EventHandler(this.valueAdd_Click);
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(14, 372);
            this.textValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textValue.Multiline = true;
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(404, 77);
            this.textValue.TabIndex = 4;
            this.textValue.TextChanged += new System.EventHandler(this.textValue_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listRecent);
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 489);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.comboSendSocket);
            this.panel4.Controls.Add(this.checkIllegalTipForSend);
            this.panel4.Controls.Add(this.btnCopyHex);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.textSend);
            this.panel4.Controls.Add(this.radioChar);
            this.panel4.Controls.Add(this.radioHex);
            this.panel4.Controls.Add(this.textDelay);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.checkAutoSend);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Location = new System.Drawing.Point(12, 345);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(855, 136);
            this.panel4.TabIndex = 13;
            // 
            // comboSendSocket
            // 
            this.comboSendSocket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSendSocket.FormattingEnabled = true;
            this.comboSendSocket.Location = new System.Drawing.Point(676, 7);
            this.comboSendSocket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSendSocket.Name = "comboSendSocket";
            this.comboSendSocket.Size = new System.Drawing.Size(176, 28);
            this.comboSendSocket.TabIndex = 18;
            // 
            // checkIllegalTipForSend
            // 
            this.checkIllegalTipForSend.BackColor = System.Drawing.Color.Transparent;
            this.checkIllegalTipForSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIllegalTipForSend.Location = new System.Drawing.Point(525, 5);
            this.checkIllegalTipForSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkIllegalTipForSend.Name = "checkIllegalTipForSend";
            this.checkIllegalTipForSend.Size = new System.Drawing.Size(165, 31);
            this.checkIllegalTipForSend.TabIndex = 17;
            this.checkIllegalTipForSend.Text = "非法字符提示";
            this.checkIllegalTipForSend.UseVisualStyleBackColor = false;
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyHex.Location = new System.Drawing.Point(743, 104);
            this.btnCopyHex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.Size = new System.Drawing.Size(109, 31);
            this.btnCopyHex.TabIndex = 16;
            this.btnCopyHex.Text = "复制HEX";
            this.btnCopyHex.UseVisualStyleBackColor = true;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(743, 41);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 31);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(3, 41);
            this.textSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(734, 92);
            this.textSend.TabIndex = 14;
            this.textSend.TextChanged += new System.EventHandler(this.textSend_TextChanged);
            // 
            // radioChar
            // 
            this.radioChar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioChar.Location = new System.Drawing.Point(109, 4);
            this.radioChar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioChar.Name = "radioChar";
            this.radioChar.Size = new System.Drawing.Size(113, 35);
            this.radioChar.TabIndex = 14;
            this.radioChar.TabStop = true;
            this.radioChar.Text = "字符显示";
            this.radioChar.UseVisualStyleBackColor = true;
            // 
            // radioHex
            // 
            this.radioHex.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioHex.Location = new System.Drawing.Point(3, 5);
            this.radioHex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(158, 31);
            this.radioHex.TabIndex = 13;
            this.radioHex.TabStop = true;
            this.radioHex.Text = "HEX显示";
            this.radioHex.UseVisualStyleBackColor = true;
            // 
            // textDelay
            // 
            this.textDelay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDelay.Location = new System.Drawing.Point(429, 5);
            this.textDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDelay.MaximumSize = new System.Drawing.Size(80, 27);
            this.textDelay.Name = "textDelay";
            this.textDelay.Size = new System.Drawing.Size(80, 33);
            this.textDelay.TabIndex = 10;
            this.textDelay.Text = "500";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(339, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "回复延迟";
            // 
            // checkAutoSend
            // 
            this.checkAutoSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkAutoSend.Location = new System.Drawing.Point(228, 6);
            this.checkAutoSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkAutoSend.Name = "checkAutoSend";
            this.checkAutoSend.Size = new System.Drawing.Size(136, 31);
            this.checkAutoSend.TabIndex = 12;
            this.checkAutoSend.Text = "自动回复";
            this.checkAutoSend.UseVisualStyleBackColor = true;
            this.checkAutoSend.CheckedChanged += new System.EventHandler(this.checkAutoSend_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(743, 72);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空窗口";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.textClientIP);
            this.panel3.Controls.Add(this.btnConn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDisconn);
            this.panel3.Controls.Add(this.textClientPort);
            this.panel3.Location = new System.Drawing.Point(402, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 44);
            this.panel3.TabIndex = 11;
            // 
            // textClientIP
            // 
            this.textClientIP.Location = new System.Drawing.Point(78, 7);
            this.textClientIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textClientIP.Name = "textClientIP";
            this.textClientIP.Size = new System.Drawing.Size(135, 27);
            this.textClientIP.TabIndex = 10;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(315, 7);
            this.btnConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(60, 29);
            this.btnConn.TabIndex = 5;
            this.btnConn.Text = "连接";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client";
            // 
            // btnDisconn
            // 
            this.btnDisconn.Location = new System.Drawing.Point(392, 7);
            this.btnDisconn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(60, 29);
            this.btnDisconn.TabIndex = 6;
            this.btnDisconn.Text = "断开";
            this.btnDisconn.UseVisualStyleBackColor = true;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // textClientPort
            // 
            this.textClientPort.Location = new System.Drawing.Point(225, 7);
            this.textClientPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textClientPort.Name = "textClientPort";
            this.textClientPort.Size = new System.Drawing.Size(73, 27);
            this.textClientPort.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.textPort);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 44);
            this.panel2.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(165, 7);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开启服务";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(271, 7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 29);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止服务";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(85, 7);
            this.textPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(73, 27);
            this.textPort.TabIndex = 4;
            // 
            // listRecent
            // 
            this.listRecent.FormattingEnabled = true;
            this.listRecent.ItemHeight = 20;
            this.listRecent.Location = new System.Drawing.Point(12, 55);
            this.listRecent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRecent.Name = "listRecent";
            this.listRecent.Size = new System.Drawing.Size(855, 284);
            this.listRecent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 983);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "AutoRespondComTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listKey;
        private System.Windows.Forms.Button keyAdd;
        private System.Windows.Forms.Button keyDelete;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listRecent;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.ListBox listValue;
        private System.Windows.Forms.Button valueDele;
        private System.Windows.Forms.Button valueAdd;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button keyCopy;
        private System.Windows.Forms.Button valueCopy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.TextBox textClientPort;
        private System.Windows.Forms.TextBox textClientIP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkAutoSend;
        private System.Windows.Forms.TextBox textDelay;
        private System.Windows.Forms.CheckBox checkIllegalTipForKey;
        private System.Windows.Forms.CheckBox checkIllegalTipForValue;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.RadioButton radioChar;
        private System.Windows.Forms.RadioButton radioHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyHex;
        private System.Windows.Forms.CheckBox checkIllegalTipForSend;
        private System.Windows.Forms.ComboBox comboSendSocket;
    }
}

