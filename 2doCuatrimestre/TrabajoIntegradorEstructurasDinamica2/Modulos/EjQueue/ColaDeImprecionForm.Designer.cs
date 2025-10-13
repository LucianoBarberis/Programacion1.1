namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue
{
    partial class ColaDeImprecionForm
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
            progressBar1 = new ProgressBar();
            btnAdd = new Button();
            label2 = new Label();
            btnPrint = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 107);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(324, 26);
            progressBar1.Step = 15;
            progressBar1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.Location = new Point(12, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Añadir Doc.";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(219, 35);
            label2.TabIndex = 4;
            label2.Text = "Cola de Imprecion\r\n";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 10F);
            btnPrint.Location = new Point(183, 56);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(153, 36);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(324, 204);
            listBox1.TabIndex = 6;
            // 
            // ColaDeImprecionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 365);
            Controls.Add(listBox1);
            Controls.Add(btnPrint);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(progressBar1);
            Name = "ColaDeImprecionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ColaDeImprecionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnAdd;
        private Label label2;
        private Button btnPrint;
        private ListBox listBox1;
    }
}