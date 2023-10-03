using graphql_demo.Graphql.Models;

namespace graphql_demo.Graphql;

public class Query
{
  public Book GetBook() =>
  new()
  {
    Title = "GraphQL demo in C#",
    Author = new()
    {
      Name = "Miquel A"
    }
  };
}
