using SQLite;

namespace BEEnance.Models
{
    public class Incomes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public string Type = "Income"; // всім костилям костиль

        //[ForeignKey("CategoryId")]
        //public Category Category { get; set; }
    }
}
