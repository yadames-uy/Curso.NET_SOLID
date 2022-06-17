namespace SOLID._1___S.Solucion
{
    public interface IOrderRepository
    {
        public bool InsertOrder(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            //Código para insertar una orden
            return true;
        }
    }
}