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
    public bool isScalene(){
        return (a != b) && (a != c) && (b != c);
    }
    public bool IsIsosceles(){
        return (a == b) || (a == c) || (b == c);
    }
    public bool IsEquilateral(){
        return (a == b) && (a == c);
    }


    // ANGLES (but using sides)
    public bool isAcute(){
        return (a * a + b * b > c * c) && (a * a + c * c > b * b) && (b * b + c * c > a * a);
    }
    public bool isObtuse(){
        return (a * a + b * b < c * c) || (a * a + c * c < b * b) || (b * b + c * c < a * a);
    }
    public bool IsRight(){
        return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
    }

    public int[] getAngles() {
        int[] angles = new int[3];
        angles[0] = (int)Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI);
        angles[1] = (int)Math.Round(Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI);
        angles[2] = (int)Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI);
        return angles;
    }
}