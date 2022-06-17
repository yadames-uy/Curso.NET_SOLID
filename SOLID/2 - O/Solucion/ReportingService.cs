namespace SOLID._2___O.Solucion
{
    public class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.GenerateReport(orders);
        }
    }
}