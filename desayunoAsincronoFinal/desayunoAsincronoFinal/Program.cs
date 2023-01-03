using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace desayunoAsincronoFinal
{ 
    class Program
    {
        static async Task Main(string[] args)
        {
            Cafe cup = HacerCafe();
            WriteLine("El cafe esta listo");

            var eggTask = FreirHuevos(2);
            var baconTask = FreirBacon(1);
            var toastTask = HacerTostadasConMantequillaYJamon(2);

            var allTasks = new List<Task> { eggTask, baconTask, toastTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggTask)
                {
                    WriteLine("Los huevos estan listos");
                    allTasks.Remove(eggTask);
                    var egg = await eggTask;



                }
                else if (finished == baconTask)
                {
                    WriteLine("El bacon quedo listo");
                    allTasks.Remove(baconTask);
                    var bacon = await baconTask;

                }
                else if (finished == toastTask)
                {
                    WriteLine("Tostadas listas");
                    allTasks.Remove(toastTask);
                    var toast = await toastTask;
                }
                else
                    allTasks.Remove(finished);


            }
            WriteLine("BreakFast is ready!");

        }
        async static Task<Tostada> HacerTostadasConMantequillaYJamon(int num)
        {
            var planTostada = await TostarPan(num);
            AplicarManteca(planTostada);
            AplicarJamon(planTostada);
            return planTostada;
        }

        public static void AplicarJamon(Tostada tostada)
        {
            WriteLine("Se agrego jamon a la tostada");
        }

        public static void AplicarManteca(Tostada tostada)
        {
            WriteLine("Se unto mateca a la tostada");
        }

        public static Cafe HacerCafe()
        {
            return new Cafe();
        }

        public static async Task<Huevos> FreirHuevos(int cantHuevos)
        {
            return new Huevos();
        }

        public static async Task<Bacon> FreirBacon(int cantBacon)
        {
            return new Bacon();
        }

        public static async Task<Tostada> TostarPan(int canPan)
        {

            return new Tostada();
        }

        public static Jugo HacerJugo()
        {
            return new Jugo();
        }



    }
}




    


