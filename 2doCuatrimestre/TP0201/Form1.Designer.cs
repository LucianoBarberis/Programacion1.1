namespace TP0201
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
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            price = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbtnCity = new RadioButton();
            rbtnMontaña = new RadioButton();
            rbtnPlaya = new RadioButton();
            groupBox2 = new GroupBox();
            cbComidas = new CheckBox();
            cbTraslados = new CheckBox();
            cbGuia = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            mujerToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 22F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(393, 53);
            label1.TabIndex = 0;
            label1.Text = "Cotización De Viajes";
            // 
            // name
            // 
            name.Font = new Font("Inter SemiBold", 13F, FontStyle.Bold);
            name.Location = new Point(22, 130);
            name.Name = "name";
            name.Size = new Size(231, 34);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 105);
            label2.Name = "label2";
            label2.Size = new Size(161, 22);
            label2.TabIndex = 2;
            label2.Text = "Nombre del pasajero";
            // 
            // price
            // 
            price.Font = new Font("Inter SemiBold", 13F, FontStyle.Bold);
            price.Location = new Point(22, 201);
            price.Name = "price";
            price.Size = new Size(231, 34);
            price.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 176);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 4;
            label3.Text = "Precio base";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnCity);
            groupBox1.Controls.Add(rbtnMontaña);
            groupBox1.Controls.Add(rbtnPlaya);
            groupBox1.Location = new Point(286, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 130);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destino";
            // 
            // rbtnCity
            // 
            rbtnCity.AutoSize = true;
            rbtnCity.Location = new Point(6, 97);
            rbtnCity.Name = "rbtnCity";
            rbtnCity.Size = new Size(82, 26);
            rbtnCity.TabIndex = 2;
            rbtnCity.TabStop = true;
            rbtnCity.Text = "Ciudad";
            rbtnCity.UseVisualStyleBackColor = true;
            // 
            // rbtnMontaña
            // 
            rbtnMontaña.AutoSize = true;
            rbtnMontaña.Location = new Point(6, 65);
            rbtnMontaña.Name = "rbtnMontaña";
            rbtnMontaña.Size = new Size(95, 26);
            rbtnMontaña.TabIndex = 1;
            rbtnMontaña.TabStop = true;
            rbtnMontaña.Text = "Montaña";
            rbtnMontaña.UseVisualStyleBackColor = true;
            // 
            // rbtnPlaya
            // 
            rbtnPlaya.AutoSize = true;
            rbtnPlaya.Location = new Point(6, 33);
            rbtnPlaya.Name = "rbtnPlaya";
            rbtnPlaya.Size = new Size(72, 26);
            rbtnPlaya.TabIndex = 0;
            rbtnPlaya.TabStop = true;
            rbtnPlaya.Text = "Playa";
            rbtnPlaya.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbComidas);
            groupBox2.Controls.Add(cbTraslados);
            groupBox2.Controls.Add(cbGuia);
            groupBox2.Location = new Point(22, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 78);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios adicionales";
            // 
            // cbComidas
            // 
            cbComidas.AutoSize = true;
            cbComidas.Location = new Point(303, 34);
            cbComidas.Name = "cbComidas";
            cbComidas.Size = new Size(96, 26);
            cbComidas.TabIndex = 5;
            cbComidas.Text = "Comidas";
            cbComidas.UseVisualStyleBackColor = true;
            // 
            // cbTraslados
            // 
            cbTraslados.AutoSize = true;
            cbTraslados.Location = new Point(157, 34);
            cbTraslados.Name = "cbTraslados";
            cbTraslados.Size = new Size(103, 26);
            cbTraslados.TabIndex = 4;
            cbTraslados.Text = "Traslados";
            cbTraslados.UseVisualStyleBackColor = true;
            // 
            // cbGuia
            // 
            cbGuia.AutoSize = true;
            cbGuia.Location = new Point(31, 34);
            cbGuia.Name = "cbGuia";
            cbGuia.Size = new Size(65, 26);
            cbGuia.TabIndex = 3;
            cbGuia.Text = "Guia";
            cbGuia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold);
            button1.Location = new Point(22, 353);
            button1.Name = "button1";
            button1.Size = new Size(419, 58);
            button1.TabIndex = 7;
            button1.Text = "Generar Cotización";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 425);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(419, 180);
            textBox1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(466, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mujerToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(154, 26);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mujerToolStripMenuItem
            // 
            mujerToolStripMenuItem.AutoToolTip = true;
            mujerToolStripMenuItem.CheckOnClick = true;
            mujerToolStripMenuItem.Name = "mujerToolStripMenuItem";
            mujerToolStripMenuItem.Size = new Size(104, 26);
            mujerToolStripMenuItem.Text = "Si";
            mujerToolStripMenuItem.ToolTipText = "Activar";
            mujerToolStripMenuItem.Click += mujerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 622);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sistema De Cotización";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private TextBox price;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbtnCity;
        private RadioButton rbtnMontaña;
        private RadioButton rbtnPlaya;
        private CheckBox cbComidas;
        private CheckBox cbTraslados;
        private CheckBox cbGuia;
        private Button button1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem mujerToolStripMenuItem;
    }
}
