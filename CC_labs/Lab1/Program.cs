namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Группа А. Задание 10");
            Console.WriteLine("Дана последовательность натуральных чисел {a0…an–1}. \nСоздать многопоточное приложение для поиска суммы ∑ai, где ai – четные числа");
            Console.WriteLine("Для выхода из программы ведите q");
            Console.WriteLine("---------------------------");
            var Task = new TaskExecutionLab1();
            Console.WriteLine("---------------------------");
            var result_mt = Task.MultipleThreads();
            FileWrite(result_mt, "multiple_treads1");
            Console.WriteLine("---------------------------");
            var result_st = Task.SingleThread();
            FileWrite(result_st, "single_tread1");

            Console.WriteLine("Конец программы!");
            Console.ReadKey();
        }

        static void FileWrite(Object input, string fileName)
        {
            Console.WriteLine($"Результат записывается в файл {fileName}.txt...");
            File.WriteAllText($"{fileName}.txt", input.ToString());
            Console.WriteLine($"Результат записан в файл {fileName}.txt.");
        }
    }
}