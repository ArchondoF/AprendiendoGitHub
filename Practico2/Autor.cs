using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    public class Autor
    {
        private int IdAutor;
        private string Nombre;

        public Autor(int _IdAutor, string _Nombre)
        {
            this.IdAutor = _IdAutor;
            this.Nombre = _Nombre;
        }

        public void setIdAutor(int _IdAutor)
        {
            this.IdAutor = _IdAutor;
        }
        public int getIdAutor()
        {
            return this.IdAutor;
        }
        public void setNombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }
        public string getNombre()
        {
            return this.Nombre;
        }

        public static List<Autor> Autores()
        {
            return new List<Autor>
            {
                new Autor(1 , "Miguel de Cervantes"),
                new Autor(2 , "Charles Dickens"),
                new Autor(3 , "J. R. R. Tolkien"),
                new Autor(4 , "Antoine de Saint-Exupery"),
                new Autor(5 , "Cao Xueqin"),
                new Autor(6 , "Lewis Car"),
                new Autor(7 , "Agatha Christie"),
                new Autor(8 , " C. S. Lewis"),
                new Autor(9 , "Dan Brown"),
                new Autor(10 , "J. D. Salinger"),
            };
        }
    }
}
