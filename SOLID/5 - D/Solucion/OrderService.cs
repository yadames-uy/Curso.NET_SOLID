namespace SOLID._5___D.Solucion
{
    public class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            //Todo el código que crea la orden

            //enviando notificacion a la clase que implementa la interfaz
            _eventNotificationService.LogEvent("La orden se creó satisfactoriamente");
        }
    }

    public class Order
    { }
}