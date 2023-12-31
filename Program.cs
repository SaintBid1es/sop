﻿namespace proba
{
    internal class Program
    {
        static void Main()
        {
            tortik NewCake = new tortik();
            Dictionary<string, string> SubMessages = new Dictionary<string, string> { { "Shapes", null }, { "Size", null }, { "Korj_amount", null }, { "Korj_Taste", null }, { "Glazure", null }, { "Decoration", null } };

            ConsoleKeyInfo key;
            int position;
            do
            {
                Console.Clear();
                ShowMenuHeader(NewCake);


                position = Menu.Show();

                if (position == 3)
                {

                    NewCake.Shape = forma_torta();


                }
                else if (position == 4)
                {
                    NewCake.Size = razmer();


                }
                else if (position == 5)
                {
                    NewCake.korj_Taste = Bkys();


                }
                else if (position == 6)
                {
                    NewCake.korj_amount = kolichestvo();


                }
                else if (position == 7)
                {
                    NewCake.Glazure = glazuri();


                }
                else if (position == 8)
                {
                    NewCake.Decoration = decor();


                }
                else if (position == 9)
                {
                    konec(NewCake);
                }
            } while (position > 0);
        }

        static void ShowMenuHeader(tortik Cake)
        {
            List<string> pervaya = new List<string>() { "Заказ тортов в ГЛАЗУРЬКА,торты на ваш выбор!\nВыбор параметра торта\n---------------------- \n    1.Форма торта \n    2.Размер торта\n    3.Вкус коржей\n    4.Количество коржей\n    5.Глазурь\n    6.Декор\n    7.Конец Заказа" };

            Console.WriteLine(pervaya[0]);
            Console.WriteLine("\nЦена: " + Cake.TotalPrice + "\nВаш торт:");


        }
        static string forma_torta()
        {
            int position;
            Console.Clear();

            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню :\n--------------------\n   Круг - 500\n   Квадрат - 500\n   Ромб - 500\n   Сердечко - 700");
            position = Menu.Show(6);
            switch (position)
            {
                case 3:
                    return "Круг";


                case 4:
                    return "Квадрат";

                case 5:
                    return "Ромб";

                case 6:
                    return "Сердечко";
                default: return null;
            }

        }
        static string razmer()
        {
            int position;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape ");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("--------------------------");
            Console.WriteLine("   Маленький(Диаметр - 16 см,8 порций ) - 1000\n   Обычный(Диаметр-18 см,10 порций) - 1200 \n  Большой(Диаметр - 28 см,24 порций) - 2000 ");
            position = Menu.Show(5);
            switch (position)
            {
                case 3:
                    return "Маленький";


                case 4:
                    return "Обычный";

                case 5:
                    return "Большой";

                default: return null;
            }
        }
        static string Bkys()
        {
            int position;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("   Ванильный - 100 \n   Шоколадный - 100\n   Карамельный - 150\n   Ягодный - 200 \n   Кокосовый - 250 ");
            position = Menu.Show(7);
            switch (position)
            {
                case 3:
                    return "Ванильный";


                case 4:
                    return "Шоколадный";

                case 5:
                    return "Карамельный";

                case 6:
                    return "Ягодный";
                case 7:
                    return "Кокосовый";
                default: return null;
            }

        }
        static int? kolichestvo()
        {
            int position;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("   1 корж - 200\n   2 коржа - 400 \n   3 коржа - 600\n 4 коржа - 800");
            position = Menu.Show(6);
            switch (position)
            {
                case 3:
                    return 1;


                case 4:
                    return 2;

                case 5:
                    return 3;

                case 6:
                    return 4;
                default: return null;
            }

        }
        static string glazuri()
        {
            int position;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("   Шоколад - 100 \n   Крем - 100\n   Бизе - 150 \n   Драже - 150 \n   Ягоды - 200 ");
            position = Menu.Show(7);
            switch (position)
            {
                case 3:
                    return "Шоколад";


                case 4:
                    return "Крем";

                case 5:
                    return "Бизе";

                case 6:
                    return "Драже";
                case 7:
                    return "Ягоды";
                default: return null;
            }

        }
        static string decor()
        {
            int position;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("   Шоколадная - 150 \n   Ягодная - 150 \n   Кремовая - 150");
            position = Menu.Show(5);
            switch (position)
            {
                case 3:
                    return "Шоколадная";


                case 4:
                    return "Ягодная";

                case 5:
                    return "Кремовая";


                default: return null;
            }
        }

        static void konec(tortik SomeCake)
        {
            string message = SomeCake.CreateMessage();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Orders.txt";
            if (!File.Exists(path))

                File.Create(path);
            using (var Writer = new StreamWriter(path,true))
            {
                Writer.WriteLine(message);
            }
            Console.Clear();

            Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один нажмите на Escape");
            Console.WriteLine(message);
            Console.ReadLine();
        }



    }
}
    
