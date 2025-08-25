namespace WinForms1
{
    partial class Ej01
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
            lblTitle = new Label();
            inpPeso = new TextBox();
            inpAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnResult = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(33, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Calculadora IMC";
            // 
            // inpPeso
            // 
            inpPeso.BackColor = Color.White;
            inpPeso.ForeColor = SystemColors.WindowText;
            inpPeso.Location = new Point(33, 89);
            inpPeso.Name = "inpPeso";
            inpPeso.Size = new Size(195, 27);
            inpPeso.TabIndex = 1;
            // 
            // inpAltura
            // 
            inpAltura.Location = new Point(33, 164);
            inpAltura.Name = "inpAltura";
            inpAltura.Size = new Size(195, 27);
            inpAltura.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 66);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "Peso (En Kg.)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 141);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 4;
            label2.Text = "Altura (En metros ej. 1,80)";
            // 
            // btnResult
            // 
            btnResult.Location = new Point(79, 215);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(94, 29);
            btnResult.TabIndex = 5;
            btnResult.Text = "Calcular...";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(33, 271);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(82, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Resultado: ";
            // 
            // Ej01
            // 
            ClientSize = new Size(260, 355);
            Controls.Add(lblResult);
            Controls.Add(btnResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inpAltura);
            Controls.Add(inpPeso);
            Controls.Add(lblTitle);
            Name = "Ej01";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox inpPeso;
        private TextBox inpAltura;
        private Label label1;
        private Label label2;
        private Button btnResult;
        private Label lblResult;
    }
}
