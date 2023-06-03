using System;
using System.Linq;

//Задание 3 часть 2 задача 1
//Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую.
//Пользователь с помощью меню выбирает направление перевода.
//Например, из десятичной в двоичную.
//После выбора направления, пользователь вводит число в исходной системе исчисления.
//Приложение должно перевести число в требуемую систему.
//Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.
//
//Задание 3 часть 2 задача 2
//Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру.
//Например, если пользователь ввёл "five", приложение должно вывести на экран 5.
//
//Задание 3 часть 2 задача 3
//Создайте класс «Заграничный паспорт».
//Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д.
//Предусмотреть механизмы для инициализации полей класса.
//Если значение для инициализации неверное, генерируйте исключение.
//
//Задание 3 часть 2 задача 4
//Пользователь вводит в строку с клавиатуры логическое выражение.
//Например, 3>2 или 7<3.
//Программа должна посчитать результат введенного выражения и дать результат true или false.
//В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=.
//Для обработки ошибок ввода используйте механизм исключений.

namespace HomeWork_N3P2
{
    class ForeignPassport
    {
        //Создайте класс «Заграничный паспорт».
        //Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д.
        //Предусмотреть механизмы для инициализации полей класса.
        //Если значение для инициализации неверное, генерируйте исключение.
        private int _passportNumber;
        public int PassportNumber 
        {
            get { return _passportNumber; } 
            set
            {
                if (value <1000000 && value > 99999)
                {
                    _passportNumber = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введенные данные не могут быть номером загранпаспорта.");
                }
            }
        }
        private string _firstName;
        public string FirstName 
        {
            get { return _firstName; }
            set
            {
                if (!value.Contains(' '))
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Имя не может содержать пробелы.");
                }
            }
        }
        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (!value.Contains(' '))
                {
                    _middleName = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Отчество не может содержать пробелы.");
                }
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!value.Contains(' '))
                {
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Фамилия не может содержать пробелы.");
                }
            }
        }
        private DateTime _birthDate;
        public DateTime BirthDate 
        {
            get { return _birthDate; }
            set
            {
                if (value.Year > 1900 && value < DateTime.Now)
                {
                    _birthDate = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Дата рождения не может быть раньше ХХ века или позже текущего времени.");
                }
            }
        }
        private DateTime _dateOfIssue;
        public DateTime DateOfIssue 
        {
            get { return _dateOfIssue; }
            set
            {
                if (value.Year > (DateTime.Now.Year - 10) && value < DateTime.Now)
                {
                    _dateOfIssue = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Дата выдачи загранпаспорта не может быть позже текущего времени или загранпаспорт не может быть старше 10 лет.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t*** HOME WORK N3 Part 2 ***\n");
            Console.WriteLine("Выберите задачу из списка:\n");
            Console.WriteLine("\t1. Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую." +
                "Пользователь с помощью меню выбирает направление перевода." +
                "Например, из десятичной в двоичную." +
                "После выбора направления, пользователь вводит число в исходной системе исчисления." +
                "Приложение должно перевести число в требуемую систему." +
                "Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.");
            Console.WriteLine("\t2. Пользователь вводит словами цифру от 0 до 9." +
                "Приложение должно перевести слово в цифру." +
                "Например, если пользователь ввёл \"five\", приложение должно вывести на экран 5.");
            Console.WriteLine("\t3. Создайте класс «Заграничный паспорт»." +
                "Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д." +
                "Предусмотреть механизмы для инициализации полей класса." +
                "Если значение для инициализации неверное, генерируйте исключение.");
            Console.WriteLine("\t4. Пользователь вводит в строку с клавиатуры логическое выражение." +
                "Например, 3>2 или 7<3." +
                "Программа должна посчитать результат введенного выражения и дать результат true или false." +
                "В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=." +
                "Для обработки ошибок ввода используйте механизм исключений.");
            Console.WriteLine("\t5. Выход из программы.\n");
            Console.WriteLine("Введите номер задачи (цифру и Enter):\n");
            bool exit = false;
            do
            {
                UInt16 input;
                while (!UInt16.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Ошибка! Введенные данные невозможно преобразовать в положительное целое число. Попробуйте ещё раз.");
                }
                switch (input)
                {
                    case 1: Tasks.Task_1(); break;
                    case 2: Tasks.Task_2(); break;
                    case 3: Tasks.Task_3(); break;
                    case 4: Tasks.Task_4(); break;
                    case 5: exit = true;    break;
                    default: Console.WriteLine("Такого пункта нет в списке задач, попробуйте ещё раз."); break;
                }
            } while (!exit);
        }
    }
    class Tasks
    {
        public static void Task_1()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 3, часть 2. Задача 1. ***\n");
            Console.WriteLine("Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую." +
                "Пользователь с помощью меню выбирает направление перевода." +
                "Например, из десятичной в двоичную." +
                "После выбора направления, пользователь вводит число в исходной системе исчисления." +
                "Приложение должно перевести число в требуемую систему." +
                "Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.");

            Console.WriteLine("КАЛЬКУЛЯТОР ПЕРЕВОДА СИСТЕМ ИСЧИСЛЕНИЯ");
            Console.WriteLine("1. Перевод из десятичной в двоичную. (10 -> 2)");
            Console.WriteLine("2. Перевод из десятичной в восьмеричную. (10 -> 8)");
            Console.WriteLine("3. Перевод из десятичной в шестнадцатиричную. (10 -> 16)");
            Console.WriteLine("4. Перевод из двоичной в десятичную. (2 -> 10)");
            Console.WriteLine("5. Перевод из двоичной в восьмеричную. (2 -> 8)");
            Console.WriteLine("6. Перевод из двоичной в шестнадцатиричную. (2 -> 16)");
            Console.WriteLine("7. Перевод из восьмеричной в двоичную. (8 -> 2)");
            Console.WriteLine("8. Перевод из восьмеричной в десятичную. (8 -> 10)");
            Console.WriteLine("9. Перевод из восьмеричной в шестнадцатиричную. (8 -> 16)");
            Console.WriteLine("10. Перевод из шестнадцатиричной в двоичную. (16 -> 2)");
            Console.WriteLine("11. Перевод из шестнадцатиричной в восьмеричную. (16 -> 8)");
            Console.WriteLine("12. Перевод из шестнадцатиричной в десятичную. (16 -> 10)");
            Console.WriteLine("13. Выход в главное меню.");

            string select = Console.ReadLine();

            //Проверка корректности выбора
            bool check = false;
            while(check)
            {
                short sel;
                while (!Int16.TryParse(select, out sel))
                {
                    Console.WriteLine("Ошибка! Вы ввели не число. Попробуйте ввести номер пункта правильно:");
                }
                while (sel > 13 || sel < 1)
                {
                    Console.WriteLine("Ошибка! Такого пункта нет. Попробуйте ввести номер пункта правильно:");
                }
                check = true;
            }
            if(select == "13")
            {
                Program.Menu();
            }

            //Ввод исходных данных
            Console.Write("Введите исходное число, которое тебуется преобразовать: ");
            string input = Console.ReadLine();
            UInt16 in_sys = 10;
            UInt16 out_sys = 10;
            switch(select)
            {
                case "1":   in_sys = 10;    out_sys = 2;    break;
                case "2":   in_sys = 10;    out_sys = 8;    break;
                case "3":   in_sys = 10;    out_sys = 16;   break;
                case "4":   in_sys = 2;     out_sys = 10;   break;
                case "5":   in_sys = 2;     out_sys = 8;    break;
                case "6":   in_sys = 2;     out_sys = 16;   break;
                case "7":   in_sys = 8;     out_sys = 2;    break;
                case "8":   in_sys = 8;     out_sys = 10;   break;
                case "9":   in_sys = 8;     out_sys = 16;   break;
                case "10":  in_sys = 16;    out_sys = 2;    break;
                case "11":  in_sys = 16;    out_sys = 8;    break;
                case "12":  in_sys = 16;    out_sys = 10;   break;
            }

            //Обработка
            int input_number = 0;
            bool res = false;
            while (!res)
            {
                if (in_sys == 10)
                {
                    while (!Int32.TryParse(input, out input_number))
                    {
                        Console.WriteLine("Ошибка! Вы ввели слишком большое число. Попробуйте снова:");
                        input = Console.ReadLine();
                    }
                    res = true;
                }
                else
                {
                    try
                    {
                        input_number = Convert.ToInt32(input, in_sys);
                        res = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ошибка! Невозможно преобразовать введенные данные в число. Попробуйте ещё раз: ");
                        input = Console.ReadLine();
                        res = false;
                    }
                }
            }

            //Вывод результата
            Console.Write($"Результат перевода исходного числа ({input}) из системы счисления {in_sys}, в выбранную систему счисления {out_sys} будет равен: ");
            switch(out_sys)
            {
                case 2: Console.Write("bin "); break;
                case 8: Console.Write("oct "); break;
                case 10: Console.Write("dec "); break;
                case 16: Console.Write("0x"); break;
            }
            Console.WriteLine(Convert.ToString(input_number, out_sys));

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
        public static void Task_2()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 3, часть 2. Задача 2. ***\n");
            Console.WriteLine("Пользователь вводит словами цифру от 0 до 9." +
                "Приложение должно перевести слово в цифру." +
                "Например, если пользователь ввёл \"five\", приложение должно вывести на экран 5.");

            //Ввод исходных данных
            int output = 0;
            bool exit = false;
            while (!exit)
            {
                bool output_result = true;
                Console.Write("Напишите цифру от 0 до 9 словом (для выхода в главное меню нажмите Enter): ");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "zero":
                    case "0":
                    case "ноль": output = 0; break;
                    case "one":
                    case "1":
                    case "один": output = 1; break;
                    case "two":
                    case "2":
                    case "два": output = 2; break;
                    case "three":
                    case "3":
                    case "три": output = 3; break;
                    case "four":
                    case "4":
                    case "четыре": output = 4; break;
                    case "5":
                    case "пять": output = 5; break;
                    case "six":
                    case "6":
                    case "шесть": output = 6; break;
                    case "seven":
                    case "7":
                    case "семь": output = 7; break;
                    case "eight":
                    case "8":
                    case "восемь": output = 8; break;
                    case "nine":
                    case "9":
                    case "девять": output = 9; break;
                    case "exit":
                    case "menu":
                    case "меню":
                    case "выход":
                    case "":
                        {
                            exit = true;
                            Program.Menu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка! Введено неверное слово. Попробуйте ещё раз.");
                            output_result = false;
                            break;
                        }
                }
                if (output_result)
                {
                    Console.WriteLine("Вы ввели цифру " + output);
                }
            }

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
        public static void Task_3()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 3, часть 2. Задача 3. ***\n");
            Console.WriteLine("Создайте класс «Заграничный паспорт»." +
                "Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д." +
                "Предусмотреть механизмы для инициализации полей класса." +
                "Если значение для инициализации неверное, генерируйте исключение.");

            //Ввод исходных данных
            ForeignPassport passport = new ForeignPassport();

            Console.Write("Введите номер загранпаспорта: ");
            int number;
            while(!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка! Введенные данные не могут быть номером загранпаспорта. Попробуйте ещё раз:");
            }
            passport.PassportNumber = number;

            Console.WriteLine("Введите Фамилию, имя, отчество для загранпаспорта:");
            string fio = Console.ReadLine();
            if (fio.Contains(' '))
            {
                string[] FIO = fio.Split(' ');
                if (FIO.Length > 3)
                {
                    Console.WriteLine("Ошибка! Вы ввели лишнее слово.");
                }
                passport.FirstName = FIO[1];
                if (FIO.Length == 3)
                {
                    passport.MiddleName = FIO[2];
                }
                else
                {
                    passport.MiddleName = string.Empty;
                }
                passport.LastName = FIO[0];
            }
            else
            {
                passport.LastName = fio;
                Console.WriteLine("Теперь введите имя:");
                passport.FirstName = Console.ReadLine();
                Console.WriteLine("Теперь введите отчество:");
                passport.MiddleName = Console.ReadLine();
            }

            Console.WriteLine("Введите дату выдачи паспорта (год, месяц, день):");
            ushort yearIssue;
            ushort monthIssue;
            ushort dayIssue;
            while(!UInt16.TryParse(Console.ReadLine(), out yearIssue))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение года. Попробуйте ещё раз:");
            }
            while(!UInt16.TryParse(Console.ReadLine(), out monthIssue))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение месяца. Попробуйте ещё раз:");
            }
            while(!UInt16.TryParse(Console.ReadLine(), out dayIssue))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение дня. Попробуйте ещё раз:");
            }
            passport.DateOfIssue = new DateTime(yearIssue, monthIssue, dayIssue);

            Console.WriteLine("Введите дату рождения (год, месяц, день):");
            ushort yearBDay;
            ushort monthBDay;
            ushort dayBDay;
            while(!UInt16.TryParse(Console.ReadLine(), out yearBDay))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение года. Попробуйте ещё раз:");
            }
            while(!UInt16.TryParse(Console.ReadLine(), out monthBDay))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение месяца. Попробуйте ещё раз:");
            }
            while(!UInt16.TryParse(Console.ReadLine(), out dayBDay))
            {
                Console.WriteLine("Ошибка! Невозможно введенные данные преобразовать в значение дня. Попробуйте ещё раз:");
            }
            passport.BirthDate = new DateTime(yearBDay, monthBDay, dayBDay);

            //Вывод данных
            Console.WriteLine("Данные загранпаспорта:");
            Console.Write($"Номер: {passport.PassportNumber}," +
                $" выдан: {passport.DateOfIssue.Day}.{passport.DateOfIssue.Month}.{passport.DateOfIssue.Year}," +
                $" на имя {passport.LastName} {passport.FirstName} {passport.MiddleName}, " +
                $"родившегося {passport.BirthDate.Day}.{passport.BirthDate.Month}.{passport.BirthDate.Year}.\n\n");

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
        public static void Task_4()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 3, часть 2. Задача 4. ***\n");
            Console.WriteLine("Пользователь вводит в строку с клавиатуры логическое выражение." +
                "Например, 3>2 или 7<3." +
                "Программа должна посчитать результат введенного выражения и дать результат true или false." +
                "В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=." +
                "Для обработки ошибок ввода используйте механизм исключений.");

            //Ввод исходных данных
            Console.Write("Введите логическое выражение: ");
            string expression = Console.ReadLine();

            //Обработка выражения
            if (expression.Contains('>') || expression.Contains('=') || expression.Contains('<'))
            {
                string[] elements = expression.Split(new string[] { "<", ">", "==", "!=", "<=", ">=" }, StringSplitOptions.RemoveEmptyEntries);
                if (elements.Length == 2 )
                {
                    Int64 first = 0, second = 0;
                    try
                    {
                        first = Int64.Parse(elements[0]);
                        second = Int64.Parse(elements[1]);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Ошибка! Не удалось преобразовать введенные данные в целые числа.");
                    }
                    
                    Int64 result = first - second;
                    if (expression.Contains('=') && !expression.Contains('!') && result == 0)
                    {
                        Console.WriteLine("true");
                    }
                    else if (expression.Contains('<') && result < 0)
                    {
                        Console.WriteLine("true");
                    }
                    else if (expression.Contains('>') && result > 0)
                    {
                        Console.WriteLine("true");
                    }
                    else if (expression.Contains('!') && result != 0)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Логическое выражение должно состоять из двух элементов.");
                }
            }

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
    }
}
