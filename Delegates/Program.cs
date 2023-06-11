namespace Delegates;

public class Program
{
    static void Main(string[] args)
    {
        //FuncExample();
        //ActionExample();
        //PredicateExample();
        //PredicateWithArrayExample();
        PredicateWithLinqExample();

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


    public static bool isEven(int num) => num %2 == 0;
    public static void PredicateExample() {

        var delegate1 = isEven;
        Console.WriteLine(delegate1);
        Console.WriteLine(delegate1(2));

        //Explict
        Predicate<int> delegate2 = isEven;
        Console.WriteLine(delegate2);
        Console.WriteLine(delegate2(2));

        //Anonymous
        Predicate<int> delegate3 = delegate (int num) { return num % 2 == 0; };
        Console.WriteLine(delegate3);
        Console.WriteLine(delegate3(2));

        //Lambda
        Predicate<int> delegate4 = (int num) => num % 2 == 0;
        Console.WriteLine(delegate4);
        Console.WriteLine(delegate4(2));


    }
    public static void PredicateWithArrayExample()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var Evens = Array.FindAll(nums, isEven);
        foreach (var item in Evens)
            Console.WriteLine(item);

        var Evens2 = Array.FindAll(nums, (num) => num %2 == 0);
        foreach (var item in Evens2)
            Console.WriteLine(item);

    }
    public static void PredicateWithLinqExample() { 

        List<People> list = new List<People>();
        list.Add(new People() {Name="Mauro", Age = 37 });
        list.Add(new People() { Name = "Regina", Age = 2 });
        list.Add(new People() { Name = "Diego", Age = 19});
        list.Add(new People() { Name = "Ana", Age = 15 });
        list.Add(new People() { Name = "Luis", Age = 22 });

        // Listar las Age>18
        var list2= list.Where(isGreater);
        foreach (var item in list2)
            Console.WriteLine($"Name: {item.Name} Age:{item.Age}");
        



    }
    public static bool isGreater(People people) => people.Age > 18;
}

public class People {
    public string Name { get; set; }
    public int Age { get; set; }
}

