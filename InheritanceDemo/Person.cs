namespace Ecommerce
{

    public class Person
{
    protected string firstName;
    protected string lastName;
    protected string email;
    protected string contactNumber;


public Person(){
    this.firstName="Rohit";
    this.lastName="Gore";
    this.email="gore.rohit1902@gmail.com";
    this.contactNumber="7378982802";
}

public Person(string fName, string lName, string em, string contact)
{
    this.firstName=fName;
    this.lastName=lName;
    this.email=em;
    this.contactNumber=contact;
}
}
}
