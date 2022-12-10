namespace BEEnance.Models
{
    internal class User
    {
        // дуже важливий клас, без якого ніфіга не буде працювати
        // чесне слово
        public int Id { get; set; } // мб зайве, але най буде
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; } // я гребу, чи воно треба
    }
}

