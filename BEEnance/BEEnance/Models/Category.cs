using SQLite;

namespace BEEnance.Models
{
    public class Category // поки не юзається
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
