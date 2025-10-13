namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjList
{
    partial class CalificacionesForm
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
            inpAdd = new TextBox();
            lbCalifi = new ListBox();
            btnDeleteMinor = new Button();
            btnDeleteHigh = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(305, 35);
            label2.TabIndex = 2;
            label2.Text = "Calificaciones de Alumnos";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(123, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 27);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Agregar Calificacion";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // inpAdd
            // 
            inpAdd.Location = new Point(12, 57);
            inpAdd.MaxLength = 5;
            inpAdd.Name = "inpAdd";
            inpAdd.PlaceholderText = "00,00";
            inpAdd.Size = new Size(105, 27);
            inpAdd.TabIndex = 3;
            // 
            // lbCalifi
            // 
            lbCalifi.FormattingEnabled = true;
            lbCalifi.Location = new Point(12, 164);
            lbCalifi.Name = "lbCalifi";
            lbCalifi.Size = new Size(305, 264);
            lbCalifi.TabIndex = 13;
            // 
            // btnDeleteMinor
            // 
            btnDeleteMinor.Location = new Point(166, 90);
            btnDeleteMinor.Name = "btnDeleteMinor";
            btnDeleteMinor.Size = new Size(151, 37);
            btnDeleteMinor.TabIndex = 15;
            btnDeleteMinor.Text = "Eliminar Menor";
            btnDeleteMinor.UseVisualStyleBackColor = true;
            btnDeleteMinor.Click += btnDeleteMinor_Click;
            // 
            // btnDeleteHigh
            // 
            btnDeleteHigh.Location = new Point(12, 90);
            btnDeleteHigh.Name = "btnDeleteHigh";
            btnDeleteHigh.Size = new Size(148, 37);
            btnDeleteHigh.TabIndex = 14;
            btnDeleteHigh.Text = "Eliminar Mayor";
            btnDeleteHigh.UseVisualStyleBackColor = true;
            btnDeleteHigh.Click += btnDeleteHigh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(137, 19);
            label4.TabIndex = 16;
            label4.Text = "Lista de calificaciones";
            // 
            // CalificacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 440);
            Controls.Add(label4);
            Controls.Add(btnDeleteMinor);
            Controls.Add(btnDeleteHigh);
            Controls.Add(lbCalifi);
            Controls.Add(btnAdd);
            Controls.Add(inpAdd);
            Controls.Add(label2);
            Name = "CalificacionesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CalidicacionesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnAdd;
        private TextBox inpAdd;
        private ListBox lbCalifi;
        private Button btnDeleteMinor;
        private Button btnDeleteHigh;
        private Label label4;
    }
}