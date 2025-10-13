namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList
{
    partial class EditorDeTextoForm
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
            inpText = new TextBox();
            btnUndo = new Button();
            btnRedo = new Button();
            lblTexto = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(192, 35);
            label2.TabIndex = 19;
            label2.Text = "Editor de Textos";
            // 
            // inpText
            // 
            inpText.Font = new Font("Segoe UI", 10F);
            inpText.Location = new Point(12, 62);
            inpText.Name = "inpText";
            inpText.Size = new Size(434, 30);
            inpText.TabIndex = 20;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(416, 15);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(60, 29);
            btnUndo.TabIndex = 21;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(482, 15);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(60, 29);
            btnRedo.TabIndex = 22;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // lblTexto
            // 
            lblTexto.Location = new Point(12, 109);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(530, 424);
            lblTexto.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(452, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Enter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // EditorDeTextoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 342);
            Controls.Add(btnAdd);
            Controls.Add(lblTexto);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(inpText);
            Controls.Add(label2);
            Name = "EditorDeTextoForm";
            Text = "EditorDeTextoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox inpText;
        private Button btnUndo;
        private Button btnRedo;
        private Label lblTexto;
        private Button btnAdd;
    }
}