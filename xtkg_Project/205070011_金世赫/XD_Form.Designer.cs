namespace _205070011_金世赫
{
    partial class XD_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XD_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDL = new System.Windows.Forms.Button();
            this.tboxRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.dgInfo = new System.Windows.Forms.DataGridView();
            this.cboxViewClass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxScore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDL);
            this.groupBox1.Controls.Add(this.tboxRef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生登录";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tboxScore
            // 
            this.tboxScore.Location = new System.Drawing.Point(63, 113);
            this.tboxScore.Name = "tboxScore";
            this.tboxScore.PlaceholderText = "作业，小组报告，期末考试";
            this.tboxScore.Size = new System.Drawing.Size(212, 24);
            this.tboxScore.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "成绩 :";
            // 
            // btnDL
            // 
            this.btnDL.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDL.Location = new System.Drawing.Point(290, 146);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(90, 26);
            this.btnDL.TabIndex = 9;
            this.btnDL.Text = "登  录";
            this.btnDL.UseVisualStyleBackColor = true;
            this.btnDL.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tboxRef
            // 
            this.tboxRef.Location = new System.Drawing.Point(63, 147);
            this.tboxRef.Name = "tboxRef";
            this.tboxRef.Size = new System.Drawing.Size(212, 24);
            this.tboxRef.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "备注 :";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(118, 84);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoFemale.Size = new System.Drawing.Size(40, 23);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(63, 84);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(40, 23);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别 :";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(63, 57);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 24);
            this.tboxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名 :";
            // 
            // cboxClass
            // 
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Items.AddRange(new object[] {
            "A班",
            "B班",
            "C班",
            "D班"});
            this.cboxClass.Location = new System.Drawing.Point(63, 24);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(100, 27);
            this.cboxClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTC);
            this.groupBox2.Controls.Add(this.btnSC);
            this.groupBox2.Controls.Add(this.dgInfo);
            this.groupBox2.Controls.Add(this.cboxViewClass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(10, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生名单";
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTC.Location = new System.Drawing.Point(481, 22);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(90, 26);
            this.btnTC.TabIndex = 12;
            this.btnTC.Text = "退  出";
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSC.Location = new System.Drawing.Point(380, 22);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(90, 26);
            this.btnSC.TabIndex = 10;
            this.btnSC.Text = "删  除";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnViewDataDel_Click);
            // 
            // dgInfo
            // 
            this.dgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInfo.Location = new System.Drawing.Point(8, 63);
            this.dgInfo.Name = "dgInfo";
            this.dgInfo.RowTemplate.Height = 25;
            this.dgInfo.Size = new System.Drawing.Size(563, 118);
            this.dgInfo.TabIndex = 11;
            // 
            // cboxViewClass
            // 
            this.cboxViewClass.FormattingEnabled = true;
            this.cboxViewClass.Items.AddRange(new object[] {
            "A班",
            "B班",
            "C班",
            "D班"});
            this.cboxViewClass.Location = new System.Drawing.Point(9, 23);
            this.cboxViewClass.Name = "cboxViewClass";
            this.cboxViewClass.Size = new System.Drawing.Size(100, 27);
            this.cboxViewClass.TabIndex = 10;
            this.cboxViewClass.SelectedIndexChanged += new System.EventHandler(this.cboxViewClass_SelectedIndexChanged);
            // 
            // XD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XD_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息登陆";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDL;
        private TextBox tboxRef;
        private Label label4;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label label3;
        private TextBox tboxName;
        private Label label2;
        private ComboBox cboxClass;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgInfo;
        private ComboBox cboxViewClass;
        private Button btnSC;
        private TextBox tboxScore;
        private Label label5;
        private Button btnTC;
    }
}