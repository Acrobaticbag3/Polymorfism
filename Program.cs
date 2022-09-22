// See https://aka.ms/new-console-template for more information
using System;

namespace Polymorfism {
    internal class Program {
        static void Main(string[] args) {
            Shape shape;
            
            (shape as Triangle).Area();
            Triangle t = (Triangle)shape;
            t = shape as Triangle;
        }
    }
}