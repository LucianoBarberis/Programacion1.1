namespace LoginRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            name = new TextBox();
            pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter Medium", 22.2F, FontStyle.Bold);
            label1.Location = new Point(116, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 53);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // name
            // 
            name.Location = new Point(66, 111);
            name.Margin = new Padding(1);
            name.Name = "name";
            name.Size = new Size(223, 30);
            name.TabIndex = 1;
            // 
            // pass
            // 
            pass.Location = new Point(66, 191);
            pass.Margin = new Padding(1);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(223, 30);
            pass.TabIndex = 2;
            pass.UseSystemPasswordChar = true;
            pass.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 163);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 4;
            label3.Text = "Contrasena";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Inter Medium", 7F, FontStyle.Bold);
            linkLabel1.Location = new Point(66, 222);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(66, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(223, 53);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(362, 353);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(label1);
            Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox pass;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button btnLogin;
    }
}
