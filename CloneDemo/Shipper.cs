using System;
using System.Collections;

namespace TFL;

public class Shipper : ICloneable
{
    public int id;
    public string name;

    public Shipper()
    {
        this.id=15;
        this.name="CDCL Couriers";
    }

    public Shipper(int i , string nm)
    {
        this.id=i;
        this.name=nm;
    }

    public object Clone()
    {
       //Logic for creating replica of same object as another new objec
     Shipper temp = new Shipper();
     temp.id=this.id;
     temp.name=this.name;
     //temp is pointing to newly created and 
    //data copied object using clonning technique
    return temp;
    }

    public override string ToString()
    {
        return "Id="+id + " " + "Name="+name;
    }
}