namespace QuanLyDoanVien
{
    partial class FormErorList
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
            this.errlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // errlistBox
            // 
            this.errlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errlistBox.FormattingEnabled = true;
            this.errlistBox.Location = new System.Drawing.Point(0, 0);
            this.errlistBox.Name = "errlistBox";
            this.errlistBox.Size = new System.Drawing.Size(597, 238);
            this.errlistBox.TabIndex = 1;
            // 
            // FormErorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 238);
            this.Controls.Add(this.errlistBox);
            this.Name = "FormErorList";
            this.Text = "FormErorList";
            this.Load += new System.EventHandler(this.FormErorList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox errlistBox;
    }
}