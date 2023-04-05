namespace GDI;
    public class Shape
    {
        protected string color;
         
        /*
        Defult Contractor 
        */
        public Shape()
        {
            this.color="Blue";
        }

        //Parameteries Constracture

        public Shape(string c)
        {
            this.color=c;
        }

        // Properties(Get, Set)

        public string Getcolor()
        {
            return this.color;
        }

        public string Setcolor(string c)
        {
            return this.color=c;
        }
        
        //Destractor 
        ~Shape()
        {
            Console.WriteLine(" Deinitializing Instance");
        }
    }
