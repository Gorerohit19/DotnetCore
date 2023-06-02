using System;
using System.Collections.Generic;


namespace MobileCollection;
public class Mobile:IEquatable<Mobile>
{
    public  string MobileCompany {get; set;}
    public  int ModelNumber {get; set;}
    public string ModelName {get; set;}
    public double Price {get; set;} 

    public Mobile()
    {
        this.MobileCompany="Xiaomi";
        this.ModelNumber=1;
        this.ModelName="Note 11 pro";
        this.Price=20000;
    }
    
    public Mobile(string company, int modelNumber, string modelName, double price)
    {
        this.MobileCompany=company;
        this.ModelNumber=modelNumber;
        this.ModelName=modelName;
        this.Price=price;
    }

    public override string ToString()
    {
        return this.MobileCompany +" " + this.ModelName + " " + this.ModelNumber + " " + this.Price;
    }

    public override bool Equals(object? obj)
    {
        if(obj == null){
            return false;
        }
        Mobile objAsMobile = obj as Mobile;
        if(objAsMobile == null)
        {
            return false;
        }
        else
        {
            return Equals(objAsMobile);
        }
    }

    public override int GetHashCode()
    {
        return ModelNumber;
    }

    public bool Equals(Mobile other)
    {
        if(other == null)
        {
            return false;
        }
        else
        {
            return (this.ModelNumber.Equals(other.ModelNumber));
        }
    }
}