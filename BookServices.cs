using Dapper;
using Npgsql;
namespace HomeWork._1;

public class BookServices
{
        private string _conectionString = "Server=localhost;Port=5432;Database=Books;User Id=postgres;Password=832111";


        public List<Books> GetBooks()
    {
        using var connect = new NpgsqlConnection(_conectionString);
        var result = connect.Query<Books>("select * from books").ToList();
        return result;
    }

    public void AddBooks(Books book)
    {
        using var connect = new NpgsqlConnection(_conectionString);
        connect.Execute("insert into books (title,author,discription) values (@title,@author,@discription)",book);
    }

     public void UpdateBooks(Books book)
    {
        using var connect = new NpgsqlConnection(_conectionString);
        connect.Execute("update books set title=@title,author=@author,discription=@discription where id = @id",book);
    }

     public void DeleteTBooks(int id)
    {
        using var connect = new NpgsqlConnection(_conectionString);
        connect.Execute("delete from books where id = @id", new {Id = id});
    }

  


}
