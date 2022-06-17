namespace SOLID._2___O.Problema
{
    public class ReportingService2
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
            else if (type == ReportType.JSON)
            {
                CreateJsonReport(orders);
            }
            else if (type == ReportType.XML)
            {
                CreateXmlReport(orders);
            }
        }

        private void CreateXmlReport(List<Order> orders)
        {
            // Crear reporte Xml
        }

        private void CreateJsonReport(List<Order> orders)
        {
            // Crear reporte JSON
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