using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorfism
{
    public class Rectangle : Shape {
        public Rectangle(int width, int height) : base(width, height) { //Takes width and height as peramaters, than sends them back to shape

        }   
        public override void Circumferance() {
            int circumferance = _width * 2 + _height * 2;
            Console.WriteLine("the circumferance of this rectangle is: " + circumferance);
        }

        public override void Area() {
            int area = _width * _height;
            Console.WriteLine("The area of this rectangle is: " + area);
        }
    }
}