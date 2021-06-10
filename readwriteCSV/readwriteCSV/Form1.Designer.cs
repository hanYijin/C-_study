
namespace readwriteCSV
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_readcsv = new System.Windows.Forms.Button();
            this.button_writeCSV = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_hakbeon = new System.Windows.Forms.TextBox();
            this.textBox_hakgwa = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakbeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakgwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_contents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_readcsv
            // 
            this.button_readcsv.Location = new System.Drawing.Point(25, 35);
            this.button_readcsv.Name = "button_readcsv";
            this.button_readcsv.Size = new System.Drawing.Size(140, 39);
            this.button_readcsv.TabIndex = 0;
            this.button_readcsv.Text = "csv읽기";
            this.button_readcsv.UseVisualStyleBackColor = true;
            this.button_readcsv.Click += new System.EventHandler(this.button_readcsv_Click);
            // 
            // button_writeCSV
            // 
            this.button_writeCSV.Location = new System.Drawing.Point(191, 36);
            this.button_writeCSV.Name = "button_writeCSV";
            this.button_writeCSV.Size = new System.Drawing.Size(137, 37);
            this.button_writeCSV.TabIndex = 1;
            this.button_writeCSV.Text = "csv쓰기";
            this.button_writeCSV.UseVisualStyleBackColor = true;
            this.button_writeCSV.Click += new System.EventHandler(this.button_writeCSV_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(390, 44);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(171, 25);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(390, 89);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(171, 25);
            this.textBox_age.TabIndex = 3;
            // 
            // textBox_hakbeon
            // 
            this.textBox_hakbeon.Location = new System.Drawing.Point(390, 130);
            this.textBox_hakbeon.Name = "textBox_hakbeon";
            this.textBox_hakbeon.Size = new System.Drawing.Size(171, 25);
            this.textBox_hakbeon.TabIndex = 4;
            // 
            // textBox_hakgwa
            // 
            this.textBox_hakgwa.Location = new System.Drawing.Point(617, 44);
            this.textBox_hakgwa.Name = "textBox_hakgwa";
            this.textBox_hakgwa.Size = new System.Drawing.Size(171, 25);
            this.textBox_hakgwa.TabIndex = 5;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(617, 89);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(171, 25);
            this.textBox_gender.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "학과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "성별";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakbeonDataGridViewTextBoxColumn,
            this.hakgwaDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(25, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(749, 210);
            this.dataGridView1.TabIndex = 12;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // hakbeonDataGridViewTextBoxColumn
            // 
            this.hakbeonDataGridViewTextBoxColumn.DataPropertyName = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.HeaderText = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hakbeonDataGridViewTextBoxColumn.Name = "hakbeonDataGridViewTextBoxColumn";
            this.hakbeonDataGridViewTextBoxColumn.ReadOnly = true;
            this.hakbeonDataGridViewTextBoxColumn.Width = 125;
            // 
            // hakgwaDataGridViewTextBoxColumn
            // 
            this.hakgwaDataGridViewTextBoxColumn.DataPropertyName = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.HeaderText = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hakgwaDataGridViewTextBoxColumn.Name = "hakgwaDataGridViewTextBoxColumn";
            this.hakgwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.hakgwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(22, 115);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(15, 15);
            this.label_contents.TabIndex = 13;
            this.label_contents.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.textBox_hakgwa);
            this.Controls.Add(this.textBox_hakbeon);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_writeCSV);
            this.Controls.Add(this.button_readcsv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_readcsv;
        private System.Windows.Forms.Button button_writeCSV;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_hakbeon;
        private System.Windows.Forms.TextBox textBox_hakgwa;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_contents;
    }
}

