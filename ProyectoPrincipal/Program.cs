using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProyectoPrincipal
{
    class Program
    {
               
        static void Main(string[] args)
        {
            //Variables necesarias
            char dsn;
            char opcion;
            int auxNa = 0;
            int auxCa = 0;
            int auxNd = 0;
            string usuario, contrasena;
            int numAdmins = 2, numEmpresas = 0;
            int numTrabajador = 3;

            //Instancia de objetos horaro
            Horarios[,] horarios = new Horarios[3,6];
            horarios[0,0] = new Horarios(1, 2, "12 - 2");
            horarios[0,1] = new Horarios(2, 2, "5 - 7");
            horarios[0,2] = new Horarios(3, 3, "2:10 - 3:30");
            horarios[0,3] = new Horarios(4, 3, "5 - 7");
            horarios[0,4] = new Horarios(5, 4, "9 - 10");
            horarios[0,5] = new Horarios(6, 4, "12 - 2");

            horarios[1, 0] = new Horarios(1, 2, "12 - 2");
            horarios[1, 1] = new Horarios(2, 2, "5 - 7");
            horarios[1, 2] = new Horarios(3, 3, "2:10 - 3:30");
            horarios[1, 3] = new Horarios(4, 3, "5 - 7");
            horarios[1, 4] = new Horarios(5, 4, "9 - 10");
            horarios[1, 5] = new Horarios(6, 4, "12 - 2");

            horarios[2, 0] = new Horarios(1, 2, "12 - 2");
            horarios[2, 1] = new Horarios(2, 2, "5 - 7");
            horarios[2, 2] = new Horarios(3, 3, "2:10 - 3:30");
            horarios[2, 3] = new Horarios(4, 3, "5 - 7");
            horarios[2, 4] = new Horarios(5, 4, "9 - 10");
            horarios[2, 5] = new Horarios(6, 4, "12 - 2");

            //Validacion de empresas
            string[] validacionE = new string[9] {"Office Depot", "HiperLumen", "Epson", "HP", "Lenovo", "Dell", "Asus", "TP-Link", "Cisco" };

            //Intancia de admisitradores
            Administradores [] Admin = new Administradores[6];

            Admin[0] = new Administradores("Abelardo", 1, "CEO eventos", "CECAdmon", "C3C&2116unam_4d00ñ", "abelardoceo@unam.edu", "5565148565", 1);
            Admin[1] = new Administradores("Beto", 2, "Asistente eventos", "CECBeto", "1234","beto_asistente@unam.edu", "5565432132", 2);
            Admin[2] = new Administradores("Carlos", 3, "Suplente de Asistente eventos", "CECCarlos", "c0ntraseña","carlos_suplente@unam.edu", "5566879123", 2);
            Admin[3] = new Administradores("", -1, "", "", "", "", "", -1);
            Admin[4] = new Administradores("", -1, "", "", "", "", "", -1);
            Admin[5] = new Administradores("", -1, "", "", "", "", "", -1);

            //Intancia de ponente
            Ponentes ponente = new Ponentes();

            //Instancia de empresas
            Administradores [] Empresa = new Administradores[6];
            Empresa[0] = new Administradores("", -1, "", "", "", "", "", -1);
            Empresa[1] = new Administradores("", -1, "", "", "", "", "", -1);
            Empresa[2] = new Administradores("", -1, "", "", "", "", "", -1);
            Empresa[3] = new Administradores("", -1, "", "", "", "", "", -1);
            Empresa[4] = new Administradores("", -1, "", "", "", "", "", -1);
            Empresa[5] = new Administradores("", -1, "", "", "", "", "", -1);



            //Inicio del programa
            try
            {
                do
                {
                    Console.WriteLine("------------------------------------------------" +
                                      "\n       BIENVENIDO AL SISTEMA DE EVENTOS\n" +
                                      "------------------------------------------------");
                    Console.Write("\nSeleccione una opción:\n" +
                                  "1.- Inicio de sesión.\n" +
                                  "2.- Registro de empresa.\n" +
                                  "3.- Acerca de...\n" +
                                  "0.- Salir\n\n" +
                                  "Opción: ");
                    dsn = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    switch (dsn)
                    {
                        case '1':
                            auxNa = -1;
                            auxCa = -1;
                            Console.WriteLine("------------------------------------------------" +
                                              "\n                INICIO DE SESIÓN\n" +
                                              "------------------------------------------------");
                            Console.Write("\nUsuario: ");
                            usuario = Console.ReadLine();
                            Console.Write("\nContraseña: ");
                            contrasena = Console.ReadLine();

                            for (int i = 0; i <= numAdmins; i++)
                            {
                                if (Admin[i].getUsuario() == usuario && Admin[i].getContrasena() == contrasena)
                                {
                                    auxNa = Admin[i].getNivel();
                                }
                            }

                            for (int i = 0; i <= numEmpresas; i++)
                            {
                                if (Empresa[i].getUsuario() == usuario && Empresa[i].getContrasena() == contrasena)
                                {
                                    auxNa = Empresa[i].getNivel();
                                    auxCa = i;
                                }
                            }
                            Console.Clear();

                            if (auxNa == 1 || auxNa == 2)   //Si existe el usuario, entra al menu de Admins
                            {
                                do
                                {
                                    Console.WriteLine("------------------------------------------------" +
                                                      "\n           BIENVENIDO ADMINISTRADOR\n" +
                                                      "------------------------------------------------");

                                    Console.Write("\nSeleccione una opción:\n" +
                                                  "1.- Ver horarios completos.\n" +
                                                  "2.- Ver horarios libres.\n" +
                                                  "3.- Publicar/Descargar horario\n" +
                                                  "4.- Alta empresa\n" +
                                                  "5.- Editar empresa.\n" +
                                                  "6.- Asignar horarios.\n" +
                                                  "7.- Ver usuarios\n");
                                    if (auxNa == 1)
                                    {
                                        Console.Write("8.- Dar de alta administrador\n" +
                                                      "9.- Eliminar administrador\n");
                                    }
                                    Console.Write("0.- Cerrar sesión\n\n" +
                                                  "Opción: ");
                                    dsn = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();

                                    switch (dsn)
                                    {
                                        case '1':
                                            //Ver horarios completos
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n                  HORARIOS\n" +
                                                              "------------------------------------------------");
                                            for (int j = 0; j < 3; j++)
                                            {
                                                if (j == 0) 
                                                {
                                                    Console.WriteLine("------Martes 7 de diciembre------");
                                                }
                                                else if (j == 1)
                                                {
                                                    Console.WriteLine("------Miercoles 8 de diciembre------");
                                                }
                                                else if (j == 2)
                                                {
                                                    Console.WriteLine("------Jueves 9 de diciembre------");
                                                }

                                                for (int i = 0; i < 6; i++)
                                                {
                                                    horarios[j,i].verHorario();
                                                    Console.WriteLine();
                                                }
                                            }
                                            Console.Write("Presione enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                        case '2':
                                            //Ver horarios disponible
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n             HORARIOS DISPONIBLES\n" +
                                                              "------------------------------------------------");
                                            for (int j = 0; j < 3; j++)
                                            {
                                                if (j == 0)
                                                {
                                                    Console.WriteLine("------Martes 7 de diciembre------");
                                                }
                                                else if (j == 1)
                                                {
                                                    Console.WriteLine("------Miercoles 8 de diciembre------");
                                                }
                                                else if (j == 2)
                                                {
                                                    Console.WriteLine("------Jueves 9 de diciembre------");
                                                }
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    if (horarios[j, i].getEstado() == "Disponible")
                                                    {
                                                        horarios[j, i].verHorario();
                                                        Console.WriteLine();
                                                    }
                                                }
                                            }
                                            Console.Write("Presione enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                        case '3':
                                            //Publicar o descargar horarios
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n        PUBLICANDO/DESCARGANDO HORARIOS\n" +
                                                              "------------------------------------------------");
                                            string programa = "Flyer.txt";
                                            StreamWriter writer = File.CreateText(programa);

                                            writer.WriteLine("HORARIOS:");
                                            for (int j = 0; j < 3; j++)
                                            {
                                                if (j == 0)
                                                {
                                                    writer.WriteLine("------Martes 7 de diciembre------");
                                                }
                                                else if (j == 1)
                                                {
                                                    writer.WriteLine("------Miercoles 8 de diciembre------");
                                                }
                                                else if (j == 2)
                                                {
                                                    writer.WriteLine("------Jueves 9 de diciembre------");
                                                }
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    writer.WriteLine(horarios[j, i].DescargarHorario());
                                                    writer.WriteLine();
                                                }
                                            }
                                            writer.Close();

                                            Console.Write("El horario se publicó y descargó exitosamente, presiona enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                        case '4':
                                            //Alta empresa
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n           REGISTRANDO NUEVA EMPRESA\n" +
                                                              "------------------------------------------------");
                                            Console.WriteLine("\nEmpresas válidas: ");
                                            for (int i = 0; i < 9; i++)
                                            {
                                                Console.WriteLine(validacionE[i]);
                                            }

                                            if (Empresa[numEmpresas].altaUsuario(3) == 1)
                                            {
                                                numEmpresas++;
                                            }
                                            break;

                                        case '5':
                                            //Editar empresa y/o eliminar
                                            Console.WriteLine("¿Deseas editar o eliminar?");
                                            Console.Write("1.- Editar\n" +
                                                          "2.- Eliminar\n" +
                                                          "\nOpción: ");
                                            dsn = Convert.ToChar(Console.ReadLine());
                                            Console.Clear();

                                            if (numEmpresas == 0)
                                            {
                                                Console.Write("En este momento no hay empresas registradas, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("------------------------------------------------" +
                                                                  "\n             EMPRESAS REGISTRADAS\n" +
                                                                  "------------------------------------------------");
                                                for (int i = 0; i < numEmpresas; i++)
                                                {
                                                    Console.WriteLine((i + 1) + ".- " + Empresa[i].getNombreEmpresa()); //Console.WriteLine((i + 1) + ".- " + Empresa[i].getUsuario());
                                                }
                                                
                                                Console.Write("\n\nSeleccione la empresa: ");
                                                auxCa = (Convert.ToInt32(Console.ReadLine()) - 1);
                                                Console.Clear();
                                                
                                                if (auxCa+1 > numEmpresas) 
                                                {
                                                    Console.WriteLine("Empresa inexistente, presione enter para continuar...");
                                                    Console.ReadLine();
                                                }
                                                else
                                                {
                                                    if (dsn == '1')
                                                    {
                                                        Console.WriteLine("------------------------------------------------" +
                                                                          "\n              EDITANDO EMPRESA\n" +
                                                                          "------------------------------------------------");
                                                        Console.WriteLine("\nEmpresas validas: ");
                                                        for (int i = 0; i < 9; i++)
                                                        {
                                                            Console.WriteLine(validacionE[i]);
                                                        }
                                                        Empresa[auxCa].altaUsuario(3);
                                                    }
                                                    else if (dsn == '2')
                                                    {
                                                        //Recorrido arreglo empresa para eliminar                                                
                                                        while (auxCa != 5)
                                                        {
                                                            Empresa[auxCa] = Empresa[auxCa + 1];
                                                            auxCa++;
                                                        }
                                                        Empresa[auxCa] = new Administradores("", -1, "", "", "", "", "", -1);
                                                        numEmpresas--;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Opción incorrecta, regresando al menú anterior");
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                    }
                                                }
                                            }
                                            break;

                                        case '6':
                                            //Asignar horarios
                                            if (numEmpresas == 0)
                                            {
                                                Console.Write("\nEn este momento no hay empresas registradas, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("------------------------------------------------" +
                                                                  "\n              ASIGNAR HORARIOS\n" +
                                                                  "------------------------------------------------");

                                                for (int i = 0; i < numEmpresas; i++) //for (int i = 0; i <=numEmpresas; i++)
                                                {
                                                    Console.WriteLine((i + 1) + ".- " + Empresa[i].getNombreEmpresa());
                                                }
                                                Console.Write("\nSeleccione la empresa: ");
                                                auxCa = (Convert.ToInt32(Console.ReadLine()) - 1);
                                                Console.Clear();
                                                if (auxCa + 1 > numEmpresas)
                                                {
                                                    Console.WriteLine("Empresa inexistente, presione enter para continuar...");
                                                    Console.ReadLine();
                                                }
                                                else
                                                {
                                                    Console.Write("Seleccione el día que quiere reservar: " +
                                                              "\n1.-Martes" +
                                                              "\n2.-Miercoles" +
                                                              "\n3.-Jueves" +
                                                              "\nOpción: ");
                                                    auxNd = 0;
                                                    auxNd = (Convert.ToInt32(Console.ReadLine()) - 1);
                                                    Console.Clear();
                                                    if (auxNd == 0 || auxNd == 2 || auxNd == 1)
                                                    {
                                                        
                                                        Console.WriteLine("------------------------------------------------" +
                                                                          "\n             HORARIOS DISPONIBLES\n" +
                                                                          "------------------------------------------------");
                                                        for (int i = 0; i < 6; i++)
                                                        {
                                                            if (horarios[auxNd, i].getEstado() == "Disponible")
                                                            {
                                                                horarios[auxNd, i].verHorario();
                                                                Console.WriteLine();
                                                            }
                                                        }

                                                        Console.Write("Seleccione el ID del horario que quiere reservar: ");
                                                        auxNa = (Convert.ToInt32(Console.ReadLine()) - 1);
                                                        Console.Write("\nReservando");
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.Write(".");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.Clear();

                                                        if (horarios[auxNd, auxNa].getEstado() == "Disponible")
                                                        {
                                                            ponente.setPonente();

                                                            horarios[auxNd, auxNa].reservarHorario(Empresa[auxCa].getNombreEmpresa(), ponente.getPonencia());

                                                            Console.Write("\n\nHorario reservado, presione enter para continuar...");
                                                            Console.ReadLine();
                                                        }
                                                        else
                                                        {
                                                            Console.Write("\n\nHorario no disponible, presione enter para continuar...");
                                                            Console.ReadLine();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Write("\n\nOpción invalida, presione enter para continuar...");
                                                        Console.ReadLine();
                                                    }
                                                    
                                                    
                                                }
                                                
                                            }
                                            break;

                                        case '7':
                                            //Ver usuarios
                                            Console.WriteLine("\n------------------ADMINISTRADORES---------------");
                                            for (int i = 0; i <= numAdmins; i++)
                                            {
                                                Console.WriteLine(Admin[i].getUsuario());
                                            }

                                            Console.WriteLine("\n\n---------------------EMPRESAS-------------------");
                                            for (int i = 0; i <= numEmpresas; i++)
                                            {
                                                Console.WriteLine(Empresa[i].getUsuario());
                                            }
                                            Console.Write("Presione enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                        case '8':
                                            //Alta admin
                                            if (numAdmins == 5)
                                            {
                                                Console.Write("Número máximo de administradores permitido, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                if (auxNa == 1)
                                                {
                                                    numAdmins++;
                                                    numTrabajador++;

                                                    Console.WriteLine("------------------------------------------------" +
                                                                      "\n          DANDO DE ALTA ADMINISTRADOR\n" +
                                                                      "------------------------------------------------");
                                                    Admin[numAdmins].altaUsuario(2);
                                                    Admin[numAdmins].setNumTrabajador(numTrabajador);
                                                }
                                                else
                                                {
                                                    Console.Write("Ingrese una opción válida, presione enter para continuar...");
                                                    Console.ReadLine();
                                                }
                                            }
                                            break;

                                        case '9':
                                            //Eliminar admin
                                            if (numAdmins == 0)
                                            {
                                                Console.Write("En este momento no hay administradores registrados, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            else if (auxNa == 1)
                                            {
                                                //Recorrer arreglo
                                                Console.WriteLine("------------------------------------------------" +
                                                                  "\n              ADMINISTRADORES\n" +
                                                                  "------------------------------------------------");
                                                for (int i = 1; i <= numAdmins; i++)
                                                {
                                                    Console.WriteLine((i) + ".- " + Admin[i].getUsuario());
                                                }
                                                Console.Write("\n\nSeleccione el administrador que desea eliminar: ");
                                                auxCa = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("\nEliminando");
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Clear();

                                                while (auxCa != 5)
                                                {
                                                    Admin[auxCa] = Admin[auxCa + 1];
                                                    auxCa++;
                                                }
                                                Admin[auxCa] = new Administradores("", -1, "", "", "", "", "", -1);
                                                numAdmins--;
                                            }
                                            else
                                            {
                                                Console.Write("Ingrese una opción válida, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            break;

                                        case '0':
                                            //Salir
                                            break;

                                        default:
                                            Console.Write("Ingrese una opción válida, presione enter para continuar...");
                                            Console.ReadLine();
                                            break;
                                    }
                                    Console.Clear();
                                    Console.Write("Repetir el MENÚ ADMINISTRADOR - 's'\n" +
                                                  "Volver al MENÚ PRINCIPAL - Cualquier tecla\n\n" +
                                                  "Opción: ");
                                    opcion = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                } while (opcion == 's');
                            }
                            else if (auxNa == 3)
                            {
                                do
                                {
                                    Console.WriteLine("------------------------------------------------" +
                                                      "\n              BEINVENIDA EMPRESA\n" +
                                                      "------------------------------------------------");

                                    Console.Write("Seleccione una opcion\n" +
                                                  "1.- Editar información.\n" +
                                                  "2.- Reservar horario.\n" +
                                                  "3.- Ver horarios\n" +
                                                  "0.- Cerrar sesión\n\n" +
                                                  "Opción: ");
                                    dsn = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();

                                    switch (dsn)
                                    {
                                        case '1':
                                            //Editar información
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n              EDITANDO EMPRESA\n" +
                                                              "------------------------------------------------");
                                            Console.WriteLine("\nEmpresas válidas: ");
                                            for (int i = 0; i < 9; i++)
                                            {
                                                Console.WriteLine(validacionE[i]);
                                            }
                                            Empresa[auxCa].altaUsuario(3);
                                            break;

                                        case '2':
                                            //Reservar horarios
                                            Console.Write("Seleccione el día que quiere reservar: " +
                                                              "\n1.-Martes" +
                                                              "\n2.-Miercoles" +
                                                              "\n3.-Jueves" +
                                                              "\nOpcióon: ");
                                            auxNd = 0;
                                            auxNd = (Convert.ToInt32(Console.ReadLine()) - 1);
                                            Console.Clear();
                                            if (auxNd == 0 || auxNd == 2 || auxNd == 1)
                                            {

                                                Console.WriteLine("------------------------------------------------" +
                                                                  "\n             HORARIOS DISPONIBLES\n" +
                                                                  "------------------------------------------------");
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    if (horarios[auxNd, i].getEstado() == "Disponible")
                                                    {
                                                        horarios[auxNd, i].verHorario();
                                                        Console.WriteLine();
                                                    }
                                                }

                                                Console.Write("Seleccione el ID del horario que quiere reservar: ");
                                                auxNa = (Convert.ToInt32(Console.ReadLine()) - 1);
                                                Console.Write("\nReservando");
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Write(".");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.Clear();

                                                if (horarios[auxNd, auxNa].getEstado() == "Disponible")
                                                {
                                                    ponente.setPonente();

                                                    horarios[auxNd, auxNa].reservarHorario(Empresa[auxCa].getNombreEmpresa(), ponente.getPonencia());

                                                    Console.Write("\n\nHorario reservado, presione enter para continuar...");
                                                    Console.ReadLine();
                                                }
                                                else
                                                {
                                                    Console.Write("\n\nHorario no disponible, presione enter para continuar...");
                                                    Console.ReadLine();
                                                }
                                            }
                                            else
                                            {
                                                Console.Write("\n\nOpción invalida, presione enter para continuar...");
                                                Console.ReadLine();
                                            }
                                            break;

                                        case '3':
                                            //Ver horarios
                                            Console.WriteLine("------------------------------------------------" +
                                                              "\n                  HORARIOS\n" +
                                                              "------------------------------------------------");
                                            for (int j = 0; j < 3; j++)
                                            {
                                                if (j == 0)
                                                {
                                                    Console.WriteLine("------Martes 7 de diciembre------");
                                                }
                                                else if (j == 1)
                                                {
                                                    Console.WriteLine("------Miercoles 8 de diciembre------");
                                                }
                                                else if (j == 2)
                                                {
                                                    Console.WriteLine("------Jueves 9 de diciembre------");
                                                }
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    if (horarios[j,i].getNombreEmpresa() == Empresa[auxCa].getNombreEmpresa())
                                                    {
                                                        horarios[j,i].verHorario();
                                                        Console.WriteLine();
                                                    }
                                                }
                                            }
                                            Console.Write("\n\nPresione enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                        case '0':
                                            //Salir //System.Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Write("Ingrese una opción válida, presione enter para continuar...");
                                            Console.ReadLine();
                                            break;

                                    }
                                    Console.Clear();
                                    Console.Write("Repetir el MENÚ EMPRESA - 's'\n" +
                                                  "Volver al MENÚ PRINCIPAL - Cualquier tecla\n\n" +
                                                  "Opción: ");
                                    opcion = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                } while (opcion == 's');
                            }
                            else //Si no existe
                            {
                                Console.Write("Datos incorrectos, regresando al menú anterior");
                                Console.Write(".");
                                System.Threading.Thread.Sleep(1000);
                                Console.Write(".");
                                System.Threading.Thread.Sleep(1000);
                                Console.Write(".");
                                System.Threading.Thread.Sleep(1000);
                            }
                            break;


                        case '2':
                            //Registrar empresa
                            Console.WriteLine("------------------------------------------------" +
                                              "\n           REGISTRANDO NUEVA EMPRESA\n" +
                                              "------------------------------------------------");
                            Console.WriteLine("\nEmpresas validas: ");
                            for (int i = 0; i < 9; i++)
                            {
                                Console.WriteLine(validacionE[i]);
                            }

                            if (Empresa[numEmpresas].altaUsuario(3) == 1)
                            {
                                numEmpresas++;
                            }
                            break;

                        case '3':
                            //Acerca de...
                            Console.Write("------------------------------------------------" +
                                              "\n                PROYECTO FINAL\n\n" +
                                              "Programación Orientada a Objetos\n" +
                                              "Grupo: 09\n" +
                                              "Semestre 2022-1\n" +
                                              "Equipo 04\n" +
                                              "\n                 INTEGRANTES:\n\n" +
                                              "-García López Saúl\n" +
                                              "-Márquez Rosas Axel Noé\n" +
                                              "-Ornelas Garduño Alexis Johan\n" +
                                              "-Sanchez Alvarez Angel Ruben\n" +
                                              "-Villalpando Aguilar Jesica\n" +
                                              "\n\nEl presente proyecto fue desarrollado de manera \n" +
                                              "conjunta siíncrona.\n" +
                                              "------------------------------------------------\n" +
                                              "\n\nPresione enter para continuar...");
                            Console.ReadLine();
                            break;

                        case '0':
                            //Salir Definitivo
                            System.Environment.Exit(0);
                            break; 

                        default:
                            Console.Write("Ingrese una opción valida, presione enter para continuar...");
                            Console.ReadLine();
                            break;
                    }
                    Console.Clear();
                    Console.Write("Volver al MENÚ PRINCIPAL - 's'\n" +
                                  "SALIR del programa- Cualquier tecla\n\n" +
                                  "Opción: ");
                    opcion = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                } while (opcion == 's');
                Console.WriteLine("Hasta luego");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Hasta luego");
                Console.ReadLine();
            }
        }
    }
}
