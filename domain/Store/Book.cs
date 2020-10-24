﻿using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public Book(int id, string isbn, string author, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;
            Description = description;
            Price = price;
        }

        public int Id { get; }

        public string Title { get; }

        public string Isbn { get; }

        public string  Author { get; }

        public string Description { get; }

        public decimal Price { get; }

        internal static bool IsIsbn(string s)
        {
            if (s == null)
            {
                return false;
            }

            s = s.Replace("-", "").Replace(" ", "").ToUpper();

            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}
