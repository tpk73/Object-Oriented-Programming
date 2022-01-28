using System;


class Date
{
    
    private int d;
    private int m;
    private int y;


    public int Day{

        get{return d;}   

        set
        {
            // check for a valid day
            if (value > 31 || value < 1){

                Console.WriteLine("Invalid day");
            }

            d = value;
        }
    }

    public int Month{

        get{return m;}

        set
        {
            // check for a valid year
            if (value > 12 || value < 1){

                Console.WriteLine("Invalid month");
            }

            m = value;
        }
    }

    public int Year{
        
        get{return y;}

        set
        {
            // check for correct input on the year
            if (Convert.ToString(value).Length != 4){

                Console.WriteLine("Year must be 4 digits");
            }

            y = value;
        }
    }

    // default MyBday
    public Date(){
        
        d = 9;
        m = 6;
        y = 1998;
    }

    public Date(int m, int d, int y){

        this.Month = m;
        this.Day = d;
        this.Year = y;
    }

    // US Format
    public string DisplayUSFormat(){

        if (this.Month <= 12 && this.Month >= 1){

            if (this.Day <= 31 && this.Day >= 1){

                if (Convert.ToString(this.Year).Length == 4){

                    return this.Month.ToString("D2") + "/" + this.Day.ToString("D2") + "/" + this.Year;
                }
            }
        }

        return "Invalid date";
    }

    // Int Format
    public string DisplayIntlFormat(){

        if (this.Month <= 12 && this.Month >= 1){

            if (this.Day <= 31 && this.Day >= 1){

                if (Convert.ToString(this.Year).Length == 4){

                    return this.Year + "-" + this.Month.ToString("D2") + "-" + this.Day.ToString("D2");
                }
            }
        }

        return "Invalid date";
    }
}

// Testing Code from Canvas

class Program{

    static void Main(string[] args){

        Date b = new Date();
        b.Day = 1;
        b.Year = 1996;
        b.Month = 12;

        Console.WriteLine(b.Day);


        Date c = new Date();
        c.Day = 7;
        c.Year = 1980;
        c.Month = 8;
        Console.WriteLine(c.DisplayIntlFormat());
        Console.WriteLine(c.DisplayUSFormat());

        Date d = new Date(12, 30, 2000);
        d.Day = 32;
        Console.WriteLine(d.DisplayUSFormat());
        d.Month = 13;
        Console.WriteLine(d.DisplayUSFormat());
        d.Year = 123;
        Console.WriteLine(d.DisplayUSFormat());
    }
}
