namespace CRUD
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
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnDetail = new Button();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbStock = new TextBox();
            label4 = new Label();
            tbPrice = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Inter Medium", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(325, 53);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Stock";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Inter", 14F);
            btnAdd.Location = new Point(13, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(232, 66);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Inter", 14F);
            btnDelete.Location = new Point(13, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(232, 66);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Inter", 14F);
            btnEdit.Location = new Point(277, 329);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(232, 65);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Inter", 14F);
            btnDetail.Location = new Point(277, 410);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(232, 66);
            btnDetail.TabIndex = 5;
            btnDetail.Text = "Ver Detalle";
            btnDetail.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Font = new Font("Inter", 13F);
            tbName.Location = new Point(12, 110);
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 34);
            tbName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F);
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 9;
            label3.Text = "Stock";
            // 
            // tbStock
            // 
            tbStock.Font = new Font("Inter", 13F);
            tbStock.Location = new Point(12, 191);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(233, 34);
            tbStock.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 9F);
            label4.Location = new Point(277, 85);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 11;
            label4.Text = "Precio";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Inter", 13F);
            tbPrice.Location = new Point(277, 110);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(232, 34);
            tbPrice.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(538, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(453, 446);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1014, 488);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(tbStock);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(btnDetail);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Font = new Font("Inter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion De Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnDetail;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private TextBox tbStock;
        private Label label4;
        private TextBox tbPrice;
        private ListBox listBox1;
    }
}
