namespace _205070011_金世赫
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxXM = new System.Windows.Forms.TextBox();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnTJ = new System.Windows.Forms.Button();
            this.lboxTodo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tboxXM);
            this.panel1.Controls.Add(this.btnSC);
            this.panel1.Controls.Add(this.btnTJ);
            this.panel1.Controls.Add(this.lboxTodo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 274);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "今天的ToDoList";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxXM
            // 
            this.tboxXM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tboxXM.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxXM.Location = new System.Drawing.Point(211, 100);
            this.tboxXM.Name = "tboxXM";
            this.tboxXM.Size = new System.Drawing.Size(144, 25);
            this.tboxXM.TabIndex = 6;
            this.tboxXM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxXM_KeyDown);
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSC.Location = new System.Drawing.Point(286, 129);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(69, 27);
            this.btnSC.TabIndex = 5;
            this.btnSC.Text = "删  除";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTJ
            // 
            this.btnTJ.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTJ.Location = new System.Drawing.Point(211, 129);
            this.btnTJ.Name = "btnTJ";
            this.btnTJ.Size = new System.Drawing.Size(69, 27);
            this.btnTJ.TabIndex = 4;
            this.btnTJ.Text = "添加羡慕";
            this.btnTJ.UseVisualStyleBackColor = true;
            this.btnTJ.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // lboxTodo
            // 
            this.lboxTodo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lboxTodo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxTodo.FormattingEnabled = true;
            this.lboxTodo.ItemHeight = 19;
            this.lboxTodo.Location = new System.Drawing.Point(16, 100);
            this.lboxTodo.Name = "lboxTodo";
            this.lboxTodo.Size = new System.Drawing.Size(186, 156);
            this.lboxTodo.TabIndex = 3;
            this.lboxTodo.SelectedIndexChanged += new System.EventHandler(this.lboxTodo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = " 您好( )！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "现在时间是 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(141, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.学生登陆ToolStripMenuItem});
            this.功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("计算器ToolStripMenuItem.Image")));
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.计算器ToolStripMenuItem.Text = "分数计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 学生登陆ToolStripMenuItem
            // 
            this.学生登陆ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("学生登陆ToolStripMenuItem.Image")));
            this.学生登陆ToolStripMenuItem.Name = "学生登陆ToolStripMenuItem";
            this.学生登陆ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.学生登陆ToolStripMenuItem.Text = "学生信息登陆";
            this.学生登陆ToolStripMenuItem.Click += new System.EventHandler(this.学生登陆ToolStripMenuItem_Click);
            // 
            // 系统功能ToolStripMenuItem
            // 
            this.系统功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.推出ToolStripMenuItem,
            this.关于系统ToolStripMenuItem});
            this.系统功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.系统功能ToolStripMenuItem.Name = "系统功能ToolStripMenuItem";
            this.系统功能ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.系统功能ToolStripMenuItem.Text = "系统功能";
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("推出ToolStripMenuItem.Image")));
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.推出ToolStripMenuItem.Text = "退出";
            this.推出ToolStripMenuItem.Click += new System.EventHandler(this.推出ToolStripMenuItem_Click);
            // 
            // 关于系统ToolStripMenuItem
            // 
            this.关于系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于系统ToolStripMenuItem.Image")));
            this.关于系统ToolStripMenuItem.Name = "关于系统ToolStripMenuItem";
            this.关于系统ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于系统ToolStripMenuItem.Text = "关于系统";
            this.关于系统ToolStripMenuItem.Click += new System.EventHandler(this.关于系统ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem,
            this.系统功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem 计算器ToolStripMenuItem;
        private ToolStripMenuItem 学生登陆ToolStripMenuItem;
        private ToolStripMenuItem 系统功能ToolStripMenuItem;
        private ToolStripMenuItem 推出ToolStripMenuItem;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private TextBox tboxXM;
        private Button btnSC;
        private Button btnTJ;
        private ListBox lboxTodo;
        private Label label4;
        private ToolStripMenuItem 关于系统ToolStripMenuItem;
    }
}