using System;

namespace Task1 {
    public class Logic {
        private class Time {
            private int h;
            private int m;

            public Time(string status) {
                Console.WriteLine(status);

                h = int.Parse(Console.ReadLine());
                while (!(0 <= h && h <= 23)) {
                    Console.WriteLine("Ошибка ввода Часа (1-23)\nПовторите попытку");
                    h = int.Parse(Console.ReadLine());
                }

                m = int.Parse(Console.ReadLine());
                while (!(0 <= m && m <= 59)) {
                    Console.WriteLine("Ошибка ввода Минут (1-59)\nПовторите попытку");
                    m = int.Parse(Console.ReadLine());
                }
            }

            public int GetH() {
                return h;
            }

            public int GetM() {
                return m;
            }
        }

        static Time[] time = {
            new Time("Введите Час и Минуту прибытия поезда"), 
            new Time("Введите Час и Минуту отбытия поезда"),
            new Time("Введите Час и Минуту прибытия пассажира")
        };

        public static string Conditions(int a, int b, int c, int d, int n, int m) {
			if ((a < n && n < c) ||
				((a < n || n < c) && (c < a)) ||
				(((a >= n && n > c) && (c < a) && !(n < a)) && !(m <= b)) ||
                ((a > n && c == n) && (m < d)) ||
                ((a == n && c > n) && (m > b)) ||
                ((a < n && c == n) && (m < d)) ||
                ((a == n && c < n) && (m > b))) {
				return "Поезд стоит на платформе";
			} else {
				return "Поезд не стоит на платформе";
			}
		}

        public static void GetResult() {
            int a = time[0].GetH(), b = time[0].GetM(),
                c = time[1].GetH(), d = time[1].GetM(),
                n = time[2].GetH(), m = time[2].GetM();

            Console.WriteLine(Conditions(a, b, c, d, n, m));
        }
    }

    class Program {
        static void Main(string[] args) {
            Logic.GetResult();
        }
    }
}
