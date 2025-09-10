namespace Practica001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            listBox1 = new ListBox();
            lblTitle = new Label();
            btnDelete = new Button();
            button2 = new Button();
            btnEdit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Inter", 13F);
            btnAdd.Location = new Point(14, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(259, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(14, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 202);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Inter Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(168, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 53);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "To-Do App";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Inter", 13F);
            btnDelete.Location = new Point(279, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(259, 59);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Inter", 13F);
            button2.Location = new Point(279, 474);
            button2.Name = "button2";
            button2.Size = new Size(259, 59);
            button2.TabIndex = 5;
            button2.Text = "Creditos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Inter", 13F);
            btnEdit.Location = new Point(14, 474);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(259, 59);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(14, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(524, 36);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F);
            label1.Location = new Point(14, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 7;
            label1.Text = "Tarea";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 547);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblTitle);
            Controls.Add(listBox1);
            Controls.Add(btnAdd);
            Font = new Font("Inter", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "To-Do App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox listBox1;
        private Label lblTitle;
        private Button btnDelete;
        private Button button2;
        private Button btnEdit;
        private TextBox textBox1;
        private Label label1;
    }
}
