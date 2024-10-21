namespace MSwebBurger2.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo { get; set; }

        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }


    }
}
