namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue
{
    partial class CallCenterForm
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
            button1 = new Button();
            lbCalls = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(134, 35);
            label2.TabIndex = 5;
            label2.Text = "Call Center\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 58);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 6;
            button1.Text = "Atender";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCalls
            // 
            lbCalls.FormattingEnabled = true;
            lbCalls.Location = new Point(12, 134);
            lbCalls.Name = "lbCalls";
            lbCalls.Size = new Size(322, 304);
            lbCalls.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 8;
            label1.Text = "Llamadas Entrantes";
            // 
            // CallCenterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(label1);
            Controls.Add(lbCalls);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "CallCenterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CallCenterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private ListBox lbCalls;
        private Label label1;
    }
}