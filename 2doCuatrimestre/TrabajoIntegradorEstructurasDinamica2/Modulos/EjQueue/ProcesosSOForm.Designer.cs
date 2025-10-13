namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue
{
    partial class ProcesosSOForm
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
            button1 = new Button();
            button2 = new Button();
            lbProcesos = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(195, 35);
            label2.TabIndex = 5;
            label2.Text = "Procesos del SO\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 6;
            button1.Text = "Añadir Proceso";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 57);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 7;
            button2.Text = "Ejecutar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbProcesos
            // 
            lbProcesos.FormattingEnabled = true;
            lbProcesos.Location = new Point(12, 95);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(278, 224);
            lbProcesos.TabIndex = 8;
            // 
            // ProcesosSOForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 332);
            Controls.Add(lbProcesos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "ProcesosSOForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProcesosSOForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Button button2;
        private ListBox lbProcesos;
    }
}