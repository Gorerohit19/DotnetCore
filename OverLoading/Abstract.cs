namespace Abstract;
public abstract class animal 
{
    public abstract void eat();
    public void sound() {
        Console.WriteLine("dog can sound");
    }
}

public class dog: animal {
    public override void eat() {
        Console.WriteLine("dog can eat");
    }
}