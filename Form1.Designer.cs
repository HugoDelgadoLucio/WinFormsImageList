namespace WinFormsImageList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelNombres = new Label();
            labelTitulo = new Label();
            btnCambio = new Button();
            labelFoto = new Label();
            imgFotos = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(labelNombres);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(btnCambio);
            panel1.Controls.Add(labelFoto);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 360);
            panel1.TabIndex = 0;
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombres.Location = new Point(131, 218);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(0, 22);
            labelNombres.TabIndex = 3;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(103, 13);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(311, 48);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Top mejores albums de la histora \r\n by Hugo Ernesto Delgado Lucio";
            // 
            // btnCambio
            // 
            btnCambio.BackColor = SystemColors.ActiveCaptionText;
            btnCambio.FlatStyle = FlatStyle.Popup;
            btnCambio.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambio.ForeColor = Color.LimeGreen;
            btnCambio.Location = new Point(185, 276);
            btnCambio.Name = "btnCambio";
            btnCambio.Size = new Size(154, 46);
            btnCambio.TabIndex = 1;
            btnCambio.Text = "Siguiente album";
            btnCambio.UseVisualStyleBackColor = false;
            btnCambio.Click += btnCambio_Click;
            // 
            // labelFoto
            // 
            labelFoto.ImageIndex = 0;
            labelFoto.ImageList = imgFotos;
            labelFoto.Location = new Point(211, 91);
            labelFoto.Name = "labelFoto";
            labelFoto.Size = new Size(100, 100);
            labelFoto.TabIndex = 0;
            // 
            // imgFotos
            // 
            imgFotos.ColorDepth = ColorDepth.Depth32Bit;
            imgFotos.ImageStream = (ImageListStreamer)resources.GetObject("imgFotos.ImageStream");
            imgFotos.TransparentColor = Color.Transparent;
            imgFotos.Images.SetKeyName(0, "i1.jpeg");
            imgFotos.Images.SetKeyName(1, "i2.png");
            imgFotos.Images.SetKeyName(2, "i3.jpg");
            imgFotos.Images.SetKeyName(3, "i4.jpg");
            imgFotos.Images.SetKeyName(4, "i5.jpeg");
            imgFotos.Images.SetKeyName(5, "i6.jpg");
            imgFotos.Images.SetKeyName(6, "i7.jpeg");
            imgFotos.Images.SetKeyName(7, "i8.jpeg");
            imgFotos.Images.SetKeyName(8, "i9.jpeg");
            imgFotos.Images.SetKeyName(9, "i10.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 350);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Image List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ImageList imgFotos;
        private Button btnCambio;
        private Label labelFoto;
        private Label labelTitulo;
        private Label labelNombres;
    }
}
