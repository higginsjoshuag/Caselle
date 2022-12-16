using Caselle;

class Triangle {
    public float a;
    public float b;
    public float c;
    public Triangle(float a, float b, float c){
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public bool isValidTriangle(){
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // SIDES (using side lengths)
    // A scalene triangle can be defined as a triangle whose all 
    // three sides have different lengths, and all three angles
    // are of different measures.
    public bool isScalene(){
        return (a != b) && (a != c) && (b != c);
    }
    // An isosceles triangle can be defined as a triangle whose
    // two sides have equal lengths, and the two angles opposite
    // to these sides are equal.
    public bool IsIsosceles(){
        return (a == b) || (a == c) || (b == c);
    }
    // An equilateral triangle can be defined as a triangle whose
    // all three sides have equal lengths, and all three angles
    // are of equal measures.
    public bool IsEquilateral(){
        return (a == b) && (a == c);
    }


    // ANGLES (but using sides)
    // An acute triangle can be defined as a triangle whose all
    // three angles are less than 90 degrees.
    public bool isAcute(){
        // if a^2 + b^2 = c^2, then it's a right triangle
        return (a * a + b * b > c * c) && (a * a + c * c > b * b) && (b * b + c * c > a * a);
    }
    // An obtuse triangle can be defined as a triangle whose one
    // angle is greater than 90 degrees.
    public bool isObtuse(){
        return (a * a + b * b < c * c) || (a * a + c * c < b * b) || (b * b + c * c < a * a);
    }
    // A right triangle can be defined as a triangle whose one
    // angle is 90 degrees.
    public bool IsRight(){
        return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
    }

    // a^2 = b^2 + c^2 - 2bc cos A
    // A = arccos((b^2 + c^2 - a^2) / 2bc)
    // https://www.youtube.com/watch?v=COMiK1L0Oj8
    public int[] getAngles() {
        int[] angles = new int[3];
        angles[0] = (int)Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI);
        angles[1] = (int)Math.Round(Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI);
        angles[2] = (int)Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI);
        return angles;
    }
}