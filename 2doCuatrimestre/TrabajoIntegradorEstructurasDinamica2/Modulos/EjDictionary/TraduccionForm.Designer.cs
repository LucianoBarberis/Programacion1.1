namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjDictionary
{
    partial class TraduccionForm
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
            lbTraducciones = new ListBox();
            inpIngles = new TextBox();
            inpEspañol = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 35);
            label2.TabIndex = 7;
            label2.Text = "Traducciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 136);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 28;
            label1.Text = "Buscar";
            // 
            // InpSearch
            // 
            InpSearch.Location = new Point(11, 159);
            InpSearch.Name = "InpSearch";
            InpSearch.Size = new Size(224, 27);
            InpSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(241, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Buscar...";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(324, 38);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Agregar Traduccion";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbTraducciones
            // 
            lbTraducciones.FormattingEnabled = true;
            lbTraducciones.Location = new Point(12, 199);
            lbTraducciones.Name = "lbTraducciones";
            lbTraducciones.Size = new Size(324, 324);
            lbTraducciones.TabIndex = 24;
            // 
            // inpIngles
            // 
            inpIngles.Location = new Point(176, 52);
            inpIngles.Name = "inpIngles";
            inpIngles.PlaceholderText = "Ingles...";
            inpIngles.Size = new Size(159, 27);
            inpIngles.TabIndex = 23;
            // 
            // inpEspañol
            // 
            inpEspañol.Location = new Point(11, 52);
            inpEspañol.Name = "inpEspañol";
            inpEspañol.PlaceholderText = "Español...";
            inpEspañol.Size = new Size(158, 27);
            inpEspañol.TabIndex = 22;
            // 
            // TraduccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 535);
            Controls.Add(label1);
            Controls.Add(InpSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lbTraducciones);
            Controls.Add(inpIngles);
            Controls.Add(inpEspañol);
            Controls.Add(label2);
            Name = "TraduccionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TraduccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox InpSearch;
        private Button btnSearch;
        private Button btnAdd;
        private ListBox lbTraducciones;
        private TextBox inpIngles;
        private TextBox inpEspañol;
    }
}