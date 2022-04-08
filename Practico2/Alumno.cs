using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    public class Alumno
    {
        private int Edad;
        private string Nombre;
        private int Nota;

        public Alumno(int _Edad, string _Nombre, int _Nota) 
        {
            this.Edad = _Edad;
            this.Nombre = _Nombre;
            this.Nota = _Nota;
        }

        public int getEdad() 
        {
            return this.Edad;
        }
        public void setEdad(int _Edad)
        {
            this.Edad = _Edad;
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }
        public int getNota()
        {
            return this.Nota;
        }
        public void setNota(int _Nota)
        {
            this.Nota = _Nota;
        }
    }
}
