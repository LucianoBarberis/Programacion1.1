namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjDictionary
{
    partial class DirectorioForm
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
            label1 = new Label();
            InpSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            lbContactos = new ListBox();
            inpTel = new TextBox();
            inpName = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 7;
            label2.Text = "Directorio de Contactos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 140);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 21;
            label1.Text = "Buscar Contacto";
            // 
            // InpSearch
            // 
            InpSearch.Location = new Point(11, 163);
            InpSearch.Name = "InpSearch";
            InpSearch.Size = new Size(224, 27);
            InpSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(241, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Buscar...";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(324, 38);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Agregar Contacto";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // lbContactos
            // 
            lbContactos.FormattingEnabled = true;
            lbContactos.Location = new Point(12, 203);
            lbContactos.Name = "lbContactos";
            lbContactos.Size = new Size(324, 324);
            lbContactos.TabIndex = 17;
            // 
            // inpTel
            // 
            inpTel.Location = new Point(175, 56);
            inpTel.Name = "inpTel";
            inpTel.PlaceholderText = "Telefono...";
            inpTel.Size = new Size(159, 27);
            inpTel.TabIndex = 16;
            // 
            // inpName
            // 
            inpName.Location = new Point(11, 56);
            inpName.Name = "inpName";
            inpName.PlaceholderText = "Nombre...";
            inpName.Size = new Size(158, 27);
            inpName.TabIndex = 15;
            // 
            // DirectorioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 540);
            Controls.Add(label1);
            Controls.Add(InpSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lbContactos);
            Controls.Add(inpTel);
            Controls.Add(inpName);
            Controls.Add(label2);
            Name = "DirectorioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DirectorioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox InpSearch;
        private Button btnSearch;
        private Button btnAdd;
        private ListBox lbContactos;
        private TextBox inpTel;
        private TextBox inpName;
    }
}