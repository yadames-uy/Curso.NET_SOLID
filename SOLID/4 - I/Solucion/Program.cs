namespace SOLID._4___I.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(2);
        }
    }
}