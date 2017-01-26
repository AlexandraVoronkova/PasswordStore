namespace StorePassword
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateStore = new System.Windows.Forms.Button();
            this.buttonOpenStore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonCreateStore
            // 
            this.buttonCreateStore.Location = new System.Drawing.Point(21, 21);
            this.buttonCreateStore.Name = "buttonCreateStore";
            this.buttonCreateStore.Size = new System.Drawing.Size(224, 52);
            this.buttonCreateStore.TabIndex = 0;
            this.buttonCreateStore.Text = "Создать новое хранилище";
            this.buttonCreateStore.UseVisualStyleBackColor = true;
            this.buttonCreateStore.Click += new System.EventHandler(this.buttonCreateStore_Click);
            // 
            // buttonOpenStore
            // 
            this.buttonOpenStore.Location = new System.Drawing.Point(21, 92);
            this.buttonOpenStore.Name = "buttonOpenStore";
            this.buttonOpenStore.Size = new System.Drawing.Size(224, 50);
            this.buttonOpenStore.TabIndex = 1;
            this.buttonOpenStore.Text = "Открыть хранилище";
            this.buttonOpenStore.UseVisualStyleBackColor = true;
            this.buttonOpenStore.Click += new System.EventHandler(this.buttonOpenStore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(21, 161);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(224, 26);
            this.textBoxPathFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите пароль:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 227);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(224, 26);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 328);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathFile);
            this.Controls.Add(this.buttonOpenStore);
            this.Controls.Add(this.buttonCreateStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateStore;
        private System.Windows.Forms.Button buttonOpenStore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

