

namespace HR;

public class Person
{
    public string FirstName {get; set;}

    private string lastName;

    public string LastName{
        get{return lastName;}
        set{
            if (value == "")
            {
                throw new Exception("Last Name can not be Blank");
            }
            else
            {
                lastName = value;
            }
            }
        }

    public DateTime DateOfBirth {get; set;}

    //Contractor Chaining
    public Person():this("Gaurav","Desai", new DateTime(1999,3,25))
    {
        /*
        this.FirstName="Rohit";
        this.LastName="Gore";
        this.DateOfBirth=2000,2,19;
        */
       
    }

    public Person(string fName, string lName, DateTime bDate)
    {
        this.FirstName=fName;
        this.LastName=lName;
        this.DateOfBirth=bDate;
    }

    ~Person()
    {
 
    }

    public override string ToString()
    {
        string str = string.Empty;
        str = string.Format("{0} {1} {2}", this.FirstName, this.LastName, this.DateOfBirth);
        return str;
    }


    
}