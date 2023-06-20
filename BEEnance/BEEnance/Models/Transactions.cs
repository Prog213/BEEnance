using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEEnance.Models
{
     public class Transactions
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
    }
}
