using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Practica11
{
    public partial class Form1 : Form
    {
        private Queue<Coche> filaCoches;
        private readonly string[] imagenes = new string[8] { "..\\..\\..\\imgCarNegro.jpg", "..\\..\\..\\imgCarRojo.jpg", "..\\..\\..\\imgCarAmarillo.jpg", "..\\..\\..\\imgCarVerde.jpg", "..\\..\\..\\imgCarRosa.jpg", "..\\..\\..\\imgCarAzul.jpg", "..\\..\\..\\imgCarNaranja.jpg", "..\\..\\..\\imgCarMorado.jpg" };
        private int recordActual = 0;
        private int segundos = 1500;
        private int aciertos = 0;
        public string ColorSelec { get; set; } = "";

        public Form1()
        {
            filaCoches = new Queue<Coche>();
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            filaCoches = new Queue<Coche>();
            recordActual = 0;
            aciertos = 0;
            AtendidoCoche.Visible = false;
            Iniciar();
        }

        private void Iniciar()
        {
            PrimerCoche.Visible = false;
            Primero.Visible = false;
            SegundoCoche.Visible = false;
            Segundo.Visible = false;
            TercerCoche.Visible = false;
            Tercero.Visible = false;
            CuartoCoche.Visible = false;
            Cuarto.Visible = false;
            ComprobarColor();
        }

        private async Task ComprobarColor()
        {
            while (filaCoches.Count < 5)
            {
                // Pausa para que el usuario elija el color
                await Task.Delay(segundos);
                Coche CocheNuevo = new Coche();
                if (filaCoches.Count > 0 && ColorSelec == filaCoches.Peek().Color)
                {
                    Coche atendido = filaCoches.Dequeue();
                    AtendidoCoche.Visible = true;
                    AtendidoCoche.Image = Image.FromFile(atendido.Imagen);
                    PrimerCoche.Visible = false;
                    Primero.Visible = false;
                    recordActual++;
                    RecordAct.Text = recordActual.ToString();
                    aciertos++;
                    segundos -= 20;
                }
                else
                {
                    filaCoches.Enqueue(CocheNuevo);
                }

                if (filaCoches.Count == 1)
                {
                    PrimerCoche.Visible = true;
                    SegundoCoche.Visible = false;
                    TercerCoche.Visible = false;
                    CuartoCoche.Visible = false;
                    Primero.Visible = true;
                    Segundo.Visible = false;
                    Tercero.Visible = false;
                    Cuarto.Visible = false;
                    Primero.Text = filaCoches.Peek().Color;
                }
                else if (filaCoches.Count == 2)
                {
                    PrimerCoche.Visible = true;
                    SegundoCoche.Visible = true;
                    TercerCoche.Visible = false;
                    CuartoCoche.Visible = false;
                    Primero.Visible = true;
                    Segundo.Visible = true;
                    Tercero.Visible = false;
                    Cuarto.Visible = false;
                    Primero.Text = filaCoches.Peek().Color;
                    Segundo.Text = filaCoches.ElementAt(1).Color;
                }
                else if (filaCoches.Count == 3)
                {
                    PrimerCoche.Visible = true;
                    SegundoCoche.Visible = true;
                    TercerCoche.Visible = true;
                    CuartoCoche.Visible = false;
                    Primero.Visible = true;
                    Segundo.Visible = true;
                    Tercero.Visible = true;
                    Cuarto.Visible = false;
                    Primero.Text = filaCoches.Peek().Color;
                    Segundo.Text = filaCoches.ElementAt(1).Color;
                    Tercero.Text = filaCoches.ElementAt(2).Color;
                }
                else if (filaCoches.Count == 4)
                {
                    PrimerCoche.Visible = true;
                    SegundoCoche.Visible = true;
                    TercerCoche.Visible = true;
                    CuartoCoche.Visible = true;
                    Primero.Visible = true;
                    Segundo.Visible = true;
                    Tercero.Visible = true;
                    Cuarto.Visible = true;
                    Primero.Text = filaCoches.Peek().Color;
                    Segundo.Text = filaCoches.ElementAt(1).Color;
                    Tercero.Text = filaCoches.ElementAt(2).Color;
                    Cuarto.Text = filaCoches.ElementAt(3).Color;
                }
            }

            if (filaCoches.Count == 5)
            {
                MessageBox.Show("Has perdido");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cuarto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void AtendidoCoche_Click(object sender, EventArgs e)
        {
            AtendidoCoche.Image = Image.FromFile(@"..\..\..\imgBlanco.jpg");
        }

        private void Negro_Click(object sender, EventArgs e)
        {
            ColorSelec = "Negro";
            PrimerCoche.Image = Image.FromFile(imagenes[0]);
        }
        private void Rojo_Click(object sender, EventArgs e)
        {
            ColorSelec = "Rojo";
            PrimerCoche.Image = Image.FromFile(imagenes[1]);
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            ColorSelec = "Amarillo";
            PrimerCoche.Image = Image.FromFile(imagenes[2]);
        }

        private void Gris_Click(object sender, EventArgs e)
        {
            ColorSelec = "Verde";
            PrimerCoche.Image = Image.FromFile(imagenes[3]);
        }

        private void Rosa_Click(object sender, EventArgs e)
        {
            ColorSelec = "Rosa";
            PrimerCoche.Image = Image.FromFile(imagenes[4]);
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            ColorSelec = "Azul";
            PrimerCoche.Image = Image.FromFile(imagenes[5]);
        }

        private void Naranja_Click(object sender, EventArgs e)
        {
            ColorSelec = "Naranja";
            PrimerCoche.Image = Image.FromFile(imagenes[6]);
        }

        private void Morado_Click(object sender, EventArgs e)
        {
            ColorSelec = "Morado";
            PrimerCoche.Image = Image.FromFile(imagenes[7]);
        }
    }
}