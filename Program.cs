// See https://aka.ms/new-console-template for more information
using System;

namespace Polymorfism {
    internal class Program {
        static void Main(string[] args) {
            Shape shape; //Unassigned Object shape that we'll assign values (width, height and an object) to later

            string useShape;
            string useOperation;

            string inputNow = "Input the Width and Height of the ";
            string notAplicable = "N/A Input againg";

            string operation = "Which operation do you want to preforme?  \nArea or Circumferance";
            string spaceing = "====================";

            int width;
            int height;
            
            int i = 0;
            while(i < 1) {
                Console.Write("Choose your shape: ");

                useShape = Console.ReadLine();
                if(useShape == "triangle") { //Triangle path
                    i++; //stops the loop

                    Console.WriteLine(inputNow + useShape + ": ");

                    // ask for relevant information and store it 
                    width = int.Parse(Console.ReadLine());
                    height = int.Parse(Console.ReadLine());
                    shape = new Triangle(width, height); //polymorphs shape into a triangle
                    Console.WriteLine(spaceing);

                    //ask for which operation the info will be used
                    Console.WriteLine(operation);
                    useOperation = Console.ReadLine();
                    Console.WriteLine(spaceing);

                    //Lets the user chose what operation to preforme
                    if(useOperation == "Area") { 
                        shape.Area();
                    } else if(useOperation == "Circumferance") {
                        shape.Circumferance();
                    } else {
                        Console.WriteLine(notAplicable);
                    }

                } else if(useShape == "rectangle") { //Rectangle path
                    i++; //stops the loop

                    Console.WriteLine(inputNow + useShape + ": ");
                    
                    // ask for relevant information and store it
                    width = int.Parse(Console.ReadLine());
                    height = int.Parse(Console.ReadLine());
                    shape = new Rectangle(width, height); //polymorphs shape into a rectangle
                    Console.WriteLine(spaceing);

                    //ask for which operation the info will be used
                    Console.WriteLine(operation);
                    useOperation = Console.ReadLine();
                    Console.WriteLine(spaceing);
                    
                    //Lets the user chose what operation to preforme
                    if(useOperation == "Area") { 
                        shape.Area();
                    } else if(useOperation == "Circumferance") {
                        shape.Circumferance();
                    } else {
                        Console.WriteLine(notAplicable);
                    }
                    
                } else {
                    Console.WriteLine(notAplicable);
                    i = 0; //Continues the loop
                }
            }
        }
    }
}