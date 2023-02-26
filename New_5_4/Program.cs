namespace New_5_4
{
    internal class Program
    {
        static int num1 = 667; //Эта переменная будет видна в контексте класса


        static void Main(string[] args)
        {
            Console.WriteLine(num1);
            Console.WriteLine(Sum());
            if (num1 > 0)
            {
                var num3 = 5;  // Контекст блока кода
                Console.WriteLine(num1 + num3);
            }
        }
        static int Sum() 

        {
            var num2 = 1; //Контекст метода              
            var num1 = 2; // если мы используем совпадающие имена в локальном контексте и контексте уровня класса, то приоритетным будет локальный контекст.
            return num1 - num2;


        }
    }
}