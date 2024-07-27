namespace ADO_09._Dapper_ORM;

internal interface IAuthorRepository
{
    Author Add(Author author);
    void Remove(int id);
    Author Update(Author author);
    IEnumerable<Author> GetAll();
    Author GetById(int id);
    void RemoveRange(int[] authorsId);
}
