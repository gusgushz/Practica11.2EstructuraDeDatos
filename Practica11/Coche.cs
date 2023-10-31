using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11
{
    internal class Coche
    {
        public string Color { get; set; }
        public string Imagen { get; set; }
        private readonly string[] imagenes = new string[8] { "..\\..\\..\\imgCarNegro.jpg", "..\\..\\..\\imgCarRojo.jpg", "..\\..\\..\\imgCarAmarillo.jpg", "..\\..\\..\\imgCarVerde.jpg", "..\\..\\..\\imgCarRosa.jpg", "..\\..\\..\\imgCarAzul.jpg","..\\..\\..\\imgCarNaranja.jpg", "..\\..\\..\\imgCarMorado.jpg" };

        private readonly string[] colores = new string[8] { "Negro", "Rojo", "Amarillo", "Verde", "Rosa", "Azul","Naranja","Morado" };
        
        Random random = new Random();
        
        
        public Coche() 
        {
            int pos = random.Next(0, 8);
            Color = colores[pos];
            Imagen = imagenes[pos];
        }
    }
}
