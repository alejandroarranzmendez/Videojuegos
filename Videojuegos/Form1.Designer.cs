namespace Videojuegos
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            BotónDestacados = new Button();
            BotónMisJuegos = new Button();
            BotónConfiguración = new Button();
            BotónEnBlanco = new Button();
            Header = new GroupBox();
            BotónMiPerfil = new Button();
            BotónSoporte = new Button();
            BotónComunidad = new Button();
            BotónTienda = new Button();
            BarraHerramientas = new GroupBox();
            PanelGTAV = new Panel();
            TextoGTAV = new TextBox();
            ImagenGTAV = new PictureBox();
            PanelCSGO = new Panel();
            TextoCSGO = new TextBox();
            ImagenCSGO = new PictureBox();
            PanelMinecraft = new Panel();
            TextoMinecraft = new TextBox();
            ImagenMinecraft = new PictureBox();
            PanelFC25 = new Panel();
            TextoFC25 = new TextBox();
            ImagenFC25 = new PictureBox();
            PanelMarioKart = new Panel();
            TextoMarioKart = new TextBox();
            ImagenMarioKart = new PictureBox();
            PanelCallOfDuty = new Panel();
            TextoCallOfDuty = new TextBox();
            ImagenCallOfDuty = new PictureBox();
            Header.SuspendLayout();
            BarraHerramientas.SuspendLayout();
            PanelGTAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenGTAV).BeginInit();
            PanelCSGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenCSGO).BeginInit();
            PanelMinecraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenMinecraft).BeginInit();
            PanelFC25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenFC25).BeginInit();
            PanelMarioKart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenMarioKart).BeginInit();
            PanelCallOfDuty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenCallOfDuty).BeginInit();
            SuspendLayout();
            // 
            // BotónDestacados
            // 
            BotónDestacados.BackColor = Color.FromArgb(224, 224, 224);
            BotónDestacados.Cursor = Cursors.Hand;
            BotónDestacados.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotónDestacados.ForeColor = Color.FromArgb(64, 64, 64);
            BotónDestacados.Location = new Point(25, 25);
            BotónDestacados.Name = "BotónDestacados";
            BotónDestacados.Size = new Size(150, 50);
            BotónDestacados.TabIndex = 0;
            BotónDestacados.Text = "Destacados";
            BotónDestacados.UseVisualStyleBackColor = false;
            BotónDestacados.Click += button1_Click;
            // 
            // BotónMisJuegos
            // 
            BotónMisJuegos.BackColor = Color.FromArgb(224, 224, 224);
            BotónMisJuegos.Cursor = Cursors.Hand;
            BotónMisJuegos.Font = new Font("Impact", 12F);
            BotónMisJuegos.ForeColor = Color.FromArgb(64, 64, 64);
            BotónMisJuegos.Location = new Point(25, 100);
            BotónMisJuegos.Name = "BotónMisJuegos";
            BotónMisJuegos.Size = new Size(150, 50);
            BotónMisJuegos.TabIndex = 1;
            BotónMisJuegos.Text = "Mis juegos";
            BotónMisJuegos.UseVisualStyleBackColor = false;
            // 
            // BotónConfiguración
            // 
            BotónConfiguración.BackColor = Color.FromArgb(224, 224, 224);
            BotónConfiguración.Cursor = Cursors.Hand;
            BotónConfiguración.Font = new Font("Impact", 12F);
            BotónConfiguración.ForeColor = Color.FromArgb(64, 64, 64);
            BotónConfiguración.Location = new Point(25, 175);
            BotónConfiguración.Name = "BotónConfiguración";
            BotónConfiguración.Size = new Size(150, 50);
            BotónConfiguración.TabIndex = 2;
            BotónConfiguración.Text = "Configuración";
            BotónConfiguración.UseVisualStyleBackColor = false;
            // 
            // BotónEnBlanco
            // 
            BotónEnBlanco.BackColor = Color.FromArgb(224, 224, 224);
            BotónEnBlanco.Cursor = Cursors.Hand;
            BotónEnBlanco.Font = new Font("Impact", 12F);
            BotónEnBlanco.ForeColor = Color.FromArgb(64, 64, 64);
            BotónEnBlanco.Location = new Point(25, 250);
            BotónEnBlanco.Name = "BotónEnBlanco";
            BotónEnBlanco.Size = new Size(150, 50);
            BotónEnBlanco.TabIndex = 3;
            BotónEnBlanco.Text = "¿?";
            BotónEnBlanco.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            Header.BackColor = Color.Silver;
            Header.Controls.Add(BotónMiPerfil);
            Header.Controls.Add(BotónSoporte);
            Header.Controls.Add(BotónComunidad);
            Header.Controls.Add(BotónTienda);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1920, 100);
            Header.TabIndex = 4;
            Header.TabStop = false;
            Header.Enter += groupBox1_Enter;
            // 
            // BotónMiPerfil
            // 
            BotónMiPerfil.BackColor = Color.FromArgb(224, 224, 224);
            BotónMiPerfil.Cursor = Cursors.Hand;
            BotónMiPerfil.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotónMiPerfil.ForeColor = Color.FromArgb(64, 64, 64);
            BotónMiPerfil.Location = new Point(1745, 25);
            BotónMiPerfil.Name = "BotónMiPerfil";
            BotónMiPerfil.Size = new Size(150, 50);
            BotónMiPerfil.TabIndex = 4;
            BotónMiPerfil.Text = "Mi Perfil";
            BotónMiPerfil.UseVisualStyleBackColor = false;
            BotónMiPerfil.Click += button12_Click;
            // 
            // BotónSoporte
            // 
            BotónSoporte.BackColor = Color.FromArgb(224, 224, 224);
            BotónSoporte.Cursor = Cursors.Hand;
            BotónSoporte.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotónSoporte.ForeColor = Color.FromArgb(64, 64, 64);
            BotónSoporte.Location = new Point(960, 25);
            BotónSoporte.Name = "BotónSoporte";
            BotónSoporte.Size = new Size(150, 50);
            BotónSoporte.TabIndex = 3;
            BotónSoporte.Text = "Soporte";
            BotónSoporte.UseVisualStyleBackColor = false;
            // 
            // BotónComunidad
            // 
            BotónComunidad.BackColor = Color.FromArgb(224, 224, 224);
            BotónComunidad.Cursor = Cursors.Hand;
            BotónComunidad.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotónComunidad.ForeColor = Color.FromArgb(64, 64, 64);
            BotónComunidad.Location = new Point(785, 25);
            BotónComunidad.Name = "BotónComunidad";
            BotónComunidad.Size = new Size(150, 50);
            BotónComunidad.TabIndex = 2;
            BotónComunidad.Text = "Comunidad";
            BotónComunidad.UseVisualStyleBackColor = false;
            // 
            // BotónTienda
            // 
            BotónTienda.BackColor = Color.FromArgb(224, 224, 224);
            BotónTienda.Cursor = Cursors.Hand;
            BotónTienda.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotónTienda.ForeColor = Color.FromArgb(64, 64, 64);
            BotónTienda.Location = new Point(610, 25);
            BotónTienda.Name = "BotónTienda";
            BotónTienda.Size = new Size(150, 50);
            BotónTienda.TabIndex = 1;
            BotónTienda.Text = "Tienda";
            BotónTienda.UseVisualStyleBackColor = false;
            BotónTienda.Click += button10_Click;
            // 
            // BarraHerramientas
            // 
            BarraHerramientas.BackColor = Color.Silver;
            BarraHerramientas.Controls.Add(BotónDestacados);
            BarraHerramientas.Controls.Add(BotónMisJuegos);
            BarraHerramientas.Controls.Add(BotónEnBlanco);
            BarraHerramientas.Controls.Add(BotónConfiguración);
            BarraHerramientas.Location = new Point(0, 150);
            BarraHerramientas.Name = "BarraHerramientas";
            BarraHerramientas.Size = new Size(200, 325);
            BarraHerramientas.TabIndex = 5;
            BarraHerramientas.TabStop = false;
            BarraHerramientas.Enter += groupBox2_Enter;
            // 
            // PanelGTAV
            // 
            PanelGTAV.Controls.Add(TextoGTAV);
            PanelGTAV.Controls.Add(ImagenGTAV);
            PanelGTAV.Location = new Point(525, 150);
            PanelGTAV.Name = "PanelGTAV";
            PanelGTAV.Size = new Size(225, 320);
            PanelGTAV.TabIndex = 19;
            // 
            // TextoGTAV
            // 
            TextoGTAV.BackColor = Color.White;
            TextoGTAV.BorderStyle = BorderStyle.None;
            TextoGTAV.Font = new Font("Impact", 12F);
            TextoGTAV.ForeColor = Color.FromArgb(64, 64, 64);
            TextoGTAV.Location = new Point(0, 300);
            TextoGTAV.Name = "TextoGTAV";
            TextoGTAV.Size = new Size(225, 20);
            TextoGTAV.TabIndex = 13;
            TextoGTAV.Text = "GTA V";
            TextoGTAV.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenGTAV
            // 
            ImagenGTAV.Cursor = Cursors.Hand;
            ImagenGTAV.Image = (Image)resources.GetObject("ImagenGTAV.Image");
            ImagenGTAV.Location = new Point(0, 0);
            ImagenGTAV.Name = "ImagenGTAV";
            ImagenGTAV.Size = new Size(225, 300);
            ImagenGTAV.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenGTAV.TabIndex = 13;
            ImagenGTAV.TabStop = false;
            // 
            // PanelCSGO
            // 
            PanelCSGO.Controls.Add(TextoCSGO);
            PanelCSGO.Controls.Add(ImagenCSGO);
            PanelCSGO.Location = new Point(800, 150);
            PanelCSGO.Name = "PanelCSGO";
            PanelCSGO.Size = new Size(225, 320);
            PanelCSGO.TabIndex = 20;
            // 
            // TextoCSGO
            // 
            TextoCSGO.BackColor = Color.White;
            TextoCSGO.BorderStyle = BorderStyle.None;
            TextoCSGO.Font = new Font("Impact", 12F);
            TextoCSGO.ForeColor = Color.FromArgb(64, 64, 64);
            TextoCSGO.Location = new Point(0, 300);
            TextoCSGO.Name = "TextoCSGO";
            TextoCSGO.Size = new Size(225, 20);
            TextoCSGO.TabIndex = 13;
            TextoCSGO.Text = "CS:GO";
            TextoCSGO.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenCSGO
            // 
            ImagenCSGO.Cursor = Cursors.Hand;
            ImagenCSGO.Image = (Image)resources.GetObject("ImagenCSGO.Image");
            ImagenCSGO.Location = new Point(0, 0);
            ImagenCSGO.Name = "ImagenCSGO";
            ImagenCSGO.Size = new Size(225, 300);
            ImagenCSGO.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenCSGO.TabIndex = 13;
            ImagenCSGO.TabStop = false;
            // 
            // PanelMinecraft
            // 
            PanelMinecraft.Controls.Add(TextoMinecraft);
            PanelMinecraft.Controls.Add(ImagenMinecraft);
            PanelMinecraft.Location = new Point(250, 150);
            PanelMinecraft.Name = "PanelMinecraft";
            PanelMinecraft.Size = new Size(225, 320);
            PanelMinecraft.TabIndex = 20;
            // 
            // TextoMinecraft
            // 
            TextoMinecraft.BackColor = Color.White;
            TextoMinecraft.BorderStyle = BorderStyle.None;
            TextoMinecraft.Font = new Font("Impact", 12F);
            TextoMinecraft.ForeColor = Color.FromArgb(64, 64, 64);
            TextoMinecraft.Location = new Point(0, 300);
            TextoMinecraft.Name = "TextoMinecraft";
            TextoMinecraft.Size = new Size(225, 20);
            TextoMinecraft.TabIndex = 13;
            TextoMinecraft.Text = "Minecraft";
            TextoMinecraft.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenMinecraft
            // 
            ImagenMinecraft.Cursor = Cursors.Hand;
            ImagenMinecraft.Image = (Image)resources.GetObject("ImagenMinecraft.Image");
            ImagenMinecraft.Location = new Point(0, 0);
            ImagenMinecraft.Name = "ImagenMinecraft";
            ImagenMinecraft.Size = new Size(225, 300);
            ImagenMinecraft.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMinecraft.TabIndex = 13;
            ImagenMinecraft.TabStop = false;
            // 
            // PanelFC25
            // 
            PanelFC25.Controls.Add(TextoFC25);
            PanelFC25.Controls.Add(ImagenFC25);
            PanelFC25.Location = new Point(1075, 150);
            PanelFC25.Name = "PanelFC25";
            PanelFC25.Size = new Size(225, 320);
            PanelFC25.TabIndex = 21;
            // 
            // TextoFC25
            // 
            TextoFC25.BackColor = Color.White;
            TextoFC25.BorderStyle = BorderStyle.None;
            TextoFC25.Font = new Font("Impact", 12F);
            TextoFC25.ForeColor = Color.FromArgb(64, 64, 64);
            TextoFC25.Location = new Point(0, 300);
            TextoFC25.Name = "TextoFC25";
            TextoFC25.Size = new Size(225, 20);
            TextoFC25.TabIndex = 13;
            TextoFC25.Text = "FC25";
            TextoFC25.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenFC25
            // 
            ImagenFC25.Cursor = Cursors.Hand;
            ImagenFC25.Image = (Image)resources.GetObject("ImagenFC25.Image");
            ImagenFC25.Location = new Point(0, 0);
            ImagenFC25.Name = "ImagenFC25";
            ImagenFC25.Size = new Size(225, 300);
            ImagenFC25.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenFC25.TabIndex = 13;
            ImagenFC25.TabStop = false;
            // 
            // PanelMarioKart
            // 
            PanelMarioKart.Controls.Add(TextoMarioKart);
            PanelMarioKart.Controls.Add(ImagenMarioKart);
            PanelMarioKart.Location = new Point(1350, 150);
            PanelMarioKart.Name = "PanelMarioKart";
            PanelMarioKart.Size = new Size(225, 320);
            PanelMarioKart.TabIndex = 22;
            // 
            // TextoMarioKart
            // 
            TextoMarioKart.BackColor = Color.White;
            TextoMarioKart.BorderStyle = BorderStyle.None;
            TextoMarioKart.Font = new Font("Impact", 12F);
            TextoMarioKart.ForeColor = Color.FromArgb(64, 64, 64);
            TextoMarioKart.Location = new Point(0, 300);
            TextoMarioKart.Name = "TextoMarioKart";
            TextoMarioKart.Size = new Size(225, 20);
            TextoMarioKart.TabIndex = 13;
            TextoMarioKart.Text = "Mario Kart";
            TextoMarioKart.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenMarioKart
            // 
            ImagenMarioKart.Cursor = Cursors.Hand;
            ImagenMarioKart.Image = (Image)resources.GetObject("ImagenMarioKart.Image");
            ImagenMarioKart.Location = new Point(0, 0);
            ImagenMarioKart.Name = "ImagenMarioKart";
            ImagenMarioKart.Size = new Size(225, 300);
            ImagenMarioKart.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMarioKart.TabIndex = 13;
            ImagenMarioKart.TabStop = false;
            // 
            // PanelCallOfDuty
            // 
            PanelCallOfDuty.Controls.Add(TextoCallOfDuty);
            PanelCallOfDuty.Controls.Add(ImagenCallOfDuty);
            PanelCallOfDuty.Location = new Point(1625, 150);
            PanelCallOfDuty.Name = "PanelCallOfDuty";
            PanelCallOfDuty.Size = new Size(225, 320);
            PanelCallOfDuty.TabIndex = 23;
            // 
            // TextoCallOfDuty
            // 
            TextoCallOfDuty.BackColor = Color.White;
            TextoCallOfDuty.BorderStyle = BorderStyle.None;
            TextoCallOfDuty.Font = new Font("Impact", 12F);
            TextoCallOfDuty.ForeColor = Color.FromArgb(64, 64, 64);
            TextoCallOfDuty.Location = new Point(0, 300);
            TextoCallOfDuty.Name = "TextoCallOfDuty";
            TextoCallOfDuty.Size = new Size(225, 20);
            TextoCallOfDuty.TabIndex = 13;
            TextoCallOfDuty.Text = "Call of Duty (Infinity Warface)";
            TextoCallOfDuty.TextAlign = HorizontalAlignment.Center;
            // 
            // ImagenCallOfDuty
            // 
            ImagenCallOfDuty.Cursor = Cursors.Hand;
            ImagenCallOfDuty.Image = (Image)resources.GetObject("ImagenCallOfDuty.Image");
            ImagenCallOfDuty.Location = new Point(0, 0);
            ImagenCallOfDuty.Name = "ImagenCallOfDuty";
            ImagenCallOfDuty.Size = new Size(225, 300);
            ImagenCallOfDuty.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenCallOfDuty.TabIndex = 13;
            ImagenCallOfDuty.TabStop = false;
            // 
            // Ventana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1904, 1041);
            Controls.Add(PanelCallOfDuty);
            Controls.Add(PanelMarioKart);
            Controls.Add(PanelFC25);
            Controls.Add(PanelMinecraft);
            Controls.Add(PanelCSGO);
            Controls.Add(PanelGTAV);
            Controls.Add(BarraHerramientas);
            Controls.Add(Header);
            Name = "Ventana";
            Text = "ArranzGames";
            Load += Form1_Load;
            Header.ResumeLayout(false);
            BarraHerramientas.ResumeLayout(false);
            PanelGTAV.ResumeLayout(false);
            PanelGTAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenGTAV).EndInit();
            PanelCSGO.ResumeLayout(false);
            PanelCSGO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenCSGO).EndInit();
            PanelMinecraft.ResumeLayout(false);
            PanelMinecraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenMinecraft).EndInit();
            PanelFC25.ResumeLayout(false);
            PanelFC25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenFC25).EndInit();
            PanelMarioKart.ResumeLayout(false);
            PanelMarioKart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenMarioKart).EndInit();
            PanelCallOfDuty.ResumeLayout(false);
            PanelCallOfDuty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenCallOfDuty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotónDestacados;
        private Button BotónMisJuegos;
        private Button BotónConfiguración;
        private Button BotónEnBlanco;
        private GroupBox Header;
        private Button BotónTienda;
        private Button BotónMiPerfil;
        private Button BotónSoporte;
        private Button BotónComunidad;
        private GroupBox BarraHerramientas;
        private Panel PanelGTAV;
        private TextBox TextoGTAV;
        private PictureBox ImagenGTAV;
        private Panel PanelCSGO;
        private TextBox TextoCSGO;
        private PictureBox ImagenCSGO;
        private Panel PanelMinecraft;
        private TextBox TextoMinecraft;
        private PictureBox ImagenMinecraft;
        private Panel PanelFC25;
        private TextBox TextoFC25;
        private PictureBox ImagenFC25;
        private Panel PanelMarioKart;
        private TextBox TextoMarioKart;
        private PictureBox ImagenMarioKart;
        private Panel PanelCallOfDuty;
        private TextBox TextoCallOfDuty;
        private PictureBox ImagenCallOfDuty;
    }
}
