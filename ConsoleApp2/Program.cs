namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //задние 1
            Console.WriteLine("Введите строку строчными буквами\n");

            char[] str = Console.ReadLine().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    str[i] = Char.ToUpper(str[i]);
                }
            }

            Console.WriteLine(str);



            //задание 2
            Console.WriteLine("Введите число от 0 до 1000\n");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0 || a > 1000) { Console.WriteLine("Ваше число меньше или равно 0; больше 1000"); }
            else
            {
                for (int i = 0; i <= a; i++)
                {

                    Console.WriteLine(i + "\t");
                }
            }



            //задание 3
            Console.WriteLine("Введите строку из 5 элементов\n");

            string[] Arr1 = new string[5];

            for (int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}\n");
                Arr1[i] = Console.ReadLine();
            }

            Console.WriteLine("Развернутый массив: \n");

            for (int i = Arr1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{Arr1[i]}\n");
            }

            //задание 3 версия 2
            Console.WriteLine("Введите строку из 5 элементов\n");

            string[] Arr2 = new string[5];

            for (int i = 0; i < Arr2.Length; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}\n");
                Arr2[i] = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", Arr2));

            Console.WriteLine(string.Join(" ", Arr2.Reverse()));
        }
    }
}