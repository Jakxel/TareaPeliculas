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
            Console.WriteLine($"{Nombre} ({Año})");
     //       Console.WriteLine($"{titulo} ({año})");
        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
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
           Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
