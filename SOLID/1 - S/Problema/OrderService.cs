namespace SOLID._1___S.Problema
{
    internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);

                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
            }
        }

        private bool InsertOrder(Order order)
        {
            //Código para insertar una orden
            return true;
        }

        private Invoice CreateInvoice(Order order)
        {
            //Código para generar una factura a partir de una orden
            return new Invoice();
        }

        private bool EmailInvoice(Invoice invoice)
        {
            //Código para enviar la factura
            return true;
        }
    }

    public class Order
    { }

    public class Invoice
    { }
}