using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPrincipal
{
    class Ponentes
    {
        //Atributos
        string nombre;
        string nombrePonencia;
        //Constructor
        public Ponentes()
        {

        }
        //Métodos
        public void setPonente()
        {
            Console.WriteLine("\n----------------DATOS DEL PONENTE---------------");
            Console.Write("\nNombre del ponente: ");
            nombre = Console.ReadLine();
            Console.Write("\nNombre de la ponencia: ");
            nombrePonencia = Console.ReadLine();
        }

        public string getPonencia()
        {
            return nombrePonencia;
        }
    }
}
