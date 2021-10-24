using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            int Sum = 0;

            //int test1;
            //int test2;

            do
            {
                Console.WriteLine("Раунд {0} начат", z);

                Console.WriteLine("Для броска введите 1");
                string str = Convert.ToString(Console.ReadLine());
                if (str == "1")
                {
                    int[] mas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    Random rnd = new Random();
                    int num;
                    int keg = 0;
                    int a = rnd.Next(0, 11);
                    Console.WriteLine("Тест: Количество выбитых кеголь в первый раз  a = {0}", a);
                    Console.WriteLine("Первый бросок:");
                    if (a == 10) Console.WriteLine("Игрок выбил страйк!");

                    else
                    {
                        for (int i = 0; i < a; i++)
                        {
                            num = rnd.Next(0, 9);
                            mas[num] = 1;
                        }
                        Console.WriteLine();
                        for (int i = 0; i < mas.Length; i++)
                        {
                            if (mas[i] == 1)
                            {
                                Sum += 1;
                                keg += 1;
                            }
                            Console.Write(mas[i] + "\t");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Игрок выбил {0} кегель", keg);
                        Console.WriteLine("Игрок набрал всего {0} очков", Sum);
                        Console.WriteLine();




                        Console.WriteLine("Для броска введиет 1");
                        str = Convert.ToString(Console.ReadLine());
                        if (str == "1")
                        {
                            Console.WriteLine("Второй бросок:");
                            int q = 10 - keg;
                            Console.WriteLine("Новая длина второго массива q = {0}", q);
                            int[] mas1 = new int[q];
                            int a1 = rnd.Next(0, q + 1);

                            if (a1 == 10) Console.WriteLine("Игрок выбил страйк!");
                            else
                            {

                                Console.WriteLine("Тест: Новое количество выбитых кегель во второй раз a1 = {0}", a1);
                                Console.WriteLine();
                                Console.Write("Просмотр нового массива mas1 \t = " + "\t");
                                for (int i = 0; i < mas1.Length; i++)
                                {
                                    mas1[i] = 0;
                                    Console.Write(mas1[i] + "\t");
                                }
                                Console.WriteLine();
                                for (int i = 0; i < a1; i++)
                                {
                                    num = rnd.Next(0, q);
                                    mas1[num] = 1;
                                }
                                Console.WriteLine();
                                Console.Write("Просмотр второго массива после выбитых кегель mas1 = \t");
                                for (int i = 0; i < mas1.Length; i++)
                                {
                                    Console.Write(mas1[i] + "\t");
                                }
                                Console.WriteLine();
                                keg = 0;
                                for (int i = 0; i < mas1.Length; i++)
                                {
                                    if (mas1[i] == 1)
                                    {
                                        Sum += 1;
                                        keg += 1;
                                    }
                                    Console.Write(mas[i] + "\t");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Игрок выбил {0} кегель", keg);
                                Console.WriteLine("Игрок набрал всего {0} очков", Sum);
                                Console.WriteLine();
                            }
                        }
                    }
                }
                Console.WriteLine("Раунд {0} окончен", z);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //test1 = a;
                //test2 = a1;
                z++;
            } while (true);
        }
    }
}
