
namespace projectTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.trackBarDisplayCounts = new System.Windows.Forms.TrackBar();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDisplayCounts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(85, 22);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(191, 21);
            this.textBox_keyword.TabIndex = 1;
            // 
            // listViewResults
            // 
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(64, 114);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(609, 273);
            this.listViewResults.TabIndex = 2;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // trackBarDisplayCounts
            // 
            this.trackBarDisplayCounts.Location = new System.Drawing.Point(444, 22);
            this.trackBarDisplayCounts.Name = "trackBarDisplayCounts";
            this.trackBarDisplayCounts.Size = new System.Drawing.Size(132, 45);
            this.trackBarDisplayCounts.TabIndex = 3;
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Location = new System.Drawing.Point(602, 23);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(71, 16);
            this.radioButtonCount.TabIndex = 4;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "판매량순";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(602, 51);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(71, 16);
            this.radioButtonSim.TabIndex = 5;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "유사도순";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.radioButtonCount);
            this.Controls.Add(this.trackBarDisplayCounts);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.textBox_keyword);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDisplayCounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.TrackBar trackBarDisplayCounts;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.RadioButton radioButtonSim;
    }
}

