using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEEnance.Models
{
    internal class Expenses
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
