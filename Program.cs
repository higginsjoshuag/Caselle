using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caselle{
    class Program{

        static void Main(string[] args){
            // The application needs to validate user input and only allow numbers to be entered. 

            Console.WriteLine("Enter the length of the first side of the triangle: ");
            float? a = Single.TryParse(Console.ReadLine(), out var tempA) ? tempA : (float?)null;
            while (a == null) {
                Console.WriteLine("Please enter a valid number");
                a = Single.TryParse(Console.ReadLine(), out tempA) ? tempA : (float?)null;
            }
            Console.WriteLine("Enter the length of the second side of the triangle: ");
            float? b = Single.TryParse(Console.ReadLine(), out var tempB) ? tempB : (float?)null;
            while (b == null) {
                Console.WriteLine("Please enter a valid number");
                b = Single.TryParse(Console.ReadLine(), out tempB) ? tempB : (float?)null;
            }
            Console.WriteLine("Enter the length of the third side of the triangle: ");
            float? c = Single.TryParse(Console.ReadLine(), out var tempC) ? tempC : (float?)null;
            while (c == null) {
                Console.WriteLine("Please enter a valid number");
                c = Single.TryParse(Console.ReadLine(), out tempC) ? tempC : (float?)null;
            }

            // Create a new triangle object
            Triangle triangle = new Triangle(a.Value, b.Value, c.Value);

            // We need to know whether the given values produce a valid triangle 
            if (triangle.isValidTriangle()) {
                Console.WriteLine("The triangle is valid");
            } else {
                Console.WriteLine("The triangle is not valid");
                return;
            }

            // Classify the triangle by side and angle
            if (triangle.isScalene()) {
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

            // Calculate the angles of the triangle
            int[] angles = triangle.getAngles();
            Console.WriteLine("The angles of the triangle are: " + angles[0] + ", " + angles[1] + ", " + angles[2]);
        }
    }
}
