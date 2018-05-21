using System;
using CShapRefactoring;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapRefactoring
{
    public class Pelicula
    {
        public const int CATALOGO = 0;
        public const int ESTRENO = 1;
        public const int INFANTIL = 2;

        private string titulo;
        private int tipo;

        public Pelicula(string titulo, int tipo)
        {
            setTitulo(titulo);
            setTipo(tipo);
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public int getTipo()
        {
            return this.tipo;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }
    }
}
