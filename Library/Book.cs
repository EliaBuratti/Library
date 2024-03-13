using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string Publisher;
        public int Year;
        public int Rack; 
        public int Floor;
        public Book(string title, string author, string publisher, int year, int rack, int floor)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            Rack = rack;
            Floor = floor;
        }

        public string PrintBooks()
        {
            return "\nTitle:" + Title + "\nAuthor:" + Author + "\nPublisher:" + Publisher + "\nYear:" + Year + "\nRack:" + Rack + Floor + "\n";
        }

        public bool SearchTitle(string TitleBook)
        {
            return Title.ToLower().Contains(TitleBook);
        }

        public bool SearchAuthor(string AuthorBook)
        {
            return Author.ToLower().Contains(AuthorBook);
        }

    }
}
