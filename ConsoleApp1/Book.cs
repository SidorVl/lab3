using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;
        public Title Title
        {
            get { return title; }
            set { title = value; }
        }
        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public Content Content
        {
            get { return content; }
            set { content = value; }
        }
        public void Show() 
        {
            title?.Show();
            author?.Show();
            content?.Show();
            
        }
    }
    public class Title
    {
        public string BookTitle { get; set; }
        public Title(string title)
        {
            BookTitle = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Book Title: " + BookTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Author
    {
        public string BookAuthor { get; set; }
        public Author(string author)
        {
            BookAuthor = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Book Author: " + BookAuthor);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Content
    {
        public string BookContent { get; set; }
        public Content(string bookcontent)
        {
            BookContent = bookcontent;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Book Content: " + BookContent);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
