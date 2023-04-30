namespace  SingletonDesignPattern
{
    sealed class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton getInstance = null;
        public static Singleton MyObject()
        {
            if(getInstance == null)
            {
                return new Singleton();
            }
            return getInstance;
        }
        public void MyMethod()
        {
            Console.WriteLine("This is MyMethod");
        }
    }
}