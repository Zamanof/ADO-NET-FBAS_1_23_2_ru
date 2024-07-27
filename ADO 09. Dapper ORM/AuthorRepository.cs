﻿using Dapper;
using System.Data;

namespace ADO_09._Dapper_ORM;

internal class AuthorRepository : IAuthorRepository
{
    private IDbConnection _db;

    public AuthorRepository(IDbConnection db, string connectionString)
    {
        _db = db;
        _db.ConnectionString = connectionString;
    }

    public Author Add(Author author)
    {
        var sql =
@"INSERT INTO Authors (FirstName, LastName)
VALUES(@FirstName, @LastName)
SELECT CAST(SCOPE_IDENTITY() AS int)";
        var id = _db.Query<int>(sql, new
        {
            @FirstName = author.FirstName,
            @LastName = author.LastName
        }).FirstOrDefault();
        //Console.WriteLine(id);
        author.Id = id;
        return author;
    }

    public void AddAutors(List<Author> authors)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Author> GetAll()
    {
        var sql = "SELECT * FROM Authors";
        return _db.Query<Author>(sql);
    }

    public Author GetById(int id)
    {
        var sql = "SELECT * FROM Authors WHERE Id=@Id";
        return _db.Query<Author>(sql, new { @Id = id }).FirstOrDefault()!;
    }

    public void Remove(int id)
    {
        _db.Execute("DELETE FROM Authors WHERE Id = @Id", new { @Id = id });
    }

    public void RemoveFromIdArray(int[] authorsIds)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(int start, int end)
    {
        throw new NotImplementedException();
    }

    public Author Update(Author author)
    {
        var sql = "UPDATE Authors SET FirstName=@FirstName, LastName=@LastName WHERE Id=@Id";
        _db.Execute(sql, author);
        return author;
    }
}
