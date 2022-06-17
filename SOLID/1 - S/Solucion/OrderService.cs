namespace SOLID._1___S.Solucion
{
    internal class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;

        public OrderService(IOrderRepository orderRepository,
                            IInvoiceService invoiceService,
                            INotificationService notificationService,
                            ILoggerService loggerService)
        {
            _orderRepository = orderRepository;
            _invoiceService = invoiceService;
            _notificationService = notificationService;
            _loggerService = loggerService;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InsertOrder(order);

                var invoice = _invoiceService.CreateInvoice(order);

                _notificationService.EmailInvoice(invoice);

                _loggerService.Info("The order has been complete");
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message, e);
            }
        }
    }
}