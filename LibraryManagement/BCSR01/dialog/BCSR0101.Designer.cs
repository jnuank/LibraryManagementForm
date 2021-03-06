﻿namespace BCSR01.dialog
{
    partial class BCSR0101
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
            if ( disposing && (components != null) )
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLending = new System.Windows.Forms.CheckBox();
            this.cmbCategory3 = new System.Windows.Forms.ComboBox();
            this.cmbCategory2 = new System.Windows.Forms.ComboBox();
            this.cmbCategory1 = new System.Windows.Forms.ComboBox();
            this.lblCategory3 = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new Common.control.DataGridViewCustom();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLending);
            this.groupBox1.Controls.Add(this.cmbCategory3);
            this.groupBox1.Controls.Add(this.cmbCategory2);
            this.groupBox1.Controls.Add(this.cmbCategory1);
            this.groupBox1.Controls.Add(this.lblCategory3);
            this.groupBox1.Controls.Add(this.lblCategory2);
            this.groupBox1.Controls.Add(this.lblCategory1);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索条件";
            // 
            // chkLending
            // 
            this.chkLending.AutoSize = true;
            this.chkLending.BackColor = System.Drawing.Color.PowderBlue;
            this.chkLending.Location = new System.Drawing.Point(18, 92);
            this.chkLending.Name = "chkLending";
            this.chkLending.Size = new System.Drawing.Size(88, 16);
            this.chkLending.TabIndex = 5;
            this.chkLending.Text = "貸出中は除く";
            this.chkLending.UseVisualStyleBackColor = false;
            // 
            // cmbCategory3
            // 
            this.cmbCategory3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory3.FormattingEnabled = true;
            this.cmbCategory3.Location = new System.Drawing.Point(596, 52);
            this.cmbCategory3.Name = "cmbCategory3";
            this.cmbCategory3.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory3.TabIndex = 4;
            // 
            // cmbCategory2
            // 
            this.cmbCategory2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory2.FormattingEnabled = true;
            this.cmbCategory2.Location = new System.Drawing.Point(354, 52);
            this.cmbCategory2.Name = "cmbCategory2";
            this.cmbCategory2.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory2.TabIndex = 3;
            // 
            // cmbCategory1
            // 
            this.cmbCategory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory1.FormattingEnabled = true;
            this.cmbCategory1.Location = new System.Drawing.Point(113, 52);
            this.cmbCategory1.Name = "cmbCategory1";
            this.cmbCategory1.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory1.TabIndex = 2;
            // 
            // lblCategory3
            // 
            this.lblCategory3.AutoSize = true;
            this.lblCategory3.BackColor = System.Drawing.Color.PowderBlue;
            this.lblCategory3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCategory3.Location = new System.Drawing.Point(495, 57);
            this.lblCategory3.Name = "lblCategory3";
            this.lblCategory3.Size = new System.Drawing.Size(83, 15);
            this.lblCategory3.TabIndex = 12;
            this.lblCategory3.Text = "書籍区分3：";
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.BackColor = System.Drawing.Color.PowderBlue;
            this.lblCategory2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCategory2.Location = new System.Drawing.Point(254, 57);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(83, 15);
            this.lblCategory2.TabIndex = 11;
            this.lblCategory2.Text = "書籍区分2：";
            // 
            // lblCategory1
            // 
            this.lblCategory1.AutoSize = true;
            this.lblCategory1.BackColor = System.Drawing.Color.PowderBlue;
            this.lblCategory1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCategory1.Location = new System.Drawing.Point(15, 57);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(83, 15);
            this.lblCategory1.TabIndex = 9;
            this.lblCategory1.Text = "書籍区分1：";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(326, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(442, 19);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.PowderBlue;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(254, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 15);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "タイトル：";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.PowderBlue;
            this.lblId.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblId.Location = new System.Drawing.Point(15, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 15);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "書籍ID：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(99, 19);
            this.txtId.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(848, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(930, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(930, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 224);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BCSR0101
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "BCSR0101";
            this.Text = "図書検索";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BCMT0101_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCategory3;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCategory3;
        private System.Windows.Forms.ComboBox cmbCategory2;
        private System.Windows.Forms.ComboBox cmbCategory1;
        private System.Windows.Forms.CheckBox chkLending;
        private Common.control.DataGridViewCustom dataGridView1;
    }
}