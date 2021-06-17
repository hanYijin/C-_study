
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
            this.components = new System.ComponentModel.Container();
            this.btn_dataview = new System.Windows.Forms.Button();
            this.hospitalView = new System.Windows.Forms.DataGridView();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
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
            this.btn_dataview.Click += new System.EventHandler(this.btn_dataview_Click);
            // 
            // hospitalView
            // 
            this.hospitalView.AutoGenerateColumns = false;
            this.hospitalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospitalView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.openDateDataGridViewTextBoxColumn,
            this.totalRoomDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.hospitalView.DataSource = this.hospitalBindingSource;
            this.hospitalView.Location = new System.Drawing.Point(32, 76);
            this.hospitalView.Name = "hospitalView";
            this.hospitalView.RowTemplate.Height = 23;
            this.hospitalView.Size = new System.Drawing.Size(730, 299);
            this.hospitalView.TabIndex = 11;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataSource = typeof(ReadWriteJson0616.Hospital);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "연번";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // openDateDataGridViewTextBoxColumn
            // 
            this.openDateDataGridViewTextBoxColumn.DataPropertyName = "openDate";
            this.openDateDataGridViewTextBoxColumn.HeaderText = "개설일자";
            this.openDateDataGridViewTextBoxColumn.Name = "openDateDataGridViewTextBoxColumn";
            // 
            // totalRoomDataGridViewTextBoxColumn
            // 
            this.totalRoomDataGridViewTextBoxColumn.DataPropertyName = "totalRoom";
            this.totalRoomDataGridViewTextBoxColumn.HeaderText = "병상수 계";
            this.totalRoomDataGridViewTextBoxColumn.Name = "totalRoomDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "소재지";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "의료기관명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "종별";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hospitalView);
            this.Controls.Add(this.btn_dataview);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.hospitalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dataview;
        private System.Windows.Forms.DataGridView hospitalView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
    }
}