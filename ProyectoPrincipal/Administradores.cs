using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPrincipal
{
    class Administradores
    {

        //Atributos
        string nombre;
        int numTrabajador;
        string dependencia; //o empresa
        string usuario;
        string contrasena;
        string correo;
        string celular;
        int[] idsHorarios = new int[6];
        string[] validacionE = new string[9] { "Office Depot", "HiperLumen", "Epson", "HP", "Lenovo", "Dell", "Asus", "TP-Link", "Cisco" };
        int nivelDeAcceso;
        string aux;
        
        //Constructor
        public Administradores(string n, int nT, string d, string u, string c, string cc, string cel, int a)
        {
            nombre = n;
            numTrabajador = nT;
            dependencia = d;
            usuario = u;
            contrasena = c;
            correo = cc;
            celular = cel;
            nivelDeAcceso = a;
        }

        //Métodos
        public int altaUsuario(int opc) //editar
        {
            
            if(opc == 2) //admin = 2, empresa = 3
            {
                Console.Write("\nNombre de la dependencia: ");
                dependencia = Console.ReadLine();
                nivelDeAcceso = 2;
            }
            else
            {
                Console.Write("\nNombre de la empresa: ");
                aux = Console.ReadLine();

                Console.Write("\nValidando empresa");
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);

                for (int i = 0; i < 9; i++)
                {
                    if (aux == validacionE[i])
                    {
                        Console.Clear();
                        dependencia = aux;
                        Console.WriteLine("\n-------------DATOS DEL REPRESENTANTE------------");
                        nivelDeAcceso = 3;
                        break;

                    }
                    else
                    {
                        if( i == 8)
                        {
                            Console.Write("\n\nNo puede registrar esa empresa, presione enter para continuar...");
                            Console.ReadLine();
                            return -1;
                        }
                        
                    }
                }
            }

            Console.Write("\nNombre completo: ");
            nombre = Console.ReadLine();
            Console.Write("\nEmail: ");
            correo = Console.ReadLine();
            Console.Write("\nCelular: ");
            celular = Console.ReadLine();
            Console.Write("\nCree un usuario: ");
            usuario = Console.ReadLine();
            Console.Write("\nCree una contraseña: ");
            contrasena = Console.ReadLine();

            Console.Write("\n\nGuardando datos");
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            return 1;
        }

        public string getNombreEmpresa()
        {
            return dependencia;
        }

        public string getUsuario()
        {
            return usuario;
        }
        public string getContrasena()
        {
            return contrasena;
        }

        public int getNivel()
        {
            return nivelDeAcceso;
        }

        public void setNumTrabajador(int num)
        {
            numTrabajador = num;
        }
       
    }
}
