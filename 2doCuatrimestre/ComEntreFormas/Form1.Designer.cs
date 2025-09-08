namespace ComEntreFormas
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
            selectMetodo = new ComboBox();
            textBox1 = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // selectMetodo
            // 
            selectMetodo.FormattingEnabled = true;
            selectMetodo.Items.AddRange(new object[] { "Propiedad", "POO" });
            selectMetodo.Location = new Point(90, 66);
            selectMetodo.Name = "selectMetodo";
            selectMetodo.Size = new Size(210, 28);
            selectMetodo.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(90, 115);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(210, 55);
            btnSend.TabIndex = 2;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 201);
            Controls.Add(btnSend);
            Controls.Add(textBox1);
            Controls.Add(selectMetodo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectMetodo;
        private TextBox textBox1;
        private Button btnSend;
    }
}
