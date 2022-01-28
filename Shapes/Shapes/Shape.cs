using System;

abstract class Shape
{

    protected string Color = "";
    protected double Area;
    protected double Perimeter = 0.0;

    public virtual double area(){
        return Area;
    }

    public virtual double perimeter(){

        return Perimeter;
    }

    public virtual void move(double x, double y){}

    public virtual string render(){

        return this.render();
    }

    public virtual string getColor(){

        return Color;
    }
}

class Box : Shape
{

    string color;
    double left;
    double right;
    double top;
    double bottom;

    public Box(string Color, double Left, double Top, double Right, double Bottom){
        color = Color;
        left = Left;
        top = Top;
        right = Right;
        bottom = Bottom;
    }
    public override double area(){

        Area = (right - left) * (top - bottom);
        return Area;
    }

    public override double perimeter(){

        Perimeter = ((right - left) * 2) + ((top - bottom) * 2);
        return Perimeter;
    }

    public override string getColor(){

        return color;
    }

    public override void move(double x, double y){

        base.move(x, y);
        left += x;
        right += x;
        top += y;
        bottom += y;
    }

    public override string render(){

        string renderTemp = "Box(" + color + "," + left + "," + top + "," + right + "," + bottom + ")";
        return renderTemp;
    }

    public double getLeft(){

        return left;
    }

    public double getTop(){

        return top;
    }

    public double getRight(){

        return right;
    }

    public double getBottom(){

        return bottom;
    }

    public void setLeft(double L){

        left = L;
    }

    public void setTop(double T){

        top = T;
    }
    public void setRight(double R){

        right = R;
    }
    public void setBottom(double B){

        bottom = B;
    }  
}

class Circle : Shape
{

    string color;
    double centerX;
    double centerY;
    double radius;

    public Circle(string Color, double CenterX, double CenterY, double Radius){

        color = Color;
        centerX = CenterX;
        centerY = CenterY;
        radius = Radius;
    }

    public override double area(){

        Area = 3.14 * (radius * 2);
        return Area;
    }

    public override double perimeter(){

        Perimeter = (2 * 3.14) * radius;
        return Perimeter;
    }

    public override string getColor(){

        return color;
    }
    public override void move(double x, double y){

        centerX += x;
        centerY += y;
    }

    public override string render(){

        string renderTemp = "Circle(" + color + "," + centerX + "," + centerY + "," + radius + ")";
        return renderTemp;
    }

    public double getCenterX(){

        return centerX;
    }
    public double getCenterY(){

        return centerY;
    }
    public double getRadius(){

        return radius;
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
}

class Triangle : Shape
{
    
    string color;
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
    }

    public override double area(){

        Area = .5 * (topX * (leftY - rightY) + leftX * (rightY - topY) + rightX * (topY - leftY));
        return Area;
    }

    public override string getColor(){

        return color;
    }

    public override void move(double x, double y){

        topX += x;
        topY += y;
        leftX += x;
        leftY += y;
        rightX += x;
        rightY += y;
    }

    public override string render(){

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
class Polygon : Shape
{

    string color;
    double[] points = new double[20];
    int vert;

    public Polygon(string C, double[] P, int V){

        for (int i = 0; i < V * 2; i++){

            points[i] = P[i];
        }

        color = C;
        vert = V;
    }
    public override double area(){

        double temp = 0.0;
        int j = vert;
        
        for (int i = 0; i < vert * 2 - 1; i += 2){

            temp += (points[j] + points[i]) * (points[j + 1] - points[i + 1]);

            j = i;
        }

        Area *= Math.Abs(temp / 2);
        return Area;
    }
    public override double perimeter(){

        for (int i = 0; i < vert * 2 - 2; i += 2){

            Perimeter += Math.Sqrt(Math.Pow(Math.Abs(points[i] - points[i + 2]), 2) + Math.Pow(Math.Abs(points[i + 1] - points[i + 3]), 2));
        }

        Perimeter += Math.Sqrt(Math.Pow(Math.Abs(points[0] - points[vert * 2 - 2]), 2) + Math.Pow(Math.Abs(points[1] - points[points.Length - 1]), 2));
        return Perimeter;
    }

    public override string getColor(){

        return color;
    }

    public override void move(double x, double y){

        for (int i = 0; i < vert * 2 - 1; i += 2){

            points[i] += x;
            points[i + 1] += y;
        }
    }

    public override string render(){

        string renderTemp = "Polygon(" + color + ","+ vert;

        for (int i = 0; i < vert * 2; i++){

            renderTemp += ",";
            renderTemp += Convert.ToString(points[i]);
        }
     
        renderTemp += ")";
        return renderTemp;
    }

    public double getVertexX(int V){

        return points[V * 2];
    }
    public double getVertexY(int V){

        return points[V * 2 + 1];
    }
    public int getNumpoints(){

        return vert;
    }
    public void setVertexX(int V, double X){

        points[V * 2] = X;
    }
    public void setVertexY(int V, double Y){

        points[V * 2 + 1] = Y;
    }
}