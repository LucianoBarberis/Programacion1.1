namespace Practica001
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
            lblTitle = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 41);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Menu Editar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 27);
            textBox1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(97, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 44);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar y cerrar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 181);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Edit Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBox1;
        private Button btnSave;
    }
}