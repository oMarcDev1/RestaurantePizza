namespace RestaurantePizza.Models
{
    public class RestauranteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public ICollection <PizzaModel> Pizzas { get; set; }
    }
}
