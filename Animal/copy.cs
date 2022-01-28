using System;

public abstract class Shape
{

    protected string color;

    public abstract double area();

    public abstract double perimeter();

    public abstract void move(double x, double y);

    public abstract string render();

    public string getColor()
    {

        return color;
    }
}

public override class Box : Shape
{

    string color;

    protected double area;
    protected double perimeter;

    double left;
    double right;
    double top;
    double bottom;

    public Box(string Color, double Left, double Top, double Right, double Bottom){

        color = Color;
        left = Left;
        right = Right;
        top = Top;
        bottom = Bottom;   
    }
    public override double area(double x)
    {
        x = (right - left) * (top - bottom);
        return x;
    }

    public override double perimeter(double x)
    {
        x = ((right - left) * 2) + ((top - bottom) * 2);
        return x;
    }

    public override void move(double x, double y){

        left += x;
        right += x;
        top += y;
        bottom += y;
    }
    public override string render(){

        string renderTemp = "Box(" + color + "," + left + "," + top + "," + right + "," + bottom + ")";
        return renderTemp;
    }

    public double getLeft()
    {

        return left;
    }

    public double getRight(){

        return right;
    }

    public double getTop(double Top){

        return top;
    }

    public double getBottom(double Bottom){

        return bottom;
    }

    public void setLeft(double Left){

        left = Left;
    }
   
    public void setRight(double Right){

        right = Right;
    }

    public void setTop(double Top){

        top = Top;
    }

    public void setBottom(double Bottom){

        bottom = Bottom;
    }
}

public class Circle : Shape
{

    string color;

    protected double Area;
    protected double Perimeter;

    double centerX;
    double centerY;
    double radius;


    public Circle(string Color, double CenterX, double CenterY, double Radius){

        color = Color;
        centerX = CenterX;
        centerY = CenterY;
        radius = Radius;
        Area = 3.14 * (radius * 2);
        Perimeter = 2 * 3.14 * radius;
    }
    public void move(double x, double y){

        centerX += x;
        centerY += y;
    }

    public string render(){

        string renderTemp = "Circle(" + color + "," + centerX + "," + centerY + "," + radius + ")";
        return renderTemp;
    }

    public double getCenterX(){

        return centerX;
    }
    public double getCenterY(){

        return centerY;
    }

    public void setCenterX(double X){

        centerX = X;
    }

    public void setCenterY(double Y){

        centerY = Y;
    }

    public void setRadius(double R){

        radius = R;
    }

    public double setRadius(){

        return radius;
    }
}

public class Triangle : Shape
{

    string color;

    protected double Area;
    protected double Perimeter;

    double topX; 
    double topY; 
    double leftX;
    double leftY;
    double rightX;
    double rightY;

    public Triangle(string Color, double TopX, double TopY, double LeftX, double LeftY, double RightX, double RightY){

        color = Color;
        topX = TopX; 
        topY = TopY;
        leftX = LeftX; 
        leftY = LeftY;
        rightX = RightX; 
        rightY = RightY;
        Area = .5 * (topX * (leftY - rightY) + leftX * (rightY - topY) + rightX * (topY - leftY));
        Perimeter = Math.Abs(leftX - rightX) * Math.Abs(leftY - topY) / 2;  
    }
    public void move(double x, double y){

        topX += x;
        topY += y;
        leftX += x;
        leftY += y;
        rightX += x;
        rightY += y;
    }

    public string render(){

        string renderTemp = "Triangle(" + color + "," + topX + "," + topY + "," + leftX + "," + leftY + "," + rightX + "," + rightY + ")";
        return renderTemp;
    }

    public double getCornerX1(){

        return topX;
    }

    public double getCornerY1(){

        return topY;
    }

    public double getCornerX2(){

        return leftX;
    }

    public double getCornerY2(){

        return leftY;
    }

    public double getCornerX3(){

        return rightX;
    }

    public double getCornerY3(){

        return rightY;
    }

    public void setCornerX1(double X){

        topX = X;
    }

    public void setCornerY1(double Y){

        topY = Y;
    }

    public void setCornerX2(double X){

        leftX = X;
    }

    public void setCornerY2(double Y){

        leftY = Y;
    }

    public void setCornerX3(double X){

        rightX = X;
    }

    public void setCornerY3(double Y){

        rightY = Y;
    }
}

public class Polygon : Shape
{

    string color;

    protected double area;
    protected double perimeter;

    double[] points;
    int vertices;

    public Polygon(string Color, double[] Points, int Vert){

        for (int i = 0; i < Vert; i++){

            points[i] = Points[i];
        }

        color = Color;
        vertices = Vert;

        for (int i = 0; i < vertices * 2; i += 2){

            double tempPerimeter = Math.Pow(Math.Abs(points[i] - points[i + 2]), 2) + Math.Pow(Math.Abs(points[i + 1] - points[i + 3]), 2);
            perimeter += tempPerimeter;
        }

        perimeter += Math.Pow(Math.Abs(points[0] - points[points.Length - 2]), 2) + Math.Pow(Math.Abs(points[1] - points[points.Length - 1]), 2);
        perimeter = Math.Sqrt(perimeter);
 
        double temp = 0.0;
        int k = Vert - 1;

        for (int i = 0; i < Vert; i += 2){

            temp += (points[k] + points[i]) * (points[k + 1] - points[i + 1]);


            k = i;
        }

        area = Math.Abs(temp / 2.0);
    }

    public void move(double x, double y){

        for (int i = 0; i < vertices * 2; i += 2){

            points[i] += x;
            points[i + 1] += y;
        }
    }

    public string render(){

        string tempRender = "Polygon(" + color;

        foreach (double i in points){

            tempRender += ",";
            tempRender += Convert.ToString(i);
        }

        tempRender += ")";
        return tempRender;
    }

    public double getVertexX(int Vert){

        return points[Vert * 2];
    }

    public double getVertexY(int Vert){

        return points[Vert * 2 + 1];
    }

    public int getNumpoints(){

        return vertices;
    }

    public void setVertexX(int Vert, double X){

        points[Vert * 2] = X;
    }

    public void setVertexY(int Vert, double Y){

        points[Vert * 2 + 1] = Y;
    }
}
class TestShape
{
    public static void Main()
    {
        int count = 0;
        double[] pts = { 1, 1, 7, 2, 3, 5, 6, 8, 4, 3 };
        Shape[] list = new Shape[100];

        list[count++] = new Box("BLUE", 0, 1, 1, 0);
        list[count++] = new Box("CYAN", 2, 9, 4, 3);
        list[count++] = new Circle("WHITE", 5, 5, 3);
        list[count++] = new Triangle("BLACK", 1, 1, 5, 1, 3, 3);
        list[count++] = new Polygon("GREEN", pts, 5);

        double distance = 0;
        double area = 0;
        string str = "";

        for (int i = 0; i < count; i++)
        {
            distance += list[i].perimeter();
            area += list[i].area();
            str += list[i].render();
            str += "\n";
        }

        for (int i = 0; i < count; i++)
        {
            list[i].move(10, 10);
            str += list[i].render();
            str += "\n";
        }

        Console.WriteLine("distance: {0:F4} area: {1:F4}", distance, area);
        Console.WriteLine("{0}", str);
    }
}