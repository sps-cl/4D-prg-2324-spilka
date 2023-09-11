using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Ahoj");

        Rectangle rect = new Rectangle();
        rect.Draw(5, 10);
    }
}

class Rectangle(float height, float width) {
    float height;
    float width;

    public void Draw(){
        Console.WriteLine("Drawing rectangle: size" + height + " " + width);
    }
}