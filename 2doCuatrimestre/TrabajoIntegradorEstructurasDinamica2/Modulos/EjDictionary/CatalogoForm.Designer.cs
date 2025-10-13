namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjDictionary
{
    partial class CatalogoForm
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
            lbCatalogo = new ListBox();
            inpName = new TextBox();
            inpSku = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSearch = new Button();
            label4 = new Label();
            inpSearch = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(270, 35);
            label2.TabIndex = 6;
            label2.Text = "Catalogo de Productos";
            // 
            // lbCatalogo
            // 
            lbCatalogo.FormattingEnabled = true;
            lbCatalogo.Location = new Point(324, 54);
            lbCatalogo.Name = "lbCatalogo";
            lbCatalogo.Size = new Size(292, 344);
            lbCatalogo.TabIndex = 7;
            // 
            // inpName
            // 
            inpName.Location = new Point(15, 32);
            inpName.Name = "inpName";
            inpName.Size = new Size(260, 27);
            inpName.TabIndex = 8;
            // 
            // inpSku
            // 
            inpSku.Location = new Point(15, 93);
            inpSku.Name = "inpSku";
            inpSku.Size = new Size(260, 27);
            inpSku.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "Codigo SKU";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 45);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Agregar Producto";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(inpName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(inpSku);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 193);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inpSearch);
            panel2.Location = new Point(12, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 136);
            panel2.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(15, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(260, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 1;
            label4.Text = "Barra de busqueda";
            // 
            // inpSearch
            // 
            inpSearch.Location = new Point(15, 35);
            inpSearch.Name = "inpSearch";
            inpSearch.Size = new Size(260, 27);
            inpSearch.TabIndex = 0;
            // 
            // CatalogoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 416);
            Controls.Add(panel2);
            Controls.Add(lbCatalogo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "CatalogoForm";
            Text = "CatalogoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lbCatalogo;
        private TextBox inpName;
        private TextBox inpSku;
        private Label label1;
        private Label label3;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private TextBox inpSearch;
        private Button btnSearch;
    }
}