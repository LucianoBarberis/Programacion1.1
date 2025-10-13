namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack
{
    partial class HistorialForm
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
            label2 = new Label();
            inpURL = new TextBox();
            btnNav = new Button();
            btnBack = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            lblActual = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(276, 35);
            label2.TabIndex = 3;
            label2.Text = "Historial de navegacion";
            // 
            // inpURL
            // 
            inpURL.Location = new Point(12, 60);
            inpURL.Name = "inpURL";
            inpURL.PlaceholderText = "https://ejemplo.com";
            inpURL.Size = new Size(278, 27);
            inpURL.TabIndex = 4;
            // 
            // btnNav
            // 
            btnNav.Location = new Point(296, 60);
            btnNav.Name = "btnNav";
            btnNav.Size = new Size(89, 27);
            btnNav.TabIndex = 5;
            btnNav.Text = "Navegar";
            btnNav.UseVisualStyleBackColor = true;
            btnNav.Click += btnNav_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(296, 93);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 27);
            btnBack.TabIndex = 6;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(373, 264);
            listBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 136);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 8;
            label1.Text = "Historial de Navegacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 7);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 9;
            label3.Text = "Web Actual:";
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Font = new Font("Segoe UI", 11F);
            lblActual.Location = new Point(81, 27);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(58, 25);
            lblActual.TabIndex = 10;
            lblActual.Text = "Inicio";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblActual);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 63);
            panel1.TabIndex = 11;
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 508);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnBack);
            Controls.Add(btnNav);
            Controls.Add(inpURL);
            Controls.Add(label2);
            Name = "HistorialForm";
            Text = "HistorialForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox inpURL;
        private Button btnNav;
        private Button btnBack;
        private ListBox listBox1;
        private Label label1;
        private Label label3;
        private Label lblActual;
        private Panel panel1;
    }
}