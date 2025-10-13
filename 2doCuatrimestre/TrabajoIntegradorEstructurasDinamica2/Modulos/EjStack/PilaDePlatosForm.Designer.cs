namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack
{
    partial class PilaDePlatosForm
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
            btnAdd = new Button();
            btnDelete = new Button();
            lbPlatos = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 35);
            label2.TabIndex = 3;
            label2.Text = "Pila de Platos";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Añadir Plato";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(124, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Eliminar Plato";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbPlatos
            // 
            lbPlatos.FormattingEnabled = true;
            lbPlatos.Location = new Point(12, 108);
            lbPlatos.Name = "lbPlatos";
            lbPlatos.Size = new Size(230, 224);
            lbPlatos.TabIndex = 6;
            // 
            // PilaDePlatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 344);
            Controls.Add(lbPlatos);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Name = "PilaDePlatosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PilaDePlatosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox lbPlatos;
    }
}