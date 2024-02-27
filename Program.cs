

using System.Net.Security;
using HomeWork._1;

var library = new BookServices();



while (true)
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("-------------------------------------------------------------------------");
    System.Console.WriteLine();
    System.Console.WriteLine("g - get books");
    System.Console.WriteLine("a - add books");
    System.Console.WriteLine("u - update books");
    System.Console.WriteLine("d - delete books");
    System.Console.WriteLine("st - finde book by title");
    System.Console.WriteLine("sa - finde book by author");
    System.Console.WriteLine("id - finde book by id");

    string comand = Console.ReadLine();
    comand = comand.ToLower();
    if (comand == "g")
    {
        foreach (var item in library.GetBooks())
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("**********************************************************************************");
            System.Console.WriteLine();
            System.Console.WriteLine($"{item.Id}. -------------- {item.Title}--------------");
            System.Console.WriteLine($"---------------------{item.Author}--------------");
            System.Console.WriteLine($"{item.Discription}");
            System.Console.WriteLine();

        }
    }
    else if (comand == "a")
    {
        System.Console.Write("Title : ");
        string tl = Console.ReadLine();
        System.Console.Write("Author : ");
        string au = Console.ReadLine();
        System.Console.Write("About book : ");
        string ab = Console.ReadLine();
        var book = new Books();
        book.Title = tl;
        book.Author = au;
        book.Discription = ab;
        library.AddBooks(book);
    }
    else if (comand == "u")
    {
        System.Console.Write("Id : ");
        int identity = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Title : ");
        string tl = Console.ReadLine();
        System.Console.Write("Author : ");
        string au = Console.ReadLine();
        System.Console.Write("About book : ");
        string ab = Console.ReadLine();
        var book = new Books();
        book.Id = identity;
        book.Title = tl;
        book.Author = au;
        book.Discription = ab;
        library.UpdateBooks(book);
    }
    else if (comand == "d")
    {
        System.Console.Write("Id : ");
        int identity = Convert.ToInt32(Console.ReadLine());
        library.DeleteTBooks(identity);
    }
    else if (comand == "st")
    {
        System.Console.Write("Title : ");
        string st = Console.ReadLine();
        st = st.ToLower();
        var sbook = library.GetBooks().FirstOrDefault(p => p.Title.ToLower() == st);
        System.Console.WriteLine($"{sbook.Id}  {sbook.Title}  {sbook.Author}");
        System.Console.WriteLine(sbook.Discription);
    }
    else if (comand == "sa")
    {
        System.Console.Write("Author : ");
        string st = Console.ReadLine();
        st = st.ToLower();
        var sbook = library.GetBooks().FirstOrDefault(p => p.Author.ToLower() == st);
        System.Console.WriteLine($"{sbook.Id}  {sbook.Title}  {sbook.Author}");
        System.Console.WriteLine(sbook.Discription);
    }
    else if (comand == "id")
    {
        System.Console.Write("Title : ");
        int st = Convert.ToInt32(Console.ReadLine());
        var sbook = library.GetBooks().FirstOrDefault(p => p.Id == st);
        System.Console.WriteLine($"{sbook.Id}  {sbook.Title}  {sbook.Author}");
        System.Console.WriteLine(sbook.Discription);
    }
}