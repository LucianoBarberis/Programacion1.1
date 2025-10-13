namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack
{
    partial class ParentecisForm
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
            inpExprecion = new TextBox();
            btnVerify = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 35);
            label2.TabIndex = 3;
            label2.Text = "Parentecis Balanceados";
            // 
            // inpExprecion
            // 
            inpExprecion.Font = new Font("Segoe UI", 11F);
            inpExprecion.Location = new Point(15, 58);
            inpExprecion.Name = "inpExprecion";
            inpExprecion.PlaceholderText = "Expresion...";
            inpExprecion.Size = new Size(389, 32);
            inpExprecion.TabIndex = 4;
            // 
            // btnVerify
            // 
            btnVerify.Font = new Font("Segoe UI", 10F);
            btnVerify.Location = new Point(109, 107);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(201, 40);
            btnVerify.TabIndex = 5;
            btnVerify.Text = "Verificar";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // ParentecisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 173);
            Controls.Add(btnVerify);
            Controls.Add(inpExprecion);
            Controls.Add(label2);
            Name = "ParentecisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ParentecisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox inpExprecion;
        private Button btnVerify;
    }
}