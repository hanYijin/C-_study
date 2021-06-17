
namespace ReadWriteJson0616
{
    partial class Form3
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
            this.btn_dataview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dataview
            // 
            this.btn_dataview.Location = new System.Drawing.Point(32, 29);
            this.btn_dataview.Name = "btn_dataview";
            this.btn_dataview.Size = new System.Drawing.Size(105, 23);
            this.btn_dataview.TabIndex = 10;
            this.btn_dataview.Text = "공공데이터 보기";
            this.btn_dataview.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dataview);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dataview;
    }
}