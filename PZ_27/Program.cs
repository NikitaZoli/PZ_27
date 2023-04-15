using System;

// описание структуры PRICE
struct PRICE
{
    public string TOVAR;
    public string MAG;
    public decimal STOIM;
}

class Program
{
    static void Main(string[] args)
    {
        // создание массива SPISOK для хранения 8 элементов типа PRICE
        PRICE[] SPISOK = new PRICE[8];

        // ввод данных в массив SPISOK с сортировкой по названиям магазинов
        Console.WriteLine("Введите данные о товарах в восьми магазинах:");
        for (int i = 0; i < SPISOK.Length; i++)
        {
            Console.WriteLine("Товар {0}:", i + 1);
            Console.Write("  Название товара: ");
            SPISOK[i].TOVAR = Console.ReadLine();
            Console.Write("  Название магазина: ");
            SPISOK[i].MAG = Console.ReadLine();
            Console.Write("  Стоимость товара: ");
            SPISOK[i].STOIM = decimal.Parse(Console.ReadLine());
        }
        Array.Sort(SPISOK, (x, y) => x.MAG.CompareTo(y.MAG)); // сортировка по названиям магазинов

        // вывод информации о товарах в магазине, название которого введено с клавиатуры
        Console.Write("\nВведите название магазина: ");
        string magazin = Console.ReadLine();
        bool found = false; // флаг для проверки наличия магазина в списке
        Console.WriteLine("Товары, продающиеся в магазине \"{0}\":", magazin);
        foreach (PRICE item in SPISOK)
        {
            if (item.MAG == magazin)
            {
                Console.WriteLine("{0} ({1} руб.)", item.TOVAR, item.STOIM);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Магазин \"{0}\" не найден.", magazin);
        }
    }
}

