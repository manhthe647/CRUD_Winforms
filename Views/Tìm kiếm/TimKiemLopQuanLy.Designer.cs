namespace de1_TranManhThe_0205266.Views.Tìm_kiếm
{
    partial class TimKiemLopQuanLy
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
            this.tklql_dataGridView = new System.Windows.Forms.DataGridView();
            this.searchLqlBtn = new System.Windows.Forms.Button();
            this.tklqlSearchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tklql_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tklql_dataGridView
            // 
            this.tklql_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tklql_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tklql_dataGridView.Location = new System.Drawing.Point(248, 89);
            this.tklql_dataGridView.Name = "tklql_dataGridView";
            this.tklql_dataGridView.RowHeadersWidth = 51;
            this.tklql_dataGridView.RowTemplate.Height = 24;
            this.tklql_dataGridView.Size = new System.Drawing.Size(783, 398);
            this.tklql_dataGridView.TabIndex = 7;
            // 
            // searchLqlBtn
            // 
            this.searchLqlBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLqlBtn.Location = new System.Drawing.Point(913, 29);
            this.searchLqlBtn.Name = "searchLqlBtn";
            this.searchLqlBtn.Size = new System.Drawing.Size(118, 35);
            this.searchLqlBtn.TabIndex = 6;
            this.searchLqlBtn.Text = "Tìm kiếm";
            this.searchLqlBtn.UseVisualStyleBackColor = true;
            this.searchLqlBtn.Click += new System.EventHandler(this.searchLqlBtn_Click);
            // 
            // tklqlSearchInput
            // 
            this.tklqlSearchInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tklqlSearchInput.Location = new System.Drawing.Point(648, 32);
            this.tklqlSearchInput.Name = "tklqlSearchInput";
            this.tklqlSearchInput.Size = new System.Drawing.Size(246, 30);
            this.tklqlSearchInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM CHÍNH XÁC LQL";
            // 
            // TimKiemLopQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1237, 548);
            this.Controls.Add(this.tklql_dataGridView);
            this.Controls.Add(this.searchLqlBtn);
            this.Controls.Add(this.tklqlSearchInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemLopQuanLy";
            this.Text = "TimKiemLopQuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.tklql_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tklql_dataGridView;
        private System.Windows.Forms.Button searchLqlBtn;
        private System.Windows.Forms.TextBox tklqlSearchInput;
        private System.Windows.Forms.Label label1;
    }
}