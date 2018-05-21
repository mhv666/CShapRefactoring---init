using System;
using CShapRefactoring;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapRefactoring
{ 
    public class Cliente
    {
        private string nombre;
        List<Renta> rentas = new List<Renta>();

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void addRenta(Renta renta)
        {
            rentas.Add(renta);
        }

        public string emitirReciboRenta()
        {
            double montoTotal = 0;
            int puntosClienteFrecuente = 0;
            StringBuilder resultado = new StringBuilder();
            resultado.Append("Rentas del Cliente: " + getNombre() + "\n");

            foreach (Renta pelicula in rentas)
            {
                double monto;

                // Calcula el monto de cada linea
                monto = calcMonto(pelicula);

                // Agregar puntos de cliente frecuente
                puntosClienteFrecuente++;

                // Agregar bono por renta de dos días en películas de estreno
                puntosClienteFrecuente = calcPuntos(puntosClienteFrecuente, pelicula);

                // Muestra detalle de la renta
                resultado.Append("\t" + pelicula.getPelicula().getTitulo() + "\t" + monto + "\n");
                montoTotal += monto;
            }

            // Agregar totales
            resultado.Append("Cantidad a pagar: " + montoTotal + "\n");
            resultado.Append("Has acumulado " + puntosClienteFrecuente + " puntos adicionales a tu cuenta.");

            return resultado.ToString();
        }

        private static int calcPuntos(int puntosClienteFrecuente, Renta pelicula)
        {
            if ((pelicula.getPelicula().getTipo() == Pelicula.ESTRENO) && pelicula.getDiasRentada() > 1)
            {
                puntosClienteFrecuente++;
            }

            return puntosClienteFrecuente;
        }

        private static double calcMonto(Renta pelicula)
        {
            double monto = 0;
            switch (pelicula.getPelicula().getTipo())
            {

                case Pelicula.CATALOGO:
                    monto += 2;
                    if (pelicula.getDiasRentada() > 2)
                    {
                        monto += (pelicula.getDiasRentada() - 2) * 1.5;
                    }
                    break;
                case Pelicula.ESTRENO:
                    monto += pelicula.getDiasRentada() * 3;
                    break;
                case Pelicula.INFANTIL:
                    monto += 1.5;
                    if (pelicula.getDiasRentada() > 3)
                    {
                        monto += (pelicula.getDiasRentada() - 3) * 1.5;
                    }
                    break;
                default:
                    break;
            }

            return monto;
        }
    }
}

