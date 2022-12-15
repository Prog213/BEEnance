using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEEnance.Models
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Note { get; set; }
        public string Date { get; set; }
    }
}
