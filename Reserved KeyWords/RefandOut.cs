namespace Referance;
public class DemoClass
{
    public static void Swap (ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2=temp;
    }

    public static void Calculate (float radius, out float area, out float circum)
    {
        area = 3.14f * radius * radius;
        circum = 2 * 3.14f *radius;
    }
}