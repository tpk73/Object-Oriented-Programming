using System;

class Fraction
{
    private int w;
    private int n;
    private int d;

    public Fraction()
    {
        this.w = 0;
        this.n = 0;
        this.d = 1;
    }

    public Fraction(int num, int den)
    {
        this.w = 0;
        this.n = num;
        this.d = den;
    }

    public Fraction(int whole, int num, int den)
    {
        this.w = whole;
        this.n = num;
        this.d = den;
    }

    int gcd(int x, int y)
    {
        if (y== 0){
            return x;
        }
            
        return gcd(y, x % y);
    }

    public void Reduce()
    {
        int tempGCD = gcd(this.n, this.d);
        this.w += this.n / this.d;             
        this.n = this.n % this.d;
        this.n /= tempGCD;
        this.d /= tempGCD;
    }

    public static Fraction operator +(Fraction x, Fraction y)
    {
        Fraction z = new Fraction();

        if (y.d == 1){

            y.w += y.n;
            y.n = 0;
            y.d = 1;
        }
        else if (x.d == 1){
            
            x.w += x.n;
            x.n = 0;
            x.d = 1;
        }

        z.w = x.w + y.w;
        z.d = z.gcd(x.d, y.d);
        z.d = (x.d * y.d) / z.d;
        z.n = (x.n) * (z.d / x.d) + y.n * (z.d / y.d);
        z.Reduce();

        return z;
    }

    public static Fraction operator -(Fraction x, Fraction y)
    {
        Fraction z = new Fraction();
        if (y.d == 1){

            y.w += y.n;
            y.n = 0;
            y.d = 1;
        }   
        else if (x.d == 1){

            x.w += x.n;
            x.n = 0;
            x.d = 1;
        }

        z.w = x.w - y.w;
        z.d = z.gcd(x.d, y.d);
        z.d = (x.d * y.d) / z.d;
        z.n = (x.n) * (z.d / x.d) - y.n * (z.d / y.d);
        z.Reduce();

        return z;
    }

    public static Fraction operator *(Fraction x, Fraction y)
    {
        Fraction z = new Fraction();
        if (x.w != 0){

            x.n += x.w * x.d;
            x.w = 0;
        }  
        else if (y.w != 0){

            y.n += y.w * y.d;
            y.w = 0;
        }

        z.n = x.n * y.n;
        z.d = x.d * y.d;
        z.Reduce();

        return z;
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        Fraction c = new Fraction();
        if (a.w != 0){

            a.n += a.w * a.d;
            a.w = 0;
        }
        else if (b.w != 0){

            b.n += b.w * b.d;
            b.w = 0;
        }
        c.n = a.n * b.d;
        c.d = a.d * b.n;

        c.Reduce();

        return c;
    }

    public string Display()
    {
        string temp = "";

        if (this.w == 0){

            if (this.d == 1){

                temp = Convert.ToString(this.n);
            }  
            else if (this.n != 0){

                temp = this.n + "/" + this.d;
            }
        }
        else{

            temp = Convert.ToString(this.w);

            if (this.d == 1 && this.n != 0){

                temp = " " + Convert.ToString(this.w + this.n);
            }
            else if (this.n != 0){

                temp += " " + this.n + "/" + this.d;
            }
        }

        return temp;
    }
}
