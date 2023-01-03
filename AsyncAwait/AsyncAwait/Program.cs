using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // await es para obtener el resultado del metodo.
            Cafe taza = await HacerCafe();
            WriteLine("cafe listo");

            Huevos egg = await FreirHuevos(4);
            WriteLine("Huevos fritos listos");

            Bacon bacon = await FreirBacon(2);
            WriteLine("Bacon fritos");

            Tostada tostada  = await TostarPan(4);
            await AplicarManteca(tostada);
            await AplicarJamon(tostada);
            WriteLine("Tostadas prepardas");

            Jugo jugo = await HacerJugo();
            WriteLine("Jugo listo");

            WriteLine("El desayuno esta preparado");
            ReadLine();
        }
        //Metodos asincronos que devuelven una tarea.
        private static async Task AplicarJamon(Tostada tostada)
        {
            WriteLine("Se agrego jamon a la tostada");
        }

        private static async Task AplicarManteca(Tostada tostada)
        {
            WriteLine("Se unto mateca a la tostada");
        }

        public static async Task <Cafe> HacerCafe()
        {
            return new Cafe();
        }

        public static async Task <Huevos> FreirHuevos(int cantHuevos)
        {
            return new Huevos();
        }

        public static async Task <Bacon> FreirBacon(int cantBacon)
        {
            return new Bacon();
        }

        public static async Task <Tostada> TostarPan(int canPan)
        {

            return new Tostada();
        }

        public static async Task <Jugo> HacerJugo()
        {
            return new Jugo();
        }



    }
}


