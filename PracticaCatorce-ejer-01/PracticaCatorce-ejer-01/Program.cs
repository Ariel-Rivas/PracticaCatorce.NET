using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PracticaCatorce_ejer_01

//1- Análogamente a lo visto en este módulo.crea los métodos clases y propiedades, para crear el código
//lo mas asincronamente posible,  que ponga como ejemplo hacer una receta de cocina(por ejemplo una tortilla
//de patatas)
{
    class Program
    {

        static async Task Main(string[] args)
        {
            Vino cup = ServirVino();
            WriteLine("Copa de vino lista");

            var potatoTask = FreirPapas(1);
            var eggTask = BatirHuevos(2);
            var onionTask = FreirCebolla(1);

            var mezclaTask = MezclarIngredientes(2);

            var allTasks = new List<Task> { potatoTask, eggTask, onionTask, mezclaTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == potatoTask)
                {
                    WriteLine("Las papas estan listas");
                    allTasks.Remove(potatoTask);
                    var potato = await potatoTask;



                }
                else if (finished == eggTask)
                {
                    WriteLine("Los huevos estan listo");
                    allTasks.Remove(eggTask);
                    var egg = await eggTask;

                }
                else if (finished == onionTask)
                {
                    WriteLine("Tostadas listas");
                    allTasks.Remove(onionTask);
                    var onion = await onionTask;
                }
                else
                    allTasks.Remove(finished);


            }
            WriteLine(" El revuelto gramajo is ready!");
            ReadLine();
        }
        public static Vino ServirVino()
        {
            return new Vino();
        }
        public static async Task<Papas> FreirPapas(int cantPapas)
        {
            return new Papas();
        }

        public static async Task<Huevos> BatirHuevos(int cantHuevos)
        {
            return new Huevos();
        }
        public static async Task<Cebolla> FreirCebolla(int cantCebolla)
        {
            return new Cebolla();
        }

        async static Task<Plato> MezclarIngredientes(int num)
        {
            var planMezcla = await armarPlato(num);
            AplicarSalYPimienta(planMezcla);
            AplicarArbeja(planMezcla);
            AplicarPerejil(planMezcla);
            return planMezcla;
        }

        public static void AplicarSalYPimienta(Plato mezcla)
        {
            WriteLine("Se agrego Sal y pimienta a la mezcla");
        }

        public static void AplicarArbeja(Plato mezcla)
        {
            WriteLine("Se agrego arbeja");
        }
        public static void AplicarPerejil(Plato mezcla)
        {
            WriteLine(" Se salpico con un poco de perejil ");


        }

        public static async Task<Plato> armarPlato(int cantPlatos)
        {

            return new Plato();
        }

    }

}             
           

            
          



    


    

