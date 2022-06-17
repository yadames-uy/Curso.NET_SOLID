namespace SOLID._2___O.Problema
{
    public class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }
        }

        private void CreateExcelReport(List<Order> orders)
        {
            // Crear reporte excel
        }

        private void CreatePDFReport(List<Order> orders)
        {
            // Crear reporte pdf
        }
    }
}