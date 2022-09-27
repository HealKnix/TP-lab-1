using System;

namespace Task3 {
    public class Logic {
        public static int ConvertAndCalculate(string str) {
            int sum = int.Parse(str[0].ToString());
            for (int i = 2; i < str.Length; i += 2) {
                char symb = str[i - 1];
                if (symb == '+') {
                    sum += int.Parse(str[i].ToString());
                }
                else if (symb == '-') {
                    sum -= int.Parse(str[i].ToString());
                }
            }

            return sum;
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите текст, имеющий вид: d1 ± d2 ± . . . ± dn, где di — цифры (n > 1)");

            string str = Console.ReadLine();
            while (str.Length < 3) {
                Console.WriteLine("Ошибка! n должно быть больше 1");
                str = Console.ReadLine();
            }

            int sum = Logic.ConvertAndCalculate(str);

            Console.WriteLine(sum);
        }
    }
}
