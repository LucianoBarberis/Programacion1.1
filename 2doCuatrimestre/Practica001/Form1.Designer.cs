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
            btnAdd = new Button();
            listBox1 = new ListBox();
            lblTitle = new Label();
            btnDelete = new Button();
            button2 = new Button();
            btnEdit = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 54);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(546, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F);
            lblTitle.Location = new Point(185, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "To-Do App";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 410);
            button2.Name = "button2";
            button2.Size = new Size(230, 54);
            button2.TabIndex = 5;
            button2.Text = "Creditos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(230, 54);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 499);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblTitle);
            Controls.Add(listBox1);
            Controls.Add(btnAdd);
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
    }
}
