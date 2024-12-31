using RestaurantePizza.Data;
using RestaurantePizza.DTO.Pizza;
using RestaurantePizza.Models;

namespace RestaurantePizza.Services.Pizza
{
    public class PizzaService : PizzaInterface
    {
        private readonly AppDbContext _context;
        public PizzaService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<PizzaModel>> BuscarPizzaPorId(int IdPizza)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PizzaModel>>> BuscarPizzaPorIdRestaurante(int IdRestaurante)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<PizzaModel>> CriarPizza(PizzaCriacaoDTO pizzacriacaoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<PizzaModel>> EditarLivro(PizzaEdicaoDTO PizzaEdicaoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<PizzaModel>> ExcluirLivro(int IdPizza)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PizzaModel>>> ListarPizzas()
        {
            throw new NotImplementedException();
        }
    }
}
