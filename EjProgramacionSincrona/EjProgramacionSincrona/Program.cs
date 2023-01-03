using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace EjProgramacionSincrona
{
    class Program
    {
        static void Main(string[] args)
        {

            Cafe taza = HacerCafe();
            WriteLine("cafe listo");

            Huevos egg = FreirHuevos(4);
            WriteLine("Huevos fritos listos");

            Bacon bacon = FreirBacon(2);
            WriteLine("Bacon fritos");

            Tostada tostada = TostarPan(4);
            AplicarManteca(tostada);
            AplicarJamon(tostada);
            WriteLine("Tostadas prepardas");

            Jugo jugo = HacerJugo();
            WriteLine("Jugo listo");

            WriteLine("El desayuno esta preparado");
            ReadLine(); 
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

        public static Huevos FreirHuevos(int cantHuevos)
        {
            return new Huevos(); 
        } 

        public static Bacon FreirBacon(int cantBacon)
        {
            return new Bacon(); 
        } 

        public static Tostada TostarPan(int canPan)
        {

            return new Tostada(); 
        }

        public static Jugo HacerJugo()
        {
            return new Jugo(); 
        }
        
        
        
        }
    }

