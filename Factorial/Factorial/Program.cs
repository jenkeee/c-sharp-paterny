using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
          //  3. * Есть файл с программой, его нужно отрефакторить
          // тут чтото не так, вроде факториал считаем. 
          // факториал числа N - это произведение всех натуральных чисел от 1 до N включительно
          // натуральное число - целое число больше нуля
          // пример 
          //0! = 1
          //1! = 1
          // 2!= 1*2 =2
          //3! = 1*2*3 = 6
          //4! = 1*2*3*4 = 24
          //5!= 1*2*3*4*5 = 120
          //n! = (n-1)! *n

                Console.WriteLine("Здравствуйте вас приветствует математическая программа");
                Console.WriteLine("пажалуйста введите число. ");

                string chislo = Console.ReadLine(); // 

                if (chislo == "q") // если q выход  
                {
                    return; 
                }
                int M = Int32.Parse(chislo);
                int c1 = 1; int c2 = 0;
                int c3 = 0;
                for (int i = 1; i <= M; i++)
                {
                    c1 = c1 * i;
                    c2 = c2 + i;
                    if (i % 2 == 0)
                    {
                        c3 = i;
                    }
                }
                Console.WriteLine("Факториал равет " + c1);
            Console.WriteLine("Сума от 1 до N равна " + c2);
                Console.WriteLine("максимальное четное число меньше N равно" + c3);
            // математическая программа будет считать факториал введенного числа, потом сумму всех чисел от 1 до введенного числа,
            // а потом возвращать максимальное четное число которое меньше введенного числа
                Console.ReadLine();
            }
        }

    }

