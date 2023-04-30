namespace Array
{
    class Test1
    {
        public static void ViewNames(params string [] names)
        {
          foreach(string name in names)
          {
            Console.WriteLine (name + "\n");
          }
        }
    }
}