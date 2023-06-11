namespace Delegates;

public class Program
{
    static void Main(string[] args)
    {
        //FuncExample();
        ActionExample();
    }
       
    public static int Sum(int num1, int num2) => num1 + num2;
    public static void FuncExample() {
        var delegate1 = Sum;
        Console.WriteLine(  delegate1);
        Console.WriteLine(delegate1(1, 2));

        // explicita
        Func<int,int,int> delegate2 = Sum;
        Console.WriteLine(delegate2);
        Console.WriteLine(delegate2(1, 2));

        // anonymous
        Func<int, int, int> delegate3 = delegate (int num1, int num2) { return num1 + num2; };
        Console.WriteLine(delegate3);
        Console.WriteLine(delegate3(1, 2));

        // lambda
        Func<int, int, int> delegate4 = (int num1, int num2) => num1 + num2;
        Console.WriteLine(delegate4);
        Console.WriteLine(delegate4(1, 2));

    }

    public static void Log(string mensaje) => Console.WriteLine(mensaje);
    public static void ActionExample() {
        var delegate1 = Log;
        Console.WriteLine(delegate1);
        delegate1("Mensaje");

        //Explicit
        Action<string> delegate2 = Log;
        Console.WriteLine(delegate2);
        delegate2("Mensaje");

        //Anonymous
        Action<string> delegate3 = delegate (string mensaje) { Console.WriteLine(mensaje); };
        Console.WriteLine(delegate3);
        delegate3("Mensaje");

        //Lambda
        Action<string> delegate4 = (string mensaje) => Console.WriteLine(mensaje);
        Console.WriteLine(delegate4);
        delegate4("Mensaje");

    }
    public static void PredicateExample() { }
    public static void PredicateWithArrayExample() { }
    public static void PredicateWithLinqExample() { }
}