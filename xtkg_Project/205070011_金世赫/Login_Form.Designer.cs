namespace _205070011_金世赫
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnCZ = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户账号 ：";
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(169, 115);
            this.tboxID.Name = "tboxID";
            this.tboxID.PlaceholderText = "请输入用户账号";
            this.tboxID.Size = new System.Drawing.Size(203, 23);
            this.tboxID.TabIndex = 1;
            // 
            // tboxPW
            // 
            this.tboxPW.Location = new System.Drawing.Point(169, 157);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.PlaceholderText = "请输入用户密码";
            this.tboxPW.Size = new System.Drawing.Size(203, 23);
            this.tboxPW.TabIndex = 3;
            this.tboxPW.UseSystemPasswordChar = true;
            this.tboxPW.TextChanged += new System.EventHandler(this.tboxPW_TextChanged);
            this.tboxPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxPW_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户密码 ：";
            // 
            // btnQR
            // 
            this.btnQR.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQR.Location = new System.Drawing.Point(87, 205);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(85, 30);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "确  认";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnCZ
            // 
            this.btnCZ.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCZ.Location = new System.Drawing.Point(187, 205);
            this.btnCZ.Name = "btnCZ";
            this.btnCZ.Size = new System.Drawing.Size(85, 30);
            this.btnCZ.TabIndex = 5;
            this.btnCZ.Text = "重  置";
            this.btnCZ.UseVisualStyleBackColor = true;
            this.btnCZ.Click += new System.EventHandler(this.btnCZ_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQ.Location = new System.Drawing.Point(285, 205);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(85, 30);
            this.btnQ.TabIndex = 6;
            this.btnQ.Text = "推  出";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "SYSTEM VERSION 1.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 44);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(274, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "学生成绩管理系统";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnCZ);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.tboxPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tboxID;
        private TextBox tboxPW;
        private Label label2;
        private Button btnQR;
        private Button btnCZ;
        private Button btnQ;
        private Label label3;
        private Label label4;
    }
}