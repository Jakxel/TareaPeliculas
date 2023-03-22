using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string pais;
        private string  director;

        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(){}
        public Pelicula(string titulo, Int16 año){this.titulo=titulo; this.año=año;}
        //Métodos
         public string GetTitulo(){return titulo;}
         public void SetTitulo(string t){titulo=t;}
         public Int16 GetAño(){return año;}
         public void SetAño(Int16 a){año=a;}
         public string GetPais(){return pais;}
         public void SetPais(string p){pais=p;}
         public string GetDirector(){return director;}
         public void SetDirector(string d){director=d;}
     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
     //     Console.WriteLine($"{titulo} ({año})");
        }


    }

    public class Actor
    {
        //Propiedades
        string Nombre;
        Int16 Año;

        //Constructores
        public Actor(){}
        public Actor(string Nombre, Int16 Año){this.Nombre=Nombre; this.Año=Año;}
        //Métodos 
        public string GetNombre(){return Nombre;}
        public void SetNombre(string nombre, string n) {nombre=n;}
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            pelicula.Add( new Pelicula("La ballena", 2022));
            pelicula.Add( new Pelicula("Todo en todas partes", 2022));
            pelicula.Add( new Pelicula("Pinocho", 2022));
            pelicula.Add( new Pelicula("Ant man", 2023));
            pelicula.Add( new Pelicula("La trinchera", 2022));

            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
