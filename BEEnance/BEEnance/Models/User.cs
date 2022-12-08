namespace BEEnance.Models
{
    internal class User
    {
        // дуже важливий клас, без якого ніфіга не буде працювати
        // чесне слово
        public int id { get; set; } // мб зайве, але най буде
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string token { get; set; } // я гребу, чи воно треба
    }
}

