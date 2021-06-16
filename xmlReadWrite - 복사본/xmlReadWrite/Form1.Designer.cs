
namespace xmlReadWrite
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_readXML = new System.Windows.Forms.Button();
            this.button_writeXML = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_hakbeon = new System.Windows.Forms.TextBox();
            this.textBox_hakgwa = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(744, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_readXML
            // 
            this.button_readXML.Location = new System.Drawing.Point(26, 283);
            this.button_readXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_readXML.Name = "button_readXML";
            this.button_readXML.Size = new System.Drawing.Size(86, 29);
            this.button_readXML.TabIndex = 2;
            this.button_readXML.Text = "읽기";
            this.button_readXML.UseVisualStyleBackColor = true;
            this.button_readXML.Click += new System.EventHandler(this.button_readXML_Click);
            // 
            // button_writeXML
            // 
            this.button_writeXML.Location = new System.Drawing.Point(127, 283);
            this.button_writeXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_writeXML.Name = "button_writeXML";
            this.button_writeXML.Size = new System.Drawing.Size(102, 29);
            this.button_writeXML.TabIndex = 3;
            this.button_writeXML.Text = "쓰기(추가)";
            this.button_writeXML.UseVisualStyleBackColor = true;
            this.button_writeXML.Click += new System.EventHandler(this.button_writeXML_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(26, 375);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(114, 25);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(157, 375);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(114, 25);
            this.textBox_age.TabIndex = 5;
            // 
            // textBox_hakbeon
            // 
            this.textBox_hakbeon.Location = new System.Drawing.Point(291, 375);
            this.textBox_hakbeon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_hakbeon.Name = "textBox_hakbeon";
            this.textBox_hakbeon.Size = new System.Drawing.Size(114, 25);
            this.textBox_hakbeon.TabIndex = 6;
            // 
            // textBox_hakgwa
            // 
            this.textBox_hakgwa.Location = new System.Drawing.Point(426, 375);
            this.textBox_hakgwa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_hakgwa.Name = "textBox_hakgwa";
            this.textBox_hakgwa.Size = new System.Drawing.Size(114, 25);
            this.textBox_hakgwa.TabIndex = 7;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBox_gender.Location = new System.Drawing.Point(559, 377);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(138, 23);
            this.comboBox_gender.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "학과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBox_hakgwa);
            this.Controls.Add(this.textBox_hakbeon);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_writeXML);
            this.Controls.Add(this.button_readXML);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_readXML;
        private System.Windows.Forms.Button button_writeXML;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_hakbeon;
        private System.Windows.Forms.TextBox textBox_hakgwa;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

