using System.Windows.Forms;

namespace CLsChat
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtongrp = new System.Windows.Forms.RadioButton();
            this.radioButtonindv = new System.Windows.Forms.RadioButton();
            this.listIndev = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.labeldate1 = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labFrom = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.comboBoxIN = new System.Windows.Forms.ComboBox();
            this.btnsrcIN = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridInbox = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labtoSent = new System.Windows.Forms.Label();
            this.labfromSent = new System.Windows.Forms.Label();
            this.labeltoSent = new System.Windows.Forms.Label();
            this.labelfromSent = new System.Windows.Forms.Label();
            this.txtToSent = new System.Windows.Forms.TextBox();
            this.comboBoxSent = new System.Windows.Forms.ComboBox();
            this.btnsrcSent = new System.Windows.Forms.Button();
            this.txtSRcSent = new System.Windows.Forms.TextBox();
            this.sentrefresh = new System.Windows.Forms.Button();
            this.dataGridsent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInbox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 47);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.radioButtongrp);
            this.tabPage1.Controls.Add(this.radioButtonindv);
            this.tabPage1.Controls.Add(this.listIndev);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtmessage);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1340, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtongrp
            // 
            this.radioButtongrp.AutoSize = true;
            this.radioButtongrp.Location = new System.Drawing.Point(1172, 470);
            this.radioButtongrp.Name = "radioButtongrp";
            this.radioButtongrp.Size = new System.Drawing.Size(72, 20);
            this.radioButtongrp.TabIndex = 17;
            this.radioButtongrp.TabStop = true;
            this.radioButtongrp.Text = "Groups";
            this.radioButtongrp.UseVisualStyleBackColor = true;
            this.radioButtongrp.CheckedChanged += new System.EventHandler(this.radioButtongrp_CheckedChanged);
            // 
            // radioButtonindv
            // 
            this.radioButtonindv.AutoSize = true;
            this.radioButtonindv.Location = new System.Drawing.Point(1054, 470);
            this.radioButtonindv.Name = "radioButtonindv";
            this.radioButtonindv.Size = new System.Drawing.Size(85, 20);
            this.radioButtonindv.TabIndex = 16;
            this.radioButtonindv.TabStop = true;
            this.radioButtonindv.Text = "Individual";
            this.radioButtonindv.UseVisualStyleBackColor = true;
            this.radioButtonindv.CheckedChanged += new System.EventHandler(this.radioButtonindv_CheckedChanged);
            // 
            // listIndev
            // 
            this.listIndev.FormattingEnabled = true;
            this.listIndev.ItemHeight = 16;
            this.listIndev.Location = new System.Drawing.Point(1039, 60);
            this.listIndev.Name = "listIndev";
            this.listIndev.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listIndev.Size = new System.Drawing.Size(271, 404);
            this.listIndev.TabIndex = 13;
            this.listIndev.SelectedIndexChanged += new System.EventHandler(this.listIndev_SelectedIndexChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1039, 33);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "select All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(140, 442);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subjject";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(140, 78);
            this.txtmessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(816, 356);
            this.txtmessage.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(140, 34);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(816, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelDate2);
            this.tabPage2.Controls.Add(this.labeldate1);
            this.tabPage2.Controls.Add(this.labTo);
            this.tabPage2.Controls.Add(this.labFrom);
            this.tabPage2.Controls.Add(this.txtTime);
            this.tabPage2.Controls.Add(this.comboBoxIN);
            this.tabPage2.Controls.Add(this.btnsrcIN);
            this.tabPage2.Controls.Add(this.txtSrc);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.dataGridInbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1340, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "inbox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Location = new System.Drawing.Point(651, 72);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(93, 16);
            this.labelDate2.TabIndex = 9;
            this.labelDate2.Text = "YYYY-MM-DD";
            // 
            // labeldate1
            // 
            this.labeldate1.AutoSize = true;
            this.labeldate1.Location = new System.Drawing.Point(340, 72);
            this.labeldate1.Name = "labeldate1";
            this.labeldate1.Size = new System.Drawing.Size(93, 16);
            this.labeldate1.TabIndex = 8;
            this.labeldate1.Text = "YYYY-MM-DD";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Location = new System.Drawing.Point(614, 119);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(24, 16);
            this.labTo.TabIndex = 7;
            this.labTo.Text = "To";
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Location = new System.Drawing.Point(302, 119);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(33, 16);
            this.labFrom.TabIndex = 6;
            this.labFrom.Text = "from";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(644, 116);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(270, 22);
            this.txtTime.TabIndex = 5;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // comboBoxIN
            // 
            this.comboBoxIN.FormattingEnabled = true;
            this.comboBoxIN.Items.AddRange(new object[] {
            "date",
            "sender",
            "supject"});
            this.comboBoxIN.Location = new System.Drawing.Point(103, 111);
            this.comboBoxIN.Name = "comboBoxIN";
            this.comboBoxIN.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIN.TabIndex = 4;
            this.comboBoxIN.SelectedIndexChanged += new System.EventHandler(this.comboBoxIN_SelectedIndexChanged);
            // 
            // btnsrcIN
            // 
            this.btnsrcIN.Location = new System.Drawing.Point(940, 112);
            this.btnsrcIN.Name = "btnsrcIN";
            this.btnsrcIN.Size = new System.Drawing.Size(75, 23);
            this.btnsrcIN.TabIndex = 3;
            this.btnsrcIN.Text = "Search";
            this.btnsrcIN.UseVisualStyleBackColor = true;
            this.btnsrcIN.Click += new System.EventHandler(this.btnsrcIN_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(341, 116);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(252, 22);
            this.txtSrc.TabIndex = 2;
            this.txtSrc.TextChanged += new System.EventHandler(this.txtSrc_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1153, 35);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridInbox
            // 
            this.dataGridInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridInbox.Location = new System.Drawing.Point(4, 154);
            this.dataGridInbox.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInbox.Name = "dataGridInbox";
            this.dataGridInbox.RowHeadersWidth = 51;
            this.dataGridInbox.Size = new System.Drawing.Size(1332, 341);
            this.dataGridInbox.TabIndex = 0;
            this.dataGridInbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInbox_CellContentClick);
            this.dataGridInbox.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInbox_CellValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labtoSent);
            this.tabPage3.Controls.Add(this.labfromSent);
            this.tabPage3.Controls.Add(this.labeltoSent);
            this.tabPage3.Controls.Add(this.labelfromSent);
            this.tabPage3.Controls.Add(this.txtToSent);
            this.tabPage3.Controls.Add(this.comboBoxSent);
            this.tabPage3.Controls.Add(this.btnsrcSent);
            this.tabPage3.Controls.Add(this.txtSRcSent);
            this.tabPage3.Controls.Add(this.sentrefresh);
            this.tabPage3.Controls.Add(this.dataGridsent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1340, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sent items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labtoSent
            // 
            this.labtoSent.AutoSize = true;
            this.labtoSent.Location = new System.Drawing.Point(617, 68);
            this.labtoSent.Name = "labtoSent";
            this.labtoSent.Size = new System.Drawing.Size(93, 16);
            this.labtoSent.TabIndex = 17;
            this.labtoSent.Text = "YYYY-MM-DD";
            // 
            // labfromSent
            // 
            this.labfromSent.AutoSize = true;
            this.labfromSent.Location = new System.Drawing.Point(306, 68);
            this.labfromSent.Name = "labfromSent";
            this.labfromSent.Size = new System.Drawing.Size(93, 16);
            this.labfromSent.TabIndex = 16;
            this.labfromSent.Text = "YYYY-MM-DD";
            // 
            // labeltoSent
            // 
            this.labeltoSent.AutoSize = true;
            this.labeltoSent.Location = new System.Drawing.Point(580, 115);
            this.labeltoSent.Name = "labeltoSent";
            this.labeltoSent.Size = new System.Drawing.Size(24, 16);
            this.labeltoSent.TabIndex = 15;
            this.labeltoSent.Text = "To";
            // 
            // labelfromSent
            // 
            this.labelfromSent.AutoSize = true;
            this.labelfromSent.Location = new System.Drawing.Point(268, 115);
            this.labelfromSent.Name = "labelfromSent";
            this.labelfromSent.Size = new System.Drawing.Size(33, 16);
            this.labelfromSent.TabIndex = 14;
            this.labelfromSent.Text = "from";
            // 
            // txtToSent
            // 
            this.txtToSent.Location = new System.Drawing.Point(610, 112);
            this.txtToSent.Name = "txtToSent";
            this.txtToSent.Size = new System.Drawing.Size(270, 22);
            this.txtToSent.TabIndex = 13;
            // 
            // comboBoxSent
            // 
            this.comboBoxSent.FormattingEnabled = true;
            this.comboBoxSent.Items.AddRange(new object[] {
            "Date",
            "Recipient",
            "Supject"});
            this.comboBoxSent.Location = new System.Drawing.Point(68, 107);
            this.comboBoxSent.Name = "comboBoxSent";
            this.comboBoxSent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSent.TabIndex = 12;
            this.comboBoxSent.SelectedIndexChanged += new System.EventHandler(this.comboBoxSent_SelectedIndexChanged);
            // 
            // btnsrcSent
            // 
            this.btnsrcSent.Location = new System.Drawing.Point(906, 108);
            this.btnsrcSent.Name = "btnsrcSent";
            this.btnsrcSent.Size = new System.Drawing.Size(75, 23);
            this.btnsrcSent.TabIndex = 11;
            this.btnsrcSent.Text = "Search";
            this.btnsrcSent.UseVisualStyleBackColor = true;
            this.btnsrcSent.Click += new System.EventHandler(this.btnsrcSent_Click);
            // 
            // txtSRcSent
            // 
            this.txtSRcSent.Location = new System.Drawing.Point(307, 112);
            this.txtSRcSent.Name = "txtSRcSent";
            this.txtSRcSent.Size = new System.Drawing.Size(252, 22);
            this.txtSRcSent.TabIndex = 10;
            this.txtSRcSent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sentrefresh
            // 
            this.sentrefresh.Location = new System.Drawing.Point(1152, 34);
            this.sentrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.sentrefresh.Name = "sentrefresh";
            this.sentrefresh.Size = new System.Drawing.Size(100, 28);
            this.sentrefresh.TabIndex = 2;
            this.sentrefresh.Text = "Refresh";
            this.sentrefresh.UseVisualStyleBackColor = true;
            this.sentrefresh.Click += new System.EventHandler(this.sentrefresh_Click);
            // 
            // dataGridsent
            // 
            this.dataGridsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridsent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridsent.Location = new System.Drawing.Point(0, 158);
            this.dataGridsent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridsent.Name = "dataGridsent";
            this.dataGridsent.RowHeadersWidth = 51;
            this.dataGridsent.Size = new System.Drawing.Size(1340, 341);
            this.dataGridsent.TabIndex = 1;
            this.dataGridsent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridsent_CellContentClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 590);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInbox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridInbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button sentrefresh;
        private System.Windows.Forms.DataGridView dataGridsent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listIndev;
        private System.Windows.Forms.RadioButton radioButtongrp;
        private System.Windows.Forms.RadioButton radioButtonindv;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnsrcIN;
        private System.Windows.Forms.ComboBox comboBoxIN;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Label labeldate1;
        private System.Windows.Forms.Label labtoSent;
        private System.Windows.Forms.Label labfromSent;
        private System.Windows.Forms.Label labeltoSent;
        private System.Windows.Forms.Label labelfromSent;
        private System.Windows.Forms.TextBox txtToSent;
        private System.Windows.Forms.ComboBox comboBoxSent;
        private System.Windows.Forms.Button btnsrcSent;
        private System.Windows.Forms.TextBox txtSRcSent;
    }
}