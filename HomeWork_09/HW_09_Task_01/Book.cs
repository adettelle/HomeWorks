using System;
using System.Collections.Generic;
using System.Text;

namespace HW_09_Task_01
{
    internal class Book
    {
        string _title;
        string _author;
        int year;
        int pages;

        public int Year
        {
            set
            {
                if (value > 0)
                {
                    this.year = value;
                }
                else
                {
                    throw new ArgumentException($"Year of \"{this._title}\" must be positive");
                }
            }
            get
            {
                return year;
            }
        }

        public int Pages
        {
            set
            {
                if (value > 0)
                {
                    this.pages = value;
                }
                else
                {
                    throw new ArgumentException($"Pages of \"{this._title}\" must be positive");
                }
            }
            get
            {
                return pages;
            }
        }


        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{_title}, {_author}, {Year}, {Pages} pages.");
        }

    }
}
