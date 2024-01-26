namespace de1_TranManhThe_0205266.Views
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.alertLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlhsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qllqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkhsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tklqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taikhoanInput = new System.Windows.Forms.TextBox();
            this.matkhauInput = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.MistyRose;
            this.mainPanel.Controls.Add(this.alertLabel);
            this.mainPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainPanel.Location = new System.Drawing.Point(-1, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1192, 559);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Visible = false;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.Location = new System.Drawing.Point(450, 224);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(267, 23);
            this.alertLabel.TabIndex = 0;
            this.alertLabel.Text = "Điều hướng panel bằng menu";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1191, 30);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlToolStripMenuItem,
            this.tkToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Visible = false;
            // 
            // qlToolStripMenuItem
            // 
            this.qlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlhsToolStripMenuItem,
            this.qllqlToolStripMenuItem});
            this.qlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qlToolStripMenuItem.Image")));
            this.qlToolStripMenuItem.Name = "qlToolStripMenuItem";
            this.qlToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.qlToolStripMenuItem.Text = "Quản lý";
            // 
            // qlhsToolStripMenuItem
            // 
            this.qlhsToolStripMenuItem.Name = "qlhsToolStripMenuItem";
            this.qlhsToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.qlhsToolStripMenuItem.Text = "Quản lý học sinh";
            this.qlhsToolStripMenuItem.Click += new System.EventHandler(this.qlhsToolStripMenuItem_Click);
            // 
            // qllqlToolStripMenuItem
            // 
            this.qllqlToolStripMenuItem.Name = "qllqlToolStripMenuItem";
            this.qllqlToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.qllqlToolStripMenuItem.Text = "Quản lý lớp quản lý";
            this.qllqlToolStripMenuItem.Click += new System.EventHandler(this.qllqlToolStripMenuItem_Click);
            // 
            // tkToolStripMenuItem
            // 
            this.tkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tkhsToolStripMenuItem,
            this.tklqlToolStripMenuItem});
            this.tkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tkToolStripMenuItem.Image")));
            this.tkToolStripMenuItem.Name = "tkToolStripMenuItem";
            this.tkToolStripMenuItem.Size = new System.Drawing.Size(163, 28);
            this.tkToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tkhsToolStripMenuItem
            // 
            this.tkhsToolStripMenuItem.Name = "tkhsToolStripMenuItem";
            this.tkhsToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.tkhsToolStripMenuItem.Text = "Tìm kiếm học sinh";
            this.tkhsToolStripMenuItem.Click += new System.EventHandler(this.tkhsToolStripMenuItem_Click);
            // 
            // tklqlToolStripMenuItem
            // 
            this.tklqlToolStripMenuItem.Name = "tklqlToolStripMenuItem";
            this.tklqlToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.tklqlToolStripMenuItem.Text = "Tìm kiếm lớp quản lý";
            this.tklqlToolStripMenuItem.Click += new System.EventHandler(this.tklqlToolStripMenuItem_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(454, 319);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(365, 54);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // taikhoanInput
            // 
            this.taikhoanInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoanInput.Location = new System.Drawing.Point(571, 195);
            this.taikhoanInput.Name = "taikhoanInput";
            this.taikhoanInput.Size = new System.Drawing.Size(248, 30);
            this.taikhoanInput.TabIndex = 8;
            // 
            // matkhauInput
            // 
            this.matkhauInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhauInput.Location = new System.Drawing.Point(571, 248);
            this.matkhauInput.Name = "matkhauInput";
            this.matkhauInput.PasswordChar = '*';
            this.matkhauInput.Size = new System.Drawing.Size(248, 30);
            this.matkhauInput.TabIndex = 9;
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.Controls.Add(this.matkhauInput);
            this.loginPanel.Controls.Add(this.taikhoanInput);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Location = new System.Drawing.Point(-1, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1192, 586);
            this.loginPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1191, 586);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranManhThe_0205266";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlhsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qllqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tkhsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tklqlToolStripMenuItem;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox matkhauInput;
        private System.Windows.Forms.TextBox taikhoanInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label alertLabel;
    }
}

