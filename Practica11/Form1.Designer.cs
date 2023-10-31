namespace Practica11
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
            Negro = new Button();
            label1 = new Label();
            Rojo = new Button();
            Amarillo = new Button();
            Gris = new Button();
            Rosa = new Button();
            Azul = new Button();
            AtendidoCoche = new PictureBox();
            PrimerCoche = new PictureBox();
            SegundoCoche = new PictureBox();
            TercerCoche = new PictureBox();
            CuartoCoche = new PictureBox();
            QuintoCoche = new PictureBox();
            Atendido = new Label();
            Primero = new Label();
            Segundo = new Label();
            Tercero = new Label();
            Cuarto = new Label();
            Quinto = new Label();
            Start = new Button();
            RecordAct = new Label();
            button1 = new Button();
            Naranja = new Button();
            Morado = new Button();
            ((System.ComponentModel.ISupportInitialize)AtendidoCoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimerCoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SegundoCoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TercerCoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CuartoCoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuintoCoche).BeginInit();
            SuspendLayout();
            // 
            // Negro
            // 
            Negro.BackColor = Color.Black;
            Negro.ForeColor = SystemColors.ControlLightLight;
            Negro.Location = new Point(103, 292);
            Negro.Margin = new Padding(3, 4, 3, 4);
            Negro.Name = "Negro";
            Negro.Size = new Size(192, 80);
            Negro.TabIndex = 0;
            Negro.Text = "Negro";
            Negro.UseVisualStyleBackColor = false;
            Negro.Click += Negro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(396, 144);
            label1.Name = "label1";
            label1.Size = new Size(362, 55);
            label1.TabIndex = 1;
            label1.Text = "PINTACARRITOS";
            label1.Click += label1_Click;
            // 
            // Rojo
            // 
            Rojo.BackColor = Color.Red;
            Rojo.Location = new Point(352, 292);
            Rojo.Margin = new Padding(3, 4, 3, 4);
            Rojo.Name = "Rojo";
            Rojo.Size = new Size(192, 80);
            Rojo.TabIndex = 3;
            Rojo.Text = "Rojo";
            Rojo.UseVisualStyleBackColor = false;
            Rojo.Click += Rojo_Click;
            // 
            // Amarillo
            // 
            Amarillo.BackColor = Color.Yellow;
            Amarillo.Location = new Point(606, 292);
            Amarillo.Margin = new Padding(3, 4, 3, 4);
            Amarillo.Name = "Amarillo";
            Amarillo.Size = new Size(192, 80);
            Amarillo.TabIndex = 4;
            Amarillo.Text = "Amarillo";
            Amarillo.UseVisualStyleBackColor = false;
            Amarillo.Click += Amarillo_Click;
            // 
            // Gris
            // 
            Gris.BackColor = Color.Lime;
            Gris.Location = new Point(103, 406);
            Gris.Margin = new Padding(3, 4, 3, 4);
            Gris.Name = "Gris";
            Gris.Size = new Size(192, 80);
            Gris.TabIndex = 5;
            Gris.Text = "Verde";
            Gris.UseVisualStyleBackColor = false;
            Gris.Click += Gris_Click;
            // 
            // Rosa
            // 
            Rosa.BackColor = Color.Pink;
            Rosa.Location = new Point(343, 406);
            Rosa.Margin = new Padding(3, 4, 3, 4);
            Rosa.Name = "Rosa";
            Rosa.Size = new Size(192, 80);
            Rosa.TabIndex = 6;
            Rosa.Text = "Rosa";
            Rosa.UseVisualStyleBackColor = false;
            Rosa.Click += Rosa_Click;
            // 
            // Azul
            // 
            Azul.BackColor = Color.Blue;
            Azul.Location = new Point(847, 292);
            Azul.Margin = new Padding(3, 4, 3, 4);
            Azul.Name = "Azul";
            Azul.Size = new Size(192, 80);
            Azul.TabIndex = 7;
            Azul.Text = "Azul";
            Azul.UseVisualStyleBackColor = false;
            Azul.Click += Azul_Click;
            // 
            // AtendidoCoche
            // 
            AtendidoCoche.Image = (Image)resources.GetObject("AtendidoCoche.Image");
            AtendidoCoche.Location = new Point(1, 544);
            AtendidoCoche.Margin = new Padding(3, 4, 3, 4);
            AtendidoCoche.Name = "AtendidoCoche";
            AtendidoCoche.Size = new Size(211, 143);
            AtendidoCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            AtendidoCoche.TabIndex = 11;
            AtendidoCoche.TabStop = false;
            // 
            // PrimerCoche
            // 
            PrimerCoche.Image = (Image)resources.GetObject("PrimerCoche.Image");
            PrimerCoche.Location = new Point(213, 544);
            PrimerCoche.Margin = new Padding(3, 4, 3, 4);
            PrimerCoche.Name = "PrimerCoche";
            PrimerCoche.Size = new Size(211, 143);
            PrimerCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            PrimerCoche.TabIndex = 12;
            PrimerCoche.TabStop = false;
            // 
            // SegundoCoche
            // 
            SegundoCoche.Image = (Image)resources.GetObject("SegundoCoche.Image");
            SegundoCoche.Location = new Point(424, 544);
            SegundoCoche.Margin = new Padding(3, 4, 3, 4);
            SegundoCoche.Name = "SegundoCoche";
            SegundoCoche.Size = new Size(211, 143);
            SegundoCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            SegundoCoche.TabIndex = 13;
            SegundoCoche.TabStop = false;
            // 
            // TercerCoche
            // 
            TercerCoche.Image = (Image)resources.GetObject("TercerCoche.Image");
            TercerCoche.Location = new Point(635, 544);
            TercerCoche.Margin = new Padding(3, 4, 3, 4);
            TercerCoche.Name = "TercerCoche";
            TercerCoche.Size = new Size(211, 143);
            TercerCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            TercerCoche.TabIndex = 14;
            TercerCoche.TabStop = false;
            // 
            // CuartoCoche
            // 
            CuartoCoche.Image = (Image)resources.GetObject("CuartoCoche.Image");
            CuartoCoche.Location = new Point(847, 544);
            CuartoCoche.Margin = new Padding(3, 4, 3, 4);
            CuartoCoche.Name = "CuartoCoche";
            CuartoCoche.Size = new Size(211, 143);
            CuartoCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            CuartoCoche.TabIndex = 15;
            CuartoCoche.TabStop = false;
            // 
            // QuintoCoche
            // 
            QuintoCoche.Image = (Image)resources.GetObject("QuintoCoche.Image");
            QuintoCoche.Location = new Point(1058, 544);
            QuintoCoche.Margin = new Padding(3, 4, 3, 4);
            QuintoCoche.Name = "QuintoCoche";
            QuintoCoche.Size = new Size(211, 143);
            QuintoCoche.SizeMode = PictureBoxSizeMode.StretchImage;
            QuintoCoche.TabIndex = 16;
            QuintoCoche.TabStop = false;
            // 
            // Atendido
            // 
            Atendido.AutoSize = true;
            Atendido.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Atendido.Location = new Point(40, 708);
            Atendido.Name = "Atendido";
            Atendido.Size = new Size(135, 36);
            Atendido.TabIndex = 17;
            Atendido.Text = "Atendido";
            // 
            // Primero
            // 
            Primero.AutoSize = true;
            Primero.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Primero.Location = new Point(249, 708);
            Primero.Name = "Primero";
            Primero.Size = new Size(118, 36);
            Primero.TabIndex = 18;
            Primero.Text = "Primero";
            // 
            // Segundo
            // 
            Segundo.AutoSize = true;
            Segundo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Segundo.Location = new Point(463, 708);
            Segundo.Name = "Segundo";
            Segundo.Size = new Size(136, 36);
            Segundo.TabIndex = 19;
            Segundo.Text = "Segundo";
            // 
            // Tercero
            // 
            Tercero.AutoSize = true;
            Tercero.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Tercero.Location = new Point(681, 708);
            Tercero.Name = "Tercero";
            Tercero.Size = new Size(117, 36);
            Tercero.TabIndex = 20;
            Tercero.Text = "Tercero";
            // 
            // Cuarto
            // 
            Cuarto.AutoSize = true;
            Cuarto.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Cuarto.Location = new Point(887, 708);
            Cuarto.Name = "Cuarto";
            Cuarto.Size = new Size(104, 36);
            Cuarto.TabIndex = 21;
            Cuarto.Text = "Cuarto";
            Cuarto.Click += Cuarto_Click;
            // 
            // Quinto
            // 
            Quinto.AutoSize = true;
            Quinto.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Quinto.Location = new Point(1073, 708);
            Quinto.Name = "Quinto";
            Quinto.Size = new Size(141, 36);
            Quinto.TabIndex = 22;
            Quinto.Text = "Enfilando";
            // 
            // Start
            // 
            Start.BackColor = Color.DarkGray;
            Start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Start.Location = new Point(40, 137);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(154, 74);
            Start.TabIndex = 23;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // RecordAct
            // 
            RecordAct.AutoSize = true;
            RecordAct.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RecordAct.Location = new Point(1073, 204);
            RecordAct.Name = "RecordAct";
            RecordAct.Size = new Size(34, 41);
            RecordAct.TabIndex = 27;
            RecordAct.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1000, 148);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 52);
            button1.TabIndex = 26;
            button1.Text = "Record:";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Naranja
            // 
            Naranja.BackColor = Color.Orange;
            Naranja.Location = new Point(606, 409);
            Naranja.Name = "Naranja";
            Naranja.Size = new Size(192, 77);
            Naranja.TabIndex = 28;
            Naranja.Text = "Naranja";
            Naranja.UseVisualStyleBackColor = false;
            Naranja.Click += Naranja_Click;
            // 
            // Morado
            // 
            Morado.BackColor = Color.BlueViolet;
            Morado.Location = new Point(853, 411);
            Morado.Name = "Morado";
            Morado.Size = new Size(192, 73);
            Morado.TabIndex = 29;
            Morado.Text = "Morado";
            Morado.UseVisualStyleBackColor = false;
            Morado.Click += Morado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1221, 871);
            Controls.Add(Morado);
            Controls.Add(Naranja);
            Controls.Add(RecordAct);
            Controls.Add(button1);
            Controls.Add(Start);
            Controls.Add(Quinto);
            Controls.Add(Cuarto);
            Controls.Add(Tercero);
            Controls.Add(Segundo);
            Controls.Add(Primero);
            Controls.Add(Atendido);
            Controls.Add(QuintoCoche);
            Controls.Add(CuartoCoche);
            Controls.Add(TercerCoche);
            Controls.Add(SegundoCoche);
            Controls.Add(PrimerCoche);
            Controls.Add(AtendidoCoche);
            Controls.Add(Azul);
            Controls.Add(Rosa);
            Controls.Add(Gris);
            Controls.Add(Amarillo);
            Controls.Add(Rojo);
            Controls.Add(label1);
            Controls.Add(Negro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AtendidoCoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimerCoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)SegundoCoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)TercerCoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)CuartoCoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuintoCoche).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Negro;
        private Label label1;
        private Button Rojo;
        private Button Amarillo;
        private Button Gris;
        private Button Rosa;
        private Button Azul;
        private PictureBox AtendidoCoche;
        private PictureBox PrimerCoche;
        private PictureBox SegundoCoche;
        private PictureBox TercerCoche;
        private PictureBox CuartoCoche;
        private PictureBox QuintoCoche;
        private Label Atendido;
        private Label Primero;
        private Label Segundo;
        private Label Tercero;
        private Label Cuarto;
        private Label Quinto;
        private Button Start;
        private Label RecordAct;
        private Button button1;
        private Button Naranja;
        private Button Morado;
    }
}