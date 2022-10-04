using ConsoleApp1;
Book book = new Book()
{
    Title = new Title("title"),
    Author = new Author("author"),
    Content = new Content("content")
};
book.Show();