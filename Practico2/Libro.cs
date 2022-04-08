using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    public class Libro
    {
        private int AnioPublicacion;
        private int CantidadDeVentas;
        private int IdAutor;
        private string Titulo;

        public Libro(string _Titulo, int _IdAutor, int _AnioPublicacion, int _CantidadDeVentas )
        {
            this.Titulo = _Titulo;
            this.IdAutor = _IdAutor;
            this.AnioPublicacion = _AnioPublicacion;
            this.CantidadDeVentas = _CantidadDeVentas;
            
            
        }
        public void setTitulo(string _Titulo)
        {
            this.Titulo = _Titulo;
        }
        public string getTitulo()
        {
            return this.Titulo;
        }
        public void setIdAutor(int _IdAutor)
        {
            this.IdAutor = _IdAutor;
        }
        public int getIdAutor()
        {
            return this.IdAutor;
        }

        public void setAnioPublicacion(int _AnioPublicacion)
        {
            this.AnioPublicacion = _AnioPublicacion;
        }
        public int getAnioPublicacion()
        {
            return this.AnioPublicacion;
        }
        public void setCantidadDeVentas(int _CantidadDeVentas)
        {
            this.CantidadDeVentas = _CantidadDeVentas;
        }
        public int getCantidadDeVentas()
        {
            return this.CantidadDeVentas;
        }
       

        public static List<Libro> Libros()
        {
            return new List<Libro>
            {
                new Libro("Don Quijote de la Mancha", 1 , 1605, 500),
                new Libro("Historia de dos ciudades", 2 , 1859, 200),
                new Libro("El señor de los anillos", 3 , 1978, 150),
                new Libro("El principito", 4 , 1951, 140),
                new Libro("El hobbit", 3 , 1982, 100),
                new Libro("Sueño en el pabellon rojo", 5 , 1792, 100),
                new Libro("Las acenturas de alicia en el pais de las maravillas", 6 , 1865, 100),
                new Libro("Diez negritos", 7 , 1939, 100),
                new Libro("El leon la bruja y el armario", 8 , 1950, 85),
                new Libro("El codigo Da Vinci", 9 , 2003, 80),
                new Libro("El guardian entre el centeno", 10 , 1951, 65),
                new Libro("El alquimista", 11 , 1988, 65),
            };
        }
    }
}
