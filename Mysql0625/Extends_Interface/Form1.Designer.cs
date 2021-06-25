
namespace Extends_Interface
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
            this.button_animal = new System.Windows.Forms.Button();
            this.button_cat = new System.Windows.Forms.Button();
            this.button_dog = new System.Windows.Forms.Button();
            this.button_animals = new System.Windows.Forms.Button();
            this.button_Exinterface = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_animal
            // 
            this.button_animal.Location = new System.Drawing.Point(30, 24);
            this.button_animal.Name = "button_animal";
            this.button_animal.Size = new System.Drawing.Size(125, 37);
            this.button_animal.TabIndex = 0;
            this.button_animal.Text = "animal";
            this.button_animal.UseVisualStyleBackColor = true;
            this.button_animal.Click += new System.EventHandler(this.button_animal_Click);
            // 
            // button_cat
            // 
            this.button_cat.Location = new System.Drawing.Point(173, 24);
            this.button_cat.Name = "button_cat";
            this.button_cat.Size = new System.Drawing.Size(125, 37);
            this.button_cat.TabIndex = 1;
            this.button_cat.Text = "cat";
            this.button_cat.UseVisualStyleBackColor = true;
            this.button_cat.Click += new System.EventHandler(this.button_cat_Click);
            // 
            // button_dog
            // 
            this.button_dog.Location = new System.Drawing.Point(315, 24);
            this.button_dog.Name = "button_dog";
            this.button_dog.Size = new System.Drawing.Size(125, 37);
            this.button_dog.TabIndex = 2;
            this.button_dog.Text = "dog";
            this.button_dog.UseVisualStyleBackColor = true;
            this.button_dog.Click += new System.EventHandler(this.button_dog_Click);
            // 
            // button_animals
            // 
            this.button_animals.Location = new System.Drawing.Point(30, 221);
            this.button_animals.Name = "button_animals";
            this.button_animals.Size = new System.Drawing.Size(410, 37);
            this.button_animals.TabIndex = 3;
            this.button_animals.Text = "animals";
            this.button_animals.UseVisualStyleBackColor = true;
            this.button_animals.Click += new System.EventHandler(this.button_animals_Click);
            // 
            // button_Exinterface
            // 
            this.button_Exinterface.Location = new System.Drawing.Point(30, 178);
            this.button_Exinterface.Name = "button_Exinterface";
            this.button_Exinterface.Size = new System.Drawing.Size(410, 37);
            this.button_Exinterface.TabIndex = 4;
            this.button_Exinterface.Text = "interface EX";
            this.button_Exinterface.UseVisualStyleBackColor = true;
            this.button_Exinterface.Click += new System.EventHandler(this.button_Exinterface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Exinterface);
            this.Controls.Add(this.button_animals);
            this.Controls.Add(this.button_dog);
            this.Controls.Add(this.button_cat);
            this.Controls.Add(this.button_animal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_animal;
        private System.Windows.Forms.Button button_cat;
        private System.Windows.Forms.Button button_dog;
        private System.Windows.Forms.Button button_animals;
        private System.Windows.Forms.Button button_Exinterface;
    }
}

