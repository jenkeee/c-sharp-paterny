using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int numberForAnalis;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Здравствуйте вас приветствует математическая программа которая посчитает \n\t1. Факториал числа" +
                        "\n\t2. Сумму чисел от 1 до введенного числа, включая \n\t3. Масимальное четное число, которое меньше введенного");
                    Console.WriteLine("\n\tПожалуйста введите целое, положительное число\n\tВы всегда можете ввести Q,q,exit,Exit,quit для выхода");

                    s = Console.ReadLine();
                    if (int.TryParse(s, out numberForAnalis) && numberForAnalis > 0)
                    {
                        //на уроке поговорили про патерны, и логична ли следующая запись, где мы ретерн метода делаем переменной  
                        int factorial = Factorial(numberForAnalis);
                    int summaToNum = SummaFromNum(numberForAnalis);
                    int lessNum = SmalleThenNum(numberForAnalis);
                    string lessyNum;
                    if (numberForAnalis == lessNum)
                        lessyNum = "\n\tВот незадача, нет натуральных четных чисел меньше 2.\n\tСитуацию с отрицательными числами не стал обрабатывать.";
                    else lessyNum = lessNum.ToString();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"\tФакториал числа {numberForAnalis} = {factorial}");
                    Console.WriteLine($"\tСумма всех положительных целых чисел от 1 до { numberForAnalis} = {summaToNum}");
                    Console.WriteLine($"\tМаксимальное четное число меньше {numberForAnalis} = {lessyNum}");
                }
                    else if (!int.TryParse(s, out numberForAnalis))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tПожалуйста вводите целые числа, к примеру 1,2,3,-1;\n\tДавайте начнем все сначала\n\tДля продолжения нажмите любую клавишу");
                        Console.ReadKey();
                    }

                    else if (numberForAnalis == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tВы ввели 0, и что с этим делать?\n\tДавайте начнем все сначала\n\tДля продолжения нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else if (numberForAnalis < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tВы ввели отрицательное число, и что с этим делать?\n\tДавайте начнем все сначала\n\tДля продолжения нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else if (s == "Q" | s == "q" || s == "exit" || s == "Exit" || s == "quit") Environment.Exit(0);

                    else
                    {
                        Console.WriteLine("Пожалуйста вводи целые числ");
                    }
                } while (numberForAnalis <= 0);
            Console.ReadKey();
        }


        static int Factorial(int num) // 0 мы сюда не получим поэтому не буду обрабатывать 0
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
              factorial = num * i;
            }
            return factorial;
        }

        static int SummaFromNum(int num)
        {
            int summaToNum = 0; 
            for (int i = 1; i <= num; i++)
            {
                summaToNum += i;
            }

            return summaToNum; 
        }
        static int SmalleThenNum(int num)
        {
            int smallerNum = num;
            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    smallerNum = i;
                }
            }
            return smallerNum;
        }
    }
}
