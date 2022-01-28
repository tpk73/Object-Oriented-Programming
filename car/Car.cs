using System;

class Car {

    // TODO: declare all attrinutes here (Step 1).
    private int idNumber;
    private string make;
    private string model;
    private string color;
    private double value;
    
    // TODO: declare methods here (Step 2).
    public int getIdNumber(){ // returns the Car ID number

        return idNumber;
    }	

    public void setIdNumber(int id){ // modifies the ID number to id

        idNumber = id;
    }

    public string getMake(){ // returns the make of the Car

        return make;
    }	

    public void setMake(string new_make){ //changes the Car make to new_make

        make = new_make;
    }

    public string getColor(){ // returns the color of the Car

        return color;
    }	

    public void setColor(string new_color){ // changes the Car color to new_color

        color = new_color;
    }

    public string getModel(){ // returns the make of the Car.

        return model;
    }

    public void setModel(string new_model){ // changes the Car model to new_model

        model = new_model;
    }	

    public double getValue(){ // returns the value of the Car

        return value;
    }

    public void setValue(double new_value){ // changes value of the Car to new_value

        value = new_value;
    }	

    // Default constructor.
    public Car() {
        
        idNumber = 0;
        make = "Car";
        model = "Sedan";
        color = "White";
        value = 1000;

    }

    // TODO: create nother constructor as described below here (Step 3).
    public Car( int car_number, string car_make, string car_model, string car_color, double car_value ){

        idNumber = car_number;
        make = car_make;
        model = car_model;
        color = car_color;
        value = car_value;
    }
}
