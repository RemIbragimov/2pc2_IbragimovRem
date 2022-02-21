using System;
using System.Collections.Generic;
using System.Text;

namespace pz2__3
{
    class BookCard
    {

        private int ID;
        private string author;
        private string title;
        private int year;
        private string condition;
        private Random rnd = new Random();
        static int good = 0;
        static int bad = 0;
        static int awesome = 0;
        public BookCard(int _ID, string _author, string _title, int _year, string _condition)
        {
            ID = _ID;
            author = _author;
            title = _title;
            if (year>= 1990 && year <= 2022)
                year = _year;
            else
                year = rnd.Next((int)1990, 2022);
            condition = _condition;
            if (condition == "Новая")
                awesome += 1;
            if (condition == "Списания")
                bad += 1;
            if (condition == "Хорошая")
                good += 1;

        }
        public BookCard(int _ID, string _author, string _title, string _condition)
        {
            ID = _ID;
            author = _author;
            title = _title;
            year = rnd.Next((int)1990, 2022);
            condition = _condition;
            if (condition == "Новая")
                awesome += 1;
            if (condition == "Списания")
                bad += 1;
            if (condition == "Хорошая")
                good += 1;
        }
        public static int Getgood()
        {
            return good;
        }
        public static int Getbad()
        {
            return bad;
        }
        public static int Getawesome()
        {
            return awesome;
        }

        public void GetBookInfo()
        {
            Console.WriteLine($"Хороших: {BookCard.Getgood()}" + $"\nСписание: {BookCard.Getbad()}" + $"\nНовых: {BookCard.Getawesome()}");
            Console.WriteLine($"ID = {ID}, year = {year}, author = {author}, title = {title}, condition = {condition}");
        }
    }
}

