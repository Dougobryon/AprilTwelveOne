using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTwelveOne
{
    


    class Vegetable
    {
        public string Color { get; set; } = "purple";
        public string Type { get; set; }
        public string Shape { get; set; }
        public string Size { get; set; }
        public string Sweetness { get; set; }

        public void Ripen()
        {
            this.Color = "orange";
            this.Shape = "round";
            this.Size = "large";
            this.Sweetness = "moderate";
        }

        public void Ripen(string col, string shape, string size, string sweetness)
        {
            this.Color = col;
            this.Shape = shape;
            this.Size = size;
            this.Sweetness = sweetness;
        }
            //default constructor
            public Vegetable()
        {
            this.Color = "green";
            this.Type = "cucumber";
            this.Shape = "square";
            this.Sweetness = "sweet";
            this.Size = "large";


        }

        }
    }





