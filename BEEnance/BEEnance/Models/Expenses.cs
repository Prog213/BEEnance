using SQLite;
using System.Dynamic;

namespace BEEnance.Models
{
    public class Expenses
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Amount { get; set; } // тут мав би бути double, але воно не робе
        public string Date { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
    }
}
