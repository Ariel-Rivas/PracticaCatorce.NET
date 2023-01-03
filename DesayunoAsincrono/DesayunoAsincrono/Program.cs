using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace DesayunoAsincrono
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

                Cafe taza = HacerCafe();
                WriteLine("cafe listo");

                Task <Huevos> eggTask = FreirHuevos(4);

                Task<Bacon> baconTask = FreirBacon(2);

                var TostadaTask = HacerTostadasConMantecaYJamon(4);

                Jugo jugo = HacerJugo();
                WriteLine("Jugo listo"); 

               
                await Task.WhenAll(eggTask, baconTask, TostadaTask);
                WriteLine("Huevos fritos listos");
                WriteLine("Bacon fritos");
                WriteLine("Tostadas prepardas");
                WriteLine("El desayuno esta preparado");

                

                
                ReadLine();
            }

        async static Task<Tostada> HacerTostadasConMantecaYJamon(int canPan)
        {
            var planTostada = await TostarPan(canPan);
            AplicarManteca(planTostada);
            AplicarJamon(planTostada);
            return planTostada;
        }

        private static void AplicarJamon(Tostada tostada)
        {
            WriteLine("Se agrego jamon a la tostada");
        }

        private static void AplicarManteca(Tostada tostada)
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



