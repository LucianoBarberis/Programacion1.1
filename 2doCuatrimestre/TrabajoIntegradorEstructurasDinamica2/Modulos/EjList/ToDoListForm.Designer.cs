namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjList
{
    partial class ToDoListForm
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
            label2 = new Label();
            label3 = new Label();
            inpAdd = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            lbTasks = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 35);
            label2.TabIndex = 1;
            label2.Text = "To-do List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 10;
            label3.Text = "Tarea";
            // 
            // inpAdd
            // 
            inpAdd.Location = new Point(12, 78);
            inpAdd.Name = "inpAdd";
            inpAdd.Size = new Size(350, 27);
            inpAdd.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(192, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 37);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Completar Tarea";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 37);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Agregar Tarea";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.Location = new Point(12, 180);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(350, 244);
            lbTasks.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 14;
            label4.Text = "Tareas a realizar";
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 436);
            Controls.Add(label4);
            Controls.Add(lbTasks);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(inpAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ToDoListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ToDoListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inpAdd;
        private Button btnDelete;
        private Button btnAdd;
        private ListBox lbTasks;
        private Label label4;
    }
}