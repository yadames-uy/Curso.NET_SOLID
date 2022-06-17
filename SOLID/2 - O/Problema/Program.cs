namespace SOLID._2___O.Problema
{
    public enum ReportType
    {
        PDF, EXCEL, JSON, XML
    }

    public class Order
    { }

    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService();

            service.GenerateReport(orders, ReportType.PDF);
        }
    }
}