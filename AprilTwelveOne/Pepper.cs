using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTwelveOne
{
    class Pepper : Vegetable
    {
        public new string Type { get; set; } = "pepper";

        public Pepper()
        {
            this.Color = "green";
            this.Size = "small";
            this.Sweetness = "little";
            //this.Type = "bell pepper";
            this.Shape = "round";
        }

    }

        class Pumpkin:Vegetable
    {
        public new string Type { get; set; } = "pumpkin";
        //public int VineLengthInInches 

    }
}




   