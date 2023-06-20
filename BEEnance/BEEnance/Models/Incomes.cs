using SQLite;

namespace BEEnance.Models
{
    public class Incomes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }

        //[ForeignKey("CategoryId")]
        //public Category Category { get; set; }
    }
}
