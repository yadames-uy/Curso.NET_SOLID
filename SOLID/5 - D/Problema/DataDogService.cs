namespace SOLID._5___D.Problema
{
    public class DataDogService
    {
        public void LogEvent(string message)
        {
            // code to log event on datadog
        }
    }

    public class OrderService
    {
        public readonly DataDogService _datadogService;

        public OrderService(DataDogService dataDogService)
        {
            _datadogService = dataDogService;
        }

        public void GenerateOrder(OrderService order)
        {
            //Todo el código que crea la orden

            //enviando notificacion a datadog
            _datadogService.LogEvent("La orden se creó satisfactoriamente");
        }
    }

    public class Order
    { }
}