using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja.Views
{
    public class Wydatek
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nazwa { get; set; }
        public decimal Kwota { get; set; }
    }
}
