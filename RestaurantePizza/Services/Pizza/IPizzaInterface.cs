using RestaurantePizza.Data;
using RestaurantePizza.DTO.Pizza;
using RestaurantePizza.Models;

namespace RestaurantePizza.Services.Pizza
{
    public interface PizzaInterface
    {
        Task<ResponseModel<List<PizzaModel>>> ListarPizzas();
        Task<ResponseModel<PizzaModel>> BuscarPizzaPorId(int IdPizza);
        Task<ResponseModel<List<PizzaModel>>> BuscarPizzaPorIdRestaurante(int IdRestaurante);
        Task<ResponseModel<PizzaModel>> CriarPizza(PizzaCriacaoDTO pizzacriacaoDTO);
        Task<ResponseModel<PizzaModel>> EditarLivro(PizzaEdicaoDTO PizzaEdicaoDTO);
        Task<ResponseModel<PizzaModel>> ExcluirLivro(int IdPizza);

    }
}
