using System;

namespace Store.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public decimal Grade { get; set; }
        public string Category { get; set; }
        public string Platform { get; set; }
    }
}
