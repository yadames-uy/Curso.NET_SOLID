namespace SOLID._1___S.Solucion
{
    public interface INotificationService
    {
        public bool EmailInvoice(Invoice invoice);
    }

    public class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            //Código para enviar la factura
            return true;
        }
    }
}