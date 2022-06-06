using System;
namespace Cap7Ejerc5;

public class Program

{

    public static void Main()

    {

        try

        {

            long contador = 0;

            string[] datoscontactos = new string[10000];
            string operador, nombre, tlfn, linea, siono, buscar;

            int i = 0, e = 0;


            StreamWriter dat;
            StreamReader inicio;
            if (!File.Exists("datos.dat"))
            {
                dat = File.CreateText("datos.dat");
                dat.Close();
            }
            else
            {

                inicio = File.OpenText("datos.dat");

                do
                {

                    linea = inicio.ReadLine();
                    datoscontactos[i] = linea;
                    i += 1;
                    contador += 1;

                }
                while (linea != null);
                inicio.Close();
                contador -= 1;
                Console.WriteLine("{0}", contador);
  
            }

            do
            {

                Console.Clear();
                Console.WriteLine("***********************************************************");
                Console.WriteLine("*                   AGENDA TELEFÓNICA                     *");
                Console.WriteLine("***********************************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1.- Agregar un nuevo contacto.");
                Console.WriteLine();
                Console.WriteLine("2.- Mostrar lista de contactos.");
                Console.WriteLine();
                Console.WriteLine("3.- Buscar un contacto.");
                Console.WriteLine();
                Console.WriteLine("4.- Borrar contacto.");
                Console.WriteLine();
                Console.WriteLine("5.- Borrar lista completa.");
                Console.WriteLine();
                Console.WriteLine("6.- Salir.");
                Console.WriteLine();


                operador = Convert.ToString(Console.ReadLine());

                if (operador == "1")
                {
                    StreamWriter datos;

                    Console.Clear();

                    Console.WriteLine("Introduce el nombre del contacto");
                    nombre = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Introduce el telefono de {0}", nombre);
                    tlfn = Convert.ToString(Console.ReadLine());

                    datoscontactos[contador] = nombre + " " + tlfn;

                    datos = File.AppendText("datos.dat");
                    datos.WriteLine("{0} ", datoscontactos[contador]);
                    datos.Close();

                    contador += 1;


                }


                if (operador == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Lista de contactos....");
                    Console.WriteLine("");
                    StreamReader rdatos;  
                    rdatos = File.OpenText("datos.dat");

                    do
                    {

                        linea = rdatos.ReadLine();
                        if (linea != null)
                            Console.WriteLine(linea);

                    }
                    while (linea != null);
                    rdatos.Close();
                    Console.WriteLine("");
                    Console.ReadLine();
                }


                if (operador == "3")
                {

                    Console.Clear();
                    Console.WriteLine("Introduce un nombre o número de telefono a buscar");
                    buscar = Convert.ToString(Console.ReadLine());

                    for (i = 0; i < contador; i++)

                        if (datoscontactos[i].IndexOf(buscar) >= 0)
                            Console.WriteLine("{0}", datoscontactos[i]);


                    Console.ReadLine();

                }

                if (operador == "4")
                {
                    StreamWriter datoss;

                    Console.Clear();
                    Console.WriteLine("Introduce un nombre o número de telefono Eliminar");
                    buscar = Convert.ToString(Console.ReadLine());

                    for (i = 0; i < contador; i++)
                    {
                        if (datoscontactos[i].IndexOf(buscar) >= 0)
                        {
                            int s;
                            for (s = i; s < contador - 1; s++)
                                datoscontactos[s] = datoscontactos[s + 1];
                            contador--;
                            datoscontactos[contador] = "";
                        }
                    }
                    siono = Convert.ToString(Console.ReadLine());
                    dat = File.CreateText("datos.dat");
                    dat.Close();

                    for (e = 0; e < contador; e++)
                    {
                        datoss = File.AppendText("datos.dat");
                        datoss.WriteLine("{0} ", datoscontactos[e]);
                        datoss.Close();

                    }
                    Console.WriteLine("Contacto eliminado correctamente");
                    Console.ReadLine();

                }

                if (operador == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Se van a eliminar todos los contactos.. desea continuar?  ( [y]=si,[n]=no )");
                    siono = Convert.ToString(Console.ReadLine());
                    if (siono == "y")
                    {
                        dat = File.CreateText("datos.dat");
                        dat.Close();
                        Array.Clear(datoscontactos, 0, datoscontactos.Length);
                        contador = 0;
                    }


                }



            }
            while (operador != "6");
        }
        catch (Exception error)
        {
            Console.WriteLine("{0}", error.Message);
        }
        Console.ReadLine();

    }

}