namespace SOLID._1___S.Solucion
{
    public interface IInvoiceService
    {
        public Invoice CreateInvoice(Order order);
    }

    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            //Código para generar una factura a partir de una orden
            return new Invoice();
        }
    }
}