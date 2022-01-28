using System;

public interface ISellable
{
    void SalesSpeech();
    void MakeSale(int x);
}

abstract class Salesperson
{
    protected string fName { get; set; }
    protected string lName { get; set; }

    public string GetName(){

        return fName + " " + lName;
    }
}

class RealEstateSalesperson : Salesperson, ISellable
{
    public int TotalValueSold { get; set; }
    public int TotalCommissionEarned { get; set; }
    public double CommissionRate;

    public RealEstateSalesperson(string F_Name, string L_Name, double C_Rate){

        fName = F_Name;
        lName = L_Name;
        TotalValueSold = 0;
        TotalCommissionEarned = 0;
        CommissionRate = C_Rate;
    }

    public void SalesSpeech(){

        Console.WriteLine("This property will double in value in the next ten years");
        Console.WriteLine("Buy it now or regret it forever.");
        Console.WriteLine();
        return;
    }

    public void MakeSale(int x){

        TotalValueSold += x;
        double temp = Convert.ToDouble(x) * CommissionRate;
        TotalCommissionEarned += Convert.ToInt32(temp);
        return;
    }
}

class GirlScout : Salesperson, ISellable
{
    public int TotalBoxes { get; set; }

    public GirlScout(string F_Name, string L_Name){

        fName = F_Name;
        lName = L_Name;
        TotalBoxes = 0;
    }

    public void SalesSpeech(){

        Console.WriteLine("Would you like to buy some cookies?");
        Console.WriteLine("They are delicious and they help us go to camp.");
        Console.WriteLine();
        return;
    }

    public void MakeSale(int x){

        TotalBoxes += x;
        return;
    }
}