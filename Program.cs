class Program
{
    static void Main(string[] args)
    {
        Calculate();
    }

    public static void Calculate()
    {
        Console.WriteLine("Welcome to Calculator");
        Console.WriteLine("Sum: 1");
        Console.WriteLine("Sub: 2");
        Console.WriteLine("Mul: 3");
        Console.WriteLine("Div: 4");
        Console.WriteLine("Exit: 0");
        string n = Console.ReadLine();
        switch (n)
        {
            case "1" : Sum(); break;
            case "2" : Sub(); break;
            case "3" : Mul(); break;    
            case "4" : Div(); break;
            case "0" : break;
        }
    }
    public static void Sum()
    {
            System.Console.WriteLine("Enter first value: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter second value: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Value: {a + b}");
            Console.ReadLine();
            Calculate();
    }

    public static void Sub()
    {
        System.Console.WriteLine("Enter First value: ");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Second value: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Value: {a - b}"); 
        Console.ReadLine(); 
        Calculate();
    }

    public static void Mul()
    { 
        System.Console.WriteLine("Enter first value:"); 
        int a = int.Parse(Console.ReadLine()); 
        System.Console.WriteLine("Enter second value: "); 
        int b = int.Parse(Console.ReadLine()); 
        Console.WriteLine($"Value: {a * b}"); 
        Console.ReadLine(); 
        Calculate();
    }
    public static void Div() 
    { 
        System.Console.WriteLine("Enter first value:"); 
        double a = double.Parse(Console.ReadLine()); 
        System.Console.WriteLine("Enter second value: "); 
        double b = double.Parse(Console.ReadLine()); 
        System.Console.WriteLine($"Value: {a / b:F2}"); 
        Console.ReadLine(); 
        Calculate();
    }
}