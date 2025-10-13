namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList
{
    partial class PlaylistMusicaForm
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
            inpSong = new TextBox();
            btnAdd = new Button();
            prevSong = new Button();
            nextSong = new Button();
            label1 = new Label();
            lbPlaylist = new ListBox();
            label3 = new Label();
            panel1 = new Panel();
            lblActual = new Label();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(182, 35);
            label2.TabIndex = 20;
            label2.Text = "Playlist Musical";
            // 
            // inpSong
            // 
            inpSong.Location = new Point(12, 56);
            inpSong.Name = "inpSong";
            inpSong.PlaceholderText = "Titulo de la Cancion...";
            inpSong.Size = new Size(238, 27);
            inpSong.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(256, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // prevSong
            // 
            prevSong.Font = new Font("Segoe UI", 12F);
            prevSong.Location = new Point(12, 312);
            prevSong.Name = "prevSong";
            prevSong.Size = new Size(50, 50);
            prevSong.TabIndex = 23;
            prevSong.Text = "<<";
            prevSong.UseVisualStyleBackColor = true;
            prevSong.Click += prevSong_Click;
            // 
            // nextSong
            // 
            nextSong.Font = new Font("Segoe UI", 12F);
            nextSong.Location = new Point(278, 312);
            nextSong.Name = "nextSong";
            nextSong.Size = new Size(50, 50);
            nextSong.TabIndex = 24;
            nextSong.Text = ">>";
            nextSong.UseVisualStyleBackColor = true;
            nextSong.Click += nextSong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(11, 100);
            label1.Name = "label1";
            label1.Size = new Size(143, 19);
            label1.TabIndex = 25;
            label1.Text = "Lista de Reproduccion";
            // 
            // lbPlaylist
            // 
            lbPlaylist.FormattingEnabled = true;
            lbPlaylist.Location = new Point(12, 122);
            lbPlaylist.Name = "lbPlaylist";
            lbPlaylist.Size = new Size(319, 184);
            lbPlaylist.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 27;
            label3.Text = "Actual:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblActual);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(82, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 50);
            panel1.TabIndex = 28;
            // 
            // lblActual
            // 
            lblActual.Font = new Font("Segoe UI", 9F);
            lblActual.Location = new Point(3, 17);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(157, 25);
            lblActual.TabIndex = 28;
            lblActual.Text = "Nada";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(82, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 36);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Borrar Seleccion";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PlaylistMusicaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 415);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Controls.Add(lbPlaylist);
            Controls.Add(label1);
            Controls.Add(nextSong);
            Controls.Add(prevSong);
            Controls.Add(btnAdd);
            Controls.Add(inpSong);
            Controls.Add(label2);
            Name = "PlaylistMusicaForm";
            Text = "PlaylistMusicaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox inpSong;
        private Button btnAdd;
        private Button prevSong;
        private Button nextSong;
        private Label label1;
        private ListBox lbPlaylist;
        private Label label3;
        private Panel panel1;
        private Label lblActual;
        private Button btnDelete;
    }
}