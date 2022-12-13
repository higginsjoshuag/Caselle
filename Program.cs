using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caselle{
    class Program{

        static void Main(string[] args){

            string[] sides = System.IO.File.ReadAllLines("./triangles.txt");
            string[] types = System.IO.File.ReadAllLines("./triangles_types.txt");

            for (int i = 0; i < sides.Length; i++) {
                // (3, 3, 4)
                string[] side = sides[i].Split('(',',',')');
                // ['scalene', 'obtuse']
                string[] type = types[i].Split('[',',','\'',']');
                string[] newTypes = new string[type.Length - 2];

                float a = float.Parse(side[1]);
                float b = float.Parse(side[2]);
                float c = float.Parse(side[3]);
                Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
                for (int j = 0; j < type.Length; j++) {
                    if (type[j] != "") {
                        newTypes[j] = type[j];
                    }
                }

                Triangle triangle = new Triangle(a, b, c);

                if (triangle.isValidTriangle()) {
                    if (triangle.isScalene()) {
                        if (newTypes.Contains("scalene")) {
                            Console.WriteLine("The triangle is scalene");
                        } else {
                            Console.WriteLine("The triangle is not scalene");
                        }
                        Console.WriteLine("The triangle is scalene");
                    }
                    if (triangle.IsIsosceles()) {
                        Console.WriteLine("The triangle is isosceles");
                    }
                    if (triangle.IsEquilateral()) {
                        Console.WriteLine("The triangle is equilateral");
                    }
                    if (triangle.isAcute()) {
                        Console.WriteLine("The triangle is acute");
                    }
                    if (triangle.isObtuse()) {
                        Console.WriteLine("The triangle is obtuse");
                    }
                    if (triangle.IsRight()) {
                        Console.WriteLine("The triangle is right");
                    }
                    int[] angles = triangle.getAngles();
                    Console.WriteLine("The angles of the triangle are: " + angles[0] + ", " + angles[1] + ", " + angles[2]);
                } else {
                    Console.WriteLine("The triangle is not valid");
                }
                Console.WriteLine("The triangle is " + types[i]);
            }



            // // The application needs to validate user input and only allow numbers to be entered. 

            // Console.WriteLine("Enter the length of the first side of the triangle: ");
            // float? a = Single.TryParse(Console.ReadLine(), out var tempA) ? tempA : (float?)null;
            // while (a == null) {
            //     Console.WriteLine("Please enter a valid number");
            //     a = Single.TryParse(Console.ReadLine(), out tempA) ? tempA : (float?)null;
            // }
            // Console.WriteLine("Enter the length of the second side of the triangle: ");
            // float? b = Single.TryParse(Console.ReadLine(), out var tempB) ? tempB : (float?)null;
            // while (b == null) {
            //     Console.WriteLine("Please enter a valid number");
            //     b = Single.TryParse(Console.ReadLine(), out tempB) ? tempB : (float?)null;
            // }
            // Console.WriteLine("Enter the length of the third side of the triangle: ");
            // float? c = Single.TryParse(Console.ReadLine(), out var tempC) ? tempC : (float?)null;
            // while (c == null) {
            //     Console.WriteLine("Please enter a valid number");
            //     c = Single.TryParse(Console.ReadLine(), out tempC) ? tempC : (float?)null;
            // }

            // // Create a new triangle object
            // Triangle triangle = new Triangle(a.Value, b.Value, c.Value);

            // // We need to know whether the given values produce a valid triangle 
            // if (triangle.isValidTriangle()) {
            //     Console.WriteLine("The triangle is valid");
            // } else {
            //     Console.WriteLine("The triangle is not valid");
            //     return;
            // }

            // // Classify the triangle by side and angle
            // if (triangle.isScalene()) {
            //     Console.WriteLine("The triangle is scalene");
            // }
            // if (triangle.IsIsosceles()) {
            //     Console.WriteLine("The triangle is isosceles");
            // }
            // if (triangle.IsEquilateral()) {
            //     Console.WriteLine("The triangle is equilateral");
            // }
            // if (triangle.isAcute()) {
            //     Console.WriteLine("The triangle is acute");
            // }
            // if (triangle.isObtuse()) {
            //     Console.WriteLine("The triangle is obtuse");
            // }
            // if (triangle.IsRight()) {
            //     Console.WriteLine("The triangle is right");
            // }

            // // Calculate the angles of the triangle
            // int[] angles = triangle.getAngles();
            // Console.WriteLine("The angles of the triangle are: " + angles[0] + ", " + angles[1] + ", " + angles[2]);
        }
    }
}
