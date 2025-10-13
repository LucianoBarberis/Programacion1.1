namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList
{
    partial class ListaDeEsperaForm
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
            lbListaDeEspera = new ListBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            inpClientName = new TextBox();
            btnDelete = new Button();
            btnSitClient = new Button();
            SuspendLayout();
            // 
            // lbListaDeEspera
            // 
            lbListaDeEspera.Font = new Font("Segoe UI", 9F);
            lbListaDeEspera.FormattingEnabled = true;
            lbListaDeEspera.Location = new Point(12, 184);
            lbListaDeEspera.Name = "lbListaDeEspera";
            lbListaDeEspera.Size = new Size(352, 304);
            lbListaDeEspera.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 5);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(381, 5);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(181, 35);
            label2.TabIndex = 18;
            label2.Text = "Lista de espera";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(12, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(352, 37);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Agregar Cliente";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // inpClientName
            // 
            inpClientName.Location = new Point(12, 55);
            inpClientName.Name = "inpClientName";
            inpClientName.PlaceholderText = "Nombre Del Cliente...";
            inpClientName.Size = new Size(352, 27);
            inpClientName.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(191, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 37);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Eliminar Cliente";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSitClient
            // 
            btnSitClient.Location = new Point(12, 131);
            btnSitClient.Name = "btnSitClient";
            btnSitClient.Size = new Size(172, 37);
            btnSitClient.TabIndex = 21;
            btnSitClient.Text = "Sentar Cliente";
            btnSitClient.UseVisualStyleBackColor = true;
            btnSitClient.Click += btnSitClient_Click;
            // 
            // ListaDeEsperaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 501);
            Controls.Add(btnDelete);
            Controls.Add(btnSitClient);
            Controls.Add(inpClientName);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lbListaDeEspera);
            Name = "ListaDeEsperaForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbListaDeEspera;
        private Label label1;
        private Label label4;
        private Label label2;
        private Button btnAdd;
        private TextBox inpClientName;
        private Button btnDelete;
        private Button btnSitClient;
    }
}