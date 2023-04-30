namespace Library
{
    public class books
    {
        private string [] titles = new string [100];

        //Indexer
        public string this [int index]
        {
            get {
                if( index < 0 || index >= 100)
                    throw new Exception (" Index is less then Zero or Greater then Hundred");
                else
                    return titles [index];
            }

            set{
                if( index < 0 || index >= 100)
                    throw new Exception("Index is less then Zero or Greater then Hundred");
                else
                    titles [index]= value;
            }
        }
    }
}