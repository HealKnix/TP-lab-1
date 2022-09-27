using System;

namespace Task2 {
    public class Logic {
        public static string GetResult(int[] arr) {
            string str = "";
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i] == arr[i + 1]) {
                    count++;
                    if (count == 1) {
                        str += (i + 1) + " ";
                    }
                } else {
                    count = 0;
                }
            }
            return str;
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите кол-во вводимых значений");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write($"[{i + 1}] - ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            string str = Logic.GetResult(arr);

            Console.WriteLine("Порядковые номера чисел первой из пар");
            Console.WriteLine(str);
        }
    }
}
