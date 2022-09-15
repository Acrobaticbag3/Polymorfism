using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorfism
{
    public class Rectangle : Shape {
        public Rectangle(int width, int height) : base( width, height) {

        }   
        public override void Circumferance() {
            int circumferance = width * 2 + height * 2;
            Console.WriteLine("the circumferance of this rectangle is: " + circumferance);
        }

        public override void Area() {
            int area = width * height;
            Console.WriteLine("The area of this rectangle is: " + area);
        }
    }
}