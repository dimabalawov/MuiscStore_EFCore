using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MuiscStore_EFCore.Models;
using MuiscStore_EFCore;

class Program
{
    static void Main()
    {
        using (var db = new MusicStoreContext())
        {
            db.Database.Migrate();
        }

        Console.WriteLine("Добро пожаловать в магазин виниловых пластинок!");
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить пластинку");
            Console.WriteLine("2. Удалить пластинку");
            Console.WriteLine("3. Редактировать пластинку");
            Console.WriteLine("4. Продать пластинку");
            Console.WriteLine("5. Списать пластинку");
            Console.WriteLine("6. Внести пластинку в акцию");
            Console.WriteLine("7. Поиск пластинок");
            Console.WriteLine("0. Выход");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddRecord(); break;
                case "2": RemoveRecord(); break;
                case "3": EditRecord(); break;
                case "4": SellRecord(); break;
                case "5": WriteOffRecord(); break;
                case "6": AddRecordToPromotion(); break;
                case "7": SearchRecords(); break;
                case "0": return;
                default: Console.WriteLine("Неверный выбор. Попробуйте снова."); break;
            }
        }
    }

    static void AddRecord()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки: ");
            string title = Console.ReadLine();
            Console.Write("Введите исполнителя: ");
            string artist = Console.ReadLine();
            Console.Write("Введите жанр: ");
            string genre = Console.ReadLine();

            db.Records.Add(new Record { Title = title, Artist = artist, Genre = genre });
            db.SaveChanges();
            Console.WriteLine("Пластинка добавлена.");
        }
    }

    static void RemoveRecord()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки для удаления: ");
            string title = Console.ReadLine();
            var record = db.Records.FirstOrDefault(r => r.Title == title);
            if (record != null)
            {
                db.Records.Remove(record);
                db.SaveChanges();
                Console.WriteLine("Пластинка удалена.");
            }
            else Console.WriteLine("Пластинка не найдена.");
        }
    }

    static void EditRecord()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки для редактирования: ");
            string title = Console.ReadLine();
            var record = db.Records.FirstOrDefault(r => r.Title == title);
            if (record != null)
            {
                Console.Write("Новое название: ");
                record.Title = Console.ReadLine();
                Console.Write("Новый исполнитель: ");
                record.Artist = Console.ReadLine();
                Console.Write("Новый жанр: ");
                record.Genre = Console.ReadLine();
                db.SaveChanges();
                Console.WriteLine("Пластинка обновлена.");
            }
            else Console.WriteLine("Пластинка не найдена.");
        }
    }

    static void SellRecord()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки для продажи: ");
            string title = Console.ReadLine();
            var record = db.Records.FirstOrDefault(r => r.Title == title);
            if (record != null)
            {
                db.Sales.Add(new Sale { RecordId = record.Id, Date = DateTime.Now });
                db.Records.Remove(record);
                db.SaveChanges();
                Console.WriteLine("Пластинка продана.");
            }
            else Console.WriteLine("Пластинка не найдена.");
        }
    }

    static void WriteOffRecord()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки для списания: ");
            string title = Console.ReadLine();
            var record = db.Records.FirstOrDefault(r => r.Title == title);
            if (record != null)
            {
                db.Records.Remove(record);
                db.SaveChanges();
                Console.WriteLine("Пластинка списана.");
            }
            else Console.WriteLine("Пластинка не найдена.");
        }
    }

    static void AddRecordToPromotion()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название пластинки: ");
            string title = Console.ReadLine();
            var record = db.Records.FirstOrDefault(r => r.Title == title);
            if (record != null)
            {
                Console.Write("Введите название акции: ");
                string promoName = Console.ReadLine();
                db.Promotions.Add(new Promotion { Name = promoName, RecordId = record.Id });
                db.SaveChanges();
                Console.WriteLine("Пластинка добавлена в акцию.");
            }
            else Console.WriteLine("Пластинка не найдена.");
        }
    }

    static void SearchRecords()
    {
        using (var db = new MusicStoreContext())
        {
            Console.Write("Введите название или исполнителя: ");
            string query = Console.ReadLine().ToLower();
            var results = db.Records.Where(r => r.Title.ToLower().Contains(query) || r.Artist.ToLower().Contains(query)).ToList();
            if (results.Any())
                foreach (var record in results)
                    Console.WriteLine($"{record.Title} - {record.Artist} ({record.Genre})");
            else Console.WriteLine("Ничего не найдено.");
        }
    }
}
