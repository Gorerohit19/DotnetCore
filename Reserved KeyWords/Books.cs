namespace Library;
class Book
{
    public Book()
    {
        this.titles[0]="Mogli in Jungle";
        this.titles[1]="Mahabharat";
        this.titles[2]="Ramayan";
        this.titles[3]="Raavan";
    }
    private string [] titles = new string [100] ;

    public string this [int index]
    {
        get {
            if( index < 0 || index >= 100)
            throw new Exception(" Index is less then Zero or Greater then 100 ");
            else
            return titles [index];
        }

        set {
            if(index < 0 || index >= 100)
            throw new Exception(" Index is less then Zero or Greater the 100");
            else 
            titles [index] = value;
        }
    }
}