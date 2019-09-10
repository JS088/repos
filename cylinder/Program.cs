using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    class Cylinder 
    {
        public double radius;
        public double height;
        public double pi = 3.14;
    }
    class Cylindertester 
    {

        static void Main(string[] args)
        {
            Cylinder Cylinder1 = new Cylinder();
            Cylinder Cylinder2 = new Cylinder();

            double volume = 0.0; 



            Cylinder1.radius = 4.5;
            Cylinder1.height = 7;
            
            //cylinder 1 volume = 445.09

            Cylinder2.radius = 6;
            Cylinder2.height = 9;
            
            // cylinder 2 volume = 1017.36

            //volume of cylinder 1
            volume = Cylinder1.height * Cylinder1.radius * Cylinder1.radius * Cylinder1.pi;
            Console.WriteLine("volume of Cylinder1 : {0}", volume);

            //volume of Cylinder 2
            volume = Cylinder2.height * Cylinder2.radius * Cylinder2.radius * Cylinder2.pi;
            Console.WriteLine("volume of Cylinder2 : {0}", volume);
            Console.ReadKey();



            
        }
    }
}
