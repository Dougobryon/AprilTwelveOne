using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTwelveOne
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Vegetable peppy = new Vegetable();
                peppy.Ripen();
                peppy.Color = "purple";
                Console.WriteLine("Peppey color is: {0} " + peppy.Color);


                Vegetable miguel = new Vegetable();
                miguel.Ripen("blue", "square", "small", "bitter");
                Console.WriteLine("Miguel's color is: {0}.  Shape is {1}. Size is {2}. Sweetness is {3}.", miguel.Color, miguel.Shape, miguel.Size, miguel.Sweetness);


                //Now I'm testing inheritence
                //creat new pepper object

                Pepper piper = new Pepper();
                piper.Ripen();
                Console.WriteLine("Piper Color: {0}. Shape: {1}.  Size: {2}. Sweetness: {3}. Type: {4}.", piper.Color, piper.Shape, piper.Size, piper.Sweetness, piper.Type);

                Pumpkin jack = new Pumpkin();
                Console.WriteLine("jack is a" + jack.Type);


            }
        }

    }
}
   
