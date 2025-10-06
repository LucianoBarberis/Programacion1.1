namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjList
{
    partial class InventarioForm
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
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            inpSearch = new TextBox();
            btnSearch = new Button();
            lbItems = new ListBox();
            inpAdd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inpCantidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(126, 35);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 37);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(155, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // inpSearch
            // 
            inpSearch.Location = new Point(17, 229);
            inpSearch.Name = "inpSearch";
            inpSearch.Size = new Size(181, 30);
            inpSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(204, 229);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbItems
            // 
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 23;
            lbItems.Location = new Point(17, 306);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(267, 165);
            lbItems.TabIndex = 5;
            // 
            // inpAdd
            // 
            inpAdd.Location = new Point(14, 85);
            inpAdd.Name = "inpAdd";
            inpAdd.Size = new Size(269, 30);
            inpAdd.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(17, 284);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 7;
            label2.Text = "Items Actuales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(14, 65);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 8;
            label3.Text = "Nombre del Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(14, 121);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // inpCantidad
            // 
            inpCantidad.Location = new Point(14, 141);
            inpCantidad.Name = "inpCantidad";
            inpCantidad.Size = new Size(270, 30);
            inpCantidad.TabIndex = 9;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 491);
            Controls.Add(label4);
            Controls.Add(inpCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inpAdd);
            Controls.Add(lbItems);
            Controls.Add(btnSearch);
            Controls.Add(inpSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventarioForm";
            Text = "InventarioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox inpSearch;
        private Button btnSearch;
        private ListBox lbItems;
        private TextBox inpAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inpCantidad;
    }
}