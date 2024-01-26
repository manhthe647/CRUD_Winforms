namespace de1_TranManhThe_0205266.Views.Tìm_kiếm
{
    partial class TimKiemSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.tknv_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tknv_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM GẦN ĐÚNG SINH VIÊN";
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(657, 35);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(246, 30);
            this.searchInput.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(921, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(118, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // tknv_dataGridView
            // 
            this.tknv_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tknv_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tknv_dataGridView.Location = new System.Drawing.Point(202, 87);
            this.tknv_dataGridView.Name = "tknv_dataGridView";
            this.tknv_dataGridView.RowHeadersWidth = 51;
            this.tknv_dataGridView.RowTemplate.Height = 24;
            this.tknv_dataGridView.Size = new System.Drawing.Size(837, 405);
            this.tknv_dataGridView.TabIndex = 3;
            // 
            // TimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1219, 557);
            this.Controls.Add(this.tknv_dataGridView);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemHocSinh";
            this.Text = "TimKiemHocSinh";
            this.Load += new System.EventHandler(this.TimKiemHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tknv_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView tknv_dataGridView;
    }
}