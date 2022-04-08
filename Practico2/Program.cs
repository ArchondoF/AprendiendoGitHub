using System;
using System.Collections.Generic;
using System.Linq;

namespace Practico2
{
     class Program
    {
        static void Main(string[] args)
        {
            /*Creamos lista y randomizador*/
            List<int> numerosAleatorios = new List<int>();
            Random randomizador = new Random();
            /*Llenamos lista*/
            for (int i = 1; i < 100; i++)
            {
                var numeroAleatorio = randomizador.Next(1, 101);
                numerosAleatorios.Add(numeroAleatorio);
            }
            /*Arrancamos Practico pd: tengo 1500 horas en el cs go*/
            /*A Mostrar el primero de la collecion */
            Console.WriteLine(numerosAleatorios.First());

            /*B Mostrar el ultimo de la collecion */
            Console.WriteLine(numerosAleatorios.Last());

            /*C Mostrar en consola todos los divisibles entre 3*/
            List<int> divisiblesEntreTres = numerosAleatorios.Where(valor => valor % 3 == 0).ToList();
            foreach (int numero in divisiblesEntreTres)
            {
                Console.WriteLine(numero);
            }

            /*D Mostrar en consola la suma de todos los elementos*/
            Console.WriteLine("La suma de los elementos es: " + numerosAleatorios.Sum());


            /*E Mostrar en consola el numero mas grande*/
            Console.WriteLine(numerosAleatorios.Max());

            /*F Mostrar en cosnola el numero mas pequeño*/
            Console.WriteLine(numerosAleatorios.Min());

            /*G Generar y mostrar una nueva lista con el cuadrado de los numeros*/

            var cuadradosDeNumeros = numerosAleatorios.Select(numero => numero * numero).ToList();

            /*H Generar y mostrar una nueva lista con los numeros mayores a 50*/
            List<int> listaMayoresA50 = numerosAleatorios.Where(numero => numero > 50).ToList();
            foreach (int numero in listaMayoresA50)
            {
                Console.WriteLine(numero);
            }

            /*I Obtener y mostrar el promedio de todos los numeros mayores a 50*/
            int promedioMayoresA50 = listaMayoresA50.Sum() / listaMayoresA50.Count;
            Console.WriteLine("El promedio de los numeros mayores a 50 es: " + promedioMayoresA50);

            /*J Mostrar en consola los elementos en forma descendiente*/
            List<int> colNumerosDescendiente = numerosAleatorios.OrderByDescending(numero => numero).ToList();
            foreach (int numero in colNumerosDescendiente)
            {
                Console.WriteLine(numero);
                /*Coso par aprobar el feacture*/
            }
             
            /*K Mostrar los numeros de forma ascendente*/
            List<int> colNumerosAscendente = numerosAleatorios.OrderBy(numero => numero).ToList();
            foreach (int numero in colNumerosAscendente)
            {
                Console.WriteLine(numero);
            }

            /*L Mostrar en consola los numeros de la coleccion sin repetirlos*/
            List<int> colNumerosUnicos = numerosAleatorios.Distinct().ToList();
            foreach (int numero in colNumerosUnicos)
            {
                Console.WriteLine(numero);
            }

            /*M Sumar y mostrar todos los numeros unicos en la lista*/
            int sumaNumerosUnicos = colNumerosUnicos.Sum();
            foreach (int numero in colNumerosUnicos)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("La suma de los numeros unicos es: " + sumaNumerosUnicos);


            /*N Mostrar en consola (SI/NO) si el numero  esta presente*/
            var numeroCincuentaPresente = numerosAleatorios.Any(numero => numero == 50);
            Console.WriteLine(numeroCincuentaPresente ? "SI" : "NO");



            /*O Mostrar em consola los primeros 33 numeros*/
            var primeros33Numeros = numerosAleatorios.Take(33);


            /*P Mostrar en consola los ultimos 20 numeros de la coleccion*/
            var ultimos20Numeros = numerosAleatorios.TakeLast(20);


            /*Q Mostrar en consola (SI/NO) si todos los numeros son mayores a 1*/
            bool SonMayoresAuno = numerosAleatorios.All(numero => numero > 1);
            Console.WriteLine(SonMayoresAuno ? "SI" : "NO");

            /*R Mostrar en consola el numero y la cantidad de veces que este se encuentra en la lista*/

            var grupoNumerosIguales =
            from numero in numerosAleatorios
            group numero by numero into newGroup
            orderby newGroup.Key
            select newGroup;

            Console.WriteLine("Arranca la magia");

            foreach (var Grupo in grupoNumerosIguales)
            {
                Console.WriteLine($"El numero: {Grupo.Key} se repite: {Grupo.Count()}");
            }

            /*LADO B (objetos)*/
            List<Alumno> colAlumnos = new List<Alumno>();
            colAlumnos.Add(new Alumno(20, "Eva", 6));
            colAlumnos.Add(new Alumno(18, "Ana", 7));
            colAlumnos.Add(new Alumno(22, "Rosa", 5));
            colAlumnos.Add(new Alumno(30, "Ricardo", 9));
            colAlumnos.Add(new Alumno(45, "Felipe", 2));
            colAlumnos.Add(new Alumno(19, "Pepe", 3));
            colAlumnos.Add(new Alumno(26, "Laia", 10));
            colAlumnos.Add(new Alumno(33, "Stephanie", 6));
            colAlumnos.Add(new Alumno(50, "Agustin", 7));
            colAlumnos.Add(new Alumno(31, "Mauricio", 12));


            /*A El alumno con la nota mas alta*/

            var alumnoMejor = colAlumnos.Where(x => x.getNota() == colAlumnos.Max(y => y.getNota())).FirstOrDefault();
            Console.WriteLine("El alumno por excelencia es:" + alumnoMejor.getNombre());

            /*B El alumno mas joven*/
            var alumnoMasJoven = colAlumnos.Where(x => x.getEdad() == colAlumnos.Min(y => y.getEdad())).FirstOrDefault();
            Console.WriteLine("El alumno mas joven es:" + alumnoMasJoven.getNombre());

            /*C El promedio de edad de los alumnos*/
            Console.WriteLine("Promedio" + colAlumnos.Average(alumnos => alumnos.getEdad()));


            /*D Mostrar si existe al menos algun alumno que reprueba*/
            bool reprobador = colAlumnos.Any(alumnos => alumnos.getNota() < 6);
            if (reprobador)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            /*E los alumnos que han aprobado mayores de 30 años*/
            var nombreAlumnosAprobadosMayores = colAlumnos.Where(x => x.getEdad() > 30 && x.getNota() >= 6).ToList();
            Console.WriteLine("A continuacion los alumnos aprobados y mayores de 30 años");
            for (int i = 0; i < nombreAlumnosAprobadosMayores.Count; i++)
            {
                Console.WriteLine("Estudiante " + nombreAlumnosAprobadosMayores[i].getNombre());
            }

            /*F Alumnos agrupados por Aprobado/Suspendido*/

            var grupoAprobados =
            from alumno in colAlumnos
            group alumno by alumno.getNota() >= 6 into aprobados
            select aprobados;

            foreach (var Grupo in grupoAprobados)
            {
                Console.WriteLine($"Aprobado: {Grupo.Key} ");
                foreach (Alumno aux in Grupo)
                {
                    Console.WriteLine("Alumno: " + aux.getNombre() + " Nota: " + aux.getNota());
                }

            }

            /*G. Los alumnos ordenados según el largo de su nombre, de mayor a menor*/

            List<Alumno> colAlumnosOrdenados = colAlumnos.OrderByDescending(x => x.getNombre().Count()).ToList();
            Console.WriteLine("Alumnos Ordenados");
            foreach (Alumno aux in colAlumnosOrdenados)
            {
                Console.WriteLine(aux.getNombre());
            }

            /*H. Alumnos agrupados por la longitud de su nombre, donde la suma de sus
            edades sea mayor a 60.*/
            var alumnosAgrupadosPorLongitudConSumaMas60 = colAlumnos.GroupBy(alumno => alumno.getNombre().Count()).Where(grupoAlumnos => grupoAlumnos.Sum(alumno => alumno.getEdad()) > 60).ToList();
            foreach (var aux in alumnosAgrupadosPorLongitudConSumaMas60)
            {
                Console.WriteLine(aux.Count());
            }

            /*I. Un único listado de alumnos ordenado de forma ascendente por el largo de
            su nombre y de forma descendiente por su edad.*/

            List<Alumno> colAlumnosSuperOrdenados = colAlumnos.OrderBy(x => x.getNombre().Length).ThenByDescending(x => x.getEdad()).ToList();
            Console.WriteLine("Alumnos Super Ordenados");
            foreach (Alumno aux in colAlumnosSuperOrdenados)
            {
                Console.WriteLine(aux.getNombre());
            }





            /*LADO C*/
            List<Autor> colAutores = Autor.Autores();
            List<Libro> colLibro = Libro.Libros();
            /*A. Mostrar en consola los 3 libros con más ventas.*/
            List<Libro> colLibrosMasVendidos = colLibro.OrderByDescending(x => x.getCantidadDeVentas()).Take(3).ToList();
            Console.WriteLine("Libros mas vendidos");
            foreach (Libro aux in colLibrosMasVendidos)
            {
                Console.WriteLine(aux.getTitulo());
            }

            /*B. Mostrar en consola los 3 libros con menos ventas.*/
            List<Libro> colLibrosMenosVendidos = colLibro.OrderBy(x => x.getCantidadDeVentas()).Take(3).ToList();
            Console.WriteLine("Libros menos vendidos");
            foreach (Libro aux in colLibrosMenosVendidos)
            {
                Console.WriteLine(aux.getTitulo());
            }

            /*C. Mostrar en consola los libros publicados hace menos de 50 años.*/
            var fechaActual = DateTime.Now.Year;
            List<Libro> colLibrosPublicadosMenos50 = colLibro.Where(x => fechaActual - x.getAnioPublicacion() <= 50).ToList();
            Console.WriteLine("Libros de hace menos de 50 años");
            foreach (Libro aux in colLibrosPublicadosMenos50)
            {
                Console.WriteLine(aux.getTitulo());
            }

            /*D. Mostrar en consola el libro más viejo.*/
            var libroMasViejo = colLibro.Where(x => x.getAnioPublicacion() == colLibro.Min(y => y.getAnioPublicacion())).FirstOrDefault();
            Console.WriteLine("El libro mas viejo es :" + libroMasViejo.getTitulo());



            /*JOIN*/

            var ListaAutoresLibros = colLibro.Join(colAutores,
                                                                            libro => libro.getIdAutor(),
                                                                            autor => autor.getIdAutor(),
                                                                            (libro, autor) => new { NombreAutor = autor.getNombre(), CantidadDeVentas = libro.getCantidadDeVentas(), TituloLibro = libro.getTitulo() }).ToList();

            /*E. Mostrar en consola los autores que tengan un libro que comience con "El".*/

            var AutoresConLibrosEl = ListaAutoresLibros.Where(autorConLibro => autorConLibro.TituloLibro.StartsWith("El"))
                                    .Select(autor => autor.NombreAutor)
                                    .Distinct()
                                    .ToList();
            Console.WriteLine("Los autores que tienen un libro que comiencen con EL son:");
            foreach (var autoresConLibrosEl in AutoresConLibrosEl)
            {
                Console.WriteLine(autoresConLibrosEl);
            }

            /*F. Mostrar en consola el autor con más libros publicados.*/

            var AutorConMasLibros = ListaAutoresLibros.GroupBy(x => x.NombreAutor).OrderByDescending(x => x.Count()).FirstOrDefault();
            Console.WriteLine("El autor con mas libros: " + AutorConMasLibros.Key);
            /*G. Mostrar en consola el autor y la cantidad de libros publicados.*/

            var autoresConSusLibros = ListaAutoresLibros.GroupBy(x => x.NombreAutor);
            foreach (var aux in autoresConSusLibros)
            {

                Console.WriteLine("El autor: " + aux.Key+ "Tiene libros : "+ aux.Count() );
   
            }
            





        }
    }
}
