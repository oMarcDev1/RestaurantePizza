namespace RestaurantePizza.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public string Valor { get; set; }
        public RestauranteModel Restaurante { get; set; }
    }
}
