namespace C_ProjeDeneme1
{
    partial class FormAdminGiris
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            bGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(29, 58);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(92, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(29, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Şifreyi Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 100);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(137, 27);
            textBox2.TabIndex = 4;
            // 
            // bGiris
            // 
            bGiris.BackColor = Color.Yellow;
            bGiris.Location = new Point(184, 145);
            bGiris.Name = "bGiris";
            bGiris.Size = new Size(112, 49);
            bGiris.TabIndex = 5;
            bGiris.Text = "Giriş Yap";
            bGiris.UseVisualStyleBackColor = false;
            bGiris.Click += bGiris_Click;
            // 
            // FormAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(358, 245);
            Controls.Add(bGiris);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdminGiris";
            FormClosing += FormAdminGiris_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button bGiris;
    }
}