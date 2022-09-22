using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorfism {
    public class Triangle : Shape {
        public Triangle(int width, int height) : base( width, height) { //Takes width and height as peramaters, than sends them back to shape
            
        }
        public override void Circumferance() {
            int circumferance = width * 2 + height * 2;
            Console.WriteLine("the circumferance of this triangle is: " + circumferance);
        }

        public override void Area() {
            int area = width * height / 2;
            Console.WriteLine("The area of this triangle is: " + area);
        }
    }
}