using System.Data.Entity;

namespace Teste.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestContext : DbContext
    {
        public IDbSet<Table> Tables { get; set; }
    }
}