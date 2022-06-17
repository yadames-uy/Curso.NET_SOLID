namespace SOLID._4___I.Problema
{
    public class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            // code
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("No puede ordenar ensalada desde este servicio");
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException("No puede ordenar bistec desde este servicio");
        }
    }
}