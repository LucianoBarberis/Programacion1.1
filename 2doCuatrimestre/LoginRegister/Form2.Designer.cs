namespace LoginRegister
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter Medium", 22.2F, FontStyle.Bold);
            label1.Location = new Point(94, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 53);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 30);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            label2.Location = new Point(63, 88);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 163);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(63, 248);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(223, 51);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(362, 353);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btnRegister;
    }
}