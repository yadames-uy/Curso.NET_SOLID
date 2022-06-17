namespace SOLID._1___S.Solucion
{
    public interface ILoggerService
    {
        public void Info(string info);

        public void Debug(string info);

        public void Error(string message, Exception ex);
    }

    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
            // Acá se escribe el codigo de inicialización de alguna variable, o la creación
            // de los ficheros de Log, si es necesario.
        }

        public void Debug(string info)
        {
            // Enviamos información de debug al fichero de log
        }

        public void Error(string message, Exception ex)
        {
            // Enviamos información de error al fichero de log
        }

        public void Info(string info)
        {
            // Enviamos información de info al fichero de log
        }
    }
}