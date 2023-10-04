using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ProyectoPrincipal
{
    class Horarios
    {
        //Atributos
        int ID;
        int numSala;
        string Horario;
        string nombreEmpresa;
        string nombrePonencia;
        string estado;
        string aux;
        

        

        //Constructor

        public Horarios(int id, int sala, string horario)
        {
            ID = id;
            numSala = sala;
            Horario = horario;
            estado = "Disponible";
        }

        //Métodos
        public void reservarHorario(string nomEmp, string nomPon)
        {
            nombreEmpresa = nomEmp;
            nombrePonencia = nomPon;
            estado = "No disponible";
        }

        public void verHorario()
        {
            Console.Write("ID: "+ ID);
            Console.Write("\nEmpresa: "+nombreEmpresa);
            Console.Write("\nNombre de la ponencia: " + nombrePonencia);
            Console.Write("\nNúmero de sala: " + numSala);
            if (numSala == 1 || numSala == 5)
            {
                Console.Write("\nAforo maximo: 100");
            }
            else if(numSala == 2 || numSala == 3)
            {
                Console.Write("\nAforo maximo: 50");
            }
            else
            {
                Console.Write("\nAforo maximo: 75");
            }
            Console.Write("\nHorario: " + Horario);
            Console.Write("\nEstado: " + estado + "\n");
        }

        public string getEstado()
        {
            return estado;
        }
        public string getNombreEmpresa()
        {
            return nombreEmpresa;
        }

        public string DescargarHorario()
        {
            Console.Write("ID: " + ID);
            Console.Write("\nEmpresa: " + nombreEmpresa);
            Console.Write("\nNombre de la ponencia: " + nombrePonencia);
            Console.Write("\nNúmero de sala: " + numSala);
            if (numSala == 1 || numSala == 5)
            {
                Console.Write("\nAforo maximo: 100");
            }
            else if (numSala == 2 || numSala == 3)
            {
                Console.Write("\nAforo maximo: 50");
            }
            else
            {
                Console.Write("\nAforo maximo: 75");
            }
            Console.Write("\nHorario: " + Horario);
            Console.Write("\nEstado: " + estado + "\n\n");

            
            if (numSala == 1 || numSala == 5)
            {
                aux = ("ID: " + ID + "\nEmpresa: " + nombreEmpresa + "\nNombre de la ponencia: " + nombrePonencia + "\nNúmero de sala: " + numSala+ "\nAforo maximo: 100"+ "\nHorario: " + Horario+
                                    "\nEstado: " + estado + "\n\n");
            }
            else if (numSala == 2 || numSala == 3)
            {
                aux = ("ID: " + ID + "\nEmpresa: " + nombreEmpresa + "\nNombre de la ponencia: " + nombrePonencia + "\nNúmero de sala: " + numSala + "\nAforo maximo: 50" + "\nHorario: " + Horario +
                                    "\nEstado: " + estado + "\n\n");
            }
            else
            {
                aux = ("ID: " + ID + "\nEmpresa: " + nombreEmpresa + "\nNombre de la ponencia: " + nombrePonencia + "\nNúmero de sala: " + numSala + "\nAforo maximo: 75" + "\nHorario: " + Horario +
                                    "\nEstado: " + estado + "\n\n");
            }

            return aux;
        }
    }
}
