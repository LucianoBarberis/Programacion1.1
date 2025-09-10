namespace CRUD
{
    partial class EditForm
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
            label4 = new Label();
            tbPrice = new TextBox();
            label3 = new Label();
            tbStock = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Inter Medium", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 53);
            label1.TabIndex = 1;
            label1.Text = "Editar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 9F);
            label4.Location = new Point(12, 255);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 17;
            label4.Text = "Precio";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Inter", 13F);
            tbPrice.Location = new Point(12, 280);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(349, 34);
            tbPrice.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 15;
            label3.Text = "Stock";
            // 
            // tbStock
            // 
            tbStock.Font = new Font("Inter", 13F);
            tbStock.Location = new Point(12, 194);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(350, 34);
            tbStock.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // tbName
            // 
            tbName.Font = new Font("Inter", 13F);
            tbName.Location = new Point(12, 113);
            tbName.Name = "tbName";
            tbName.Size = new Size(349, 34);
            tbName.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Inter", 14F);
            btnSave.Location = new Point(12, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(350, 61);
            btnSave.TabIndex = 18;
            btnSave.Text = "Guardar y Salir";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 420);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(tbStock);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox tbPrice;
        private Label label3;
        private TextBox tbStock;
        private Label label2;
        private TextBox tbName;
        private Button btnSave;
    }
}