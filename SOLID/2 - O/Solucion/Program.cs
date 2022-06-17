namespace SOLID._2___O.Solucion
{
    public class Order
    { }

    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService(new ReportGeneratorJson());

            service.GenerateReport(orders);
        }
    }
}