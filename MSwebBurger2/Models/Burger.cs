using System.ComponentModel.DataAnnotations;

namespace MSwebBurger2.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        public decimal Price { get; set; }
        [Range(0.1, 99.99)]
        public decimal PriceCelling { get; set; }

        public List<Promo>? Promos { get; set; }



    }
}

