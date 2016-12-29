namespace StorePassword
{
    partial class FormGenPass
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonGenPass = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonEsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(65, 130);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 69);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonGenPass
            // 
            this.buttonGenPass.Location = new System.Drawing.Point(65, 196);
            this.buttonGenPass.Name = "buttonGenPass";
            this.buttonGenPass.Size = new System.Drawing.Size(167, 43);
            this.buttonGenPass.TabIndex = 2;
            this.buttonGenPass.Text = "Сгенерировать";
            this.buttonGenPass.UseVisualStyleBackColor = true;
            this.buttonGenPass.Click += new System.EventHandler(this.buttonGenPass_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(51, 262);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 30);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonEsc
            // 
            this.buttonEsc.Location = new System.Drawing.Point(186, 262);
            this.buttonEsc.Name = "buttonEsc";
            this.buttonEsc.Size = new System.Drawing.Size(91, 30);
            this.buttonEsc.TabIndex = 4;
            this.buttonEsc.Text = "Отмена";
            this.buttonEsc.UseVisualStyleBackColor = true;
            this.buttonEsc.Click += new System.EventHandler(this.buttonEsc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина пароля";
            // 
            // FormGenPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEsc);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonGenPass);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormGenPass";
            this.Text = "GenPass";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonGenPass;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonEsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}