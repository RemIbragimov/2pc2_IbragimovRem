using System;

namespace pz2__3
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCard b1 = new BookCard(1, "Пушкин", "Дубровский", "Списания");
            BookCard b2 = new BookCard(2, "Лермонтов", "Парус", "Новая");
            BookCard b3 = new BookCard(3, "Есенин", "Сорокоуст", "Хорошая");
            BookCard b4 = new BookCard(4, "Толстой", "Казаки", "Новая");

            b1.GetBookInfo();
            b2.GetBookInfo();
            b3.GetBookInfo();
            b4.GetBookInfo();
        }
    }
}
