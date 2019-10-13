using System;

namespace Conversor_de_unidades
{
    class Program
    { 
        public class Operacion{
            int a;

            public void centimetros(Unidad a){
                a.Cantidad=a.Cantidad / 1000;
                Console.WriteLine(a.Cantidad+" Metros");
            }
            public void metros(Unidad b){
                b.Cantidad = b.Cantidad*39.3701;
                Console.WriteLine(b.Cantidad+" Pulgadas");
            }

            public void litros(Unidad c){
                c.Cantidad = c.Cantidad *1000;
                Console.WriteLine(c.Cantidad+" Mililitros");

            }

            public void captura(Unidad x){
                //Método para capturar la cantidad
                Console.WriteLine("Ingrese la cantidad que desea convertir");
                x.Cantidad = Convert.ToInt32(Console.ReadLine());

            }

            public void menu(){
                //Instancio el objto para poder ejecutar el método captura

                Unidad xyz = new Unidad();
                captura(xyz);
                //opciones del menu
                Console.WriteLine("Bienvenido al menu"+ "\r\n" + 
                "Elija la opción 1 para convertir centimetros a metros"+"\r\n"+
                "Elija la opción 2 para convertir metros a pulgadas"+"\r\n"+
                "Elika la opción 3 para convertir litros a mililitros");
                //variable que decide que opcion elige el usuario
                a = Convert.ToInt32(Console.ReadLine());
                //switch para determinar las opciones posibles

                switch (a)
                {
                    case 1:
                    
                    centimetros(xyz);
                    break;

                    case 2:
                    metros(xyz);
                    break;

                    case 3:
                    litros(xyz);
                    break;

                    default:
                    break;
                    
                    
                }


            }

        }

        public class Unidad{
            // Clase cantidad aqui deberian ir mas atributo jeje
            
             public double Cantidad { get; set; }

        }


        static void Main(string[] args)
        {
            /* Instancio el objeto operacion para podr acceder al método menu,
            No es necesario instanciar un objeto de la clase "Unidad" porque este se
            instancia al mandar a llamar al método menu
            */
            Operacion a = new Operacion();
            a.menu();
            



        }
    }
}
