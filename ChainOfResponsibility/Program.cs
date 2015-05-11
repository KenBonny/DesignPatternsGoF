using System;
namespace ChainOfResponsibility
{

    public enum LogLevel
    {
        None = 0,                 //        0
        Info = 1,                 //        1
        Debug = 2,                //       10
        Warning = 4,              //      100
        Error = 8,                //     1000
        FunctionalMessage = 16,   //    10000
        FunctionalError = 32,     //   100000
        All = 63                  //   111111
    }

    /// <summary>
    /// Abstract Handler in chain of responsibility pattern.
    /// </summary>
    public abstract class Logger
    {
        protected LogLevel logMask;

        // The next Handler in the chain
        protected Logger next;

        public Logger(LogLevel mask)
        {
            this.logMask = mask;
        }

        /// <summary>
        /// Sets the Next logger to make a list/chain of Handlers.
        /// </summary>
        public Logger SetNext(Logger nextLogger)
        {
            next = nextLogger;
            return nextLogger;
        }

        public void Message(string msg, LogLevel severity)
        {
            if ((severity & logMask) == severity) //True only if any logMask bits are set in severity
            {
                WriteMessage(msg);
            }
            if (next != null)
            {
                next.Message(msg, severity);
            }
        }

        abstract protected void WriteMessage(string msg);
    }

    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("Writing to console: " + msg);
        }
    }

    public class EmailLogger : Logger
    {
        public EmailLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            // Placeholder for mail send logic, usually the email configurations are saved in config file.
            Console.WriteLine("Sending via email: " + msg);
        }
    }

    class FileLogger : Logger
    {
        public FileLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            // Placeholder for File writing logic
            Console.WriteLine("Writing to Log File: " + msg);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // each step in the chain (object) checks if it can process the input,
            // if not it will pass it to the next object in the chain.
            // example: an ACL will pass a request to a rule, which will decide if
            // it can handle the request and pass it on to the next rule if it can't be handled
            // used to replace numerous if/else statements or a switch
            // https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern

            // Build the chain of responsibility
            Logger logger, logger1, logger2;
            logger = new ConsoleLogger(LogLevel.All);
            logger1 = logger.SetNext(new EmailLogger(LogLevel.FunctionalMessage | LogLevel.FunctionalError));
            logger2 = logger1.SetNext(new FileLogger(LogLevel.Warning | LogLevel.Error));
            
            // Handled by ConsoleLogger since the console has a loglevel of all
            logger.Message("Entering function ProcessOrder().", LogLevel.Debug);
            logger.Message("Order record retrieved.", LogLevel.Info);

            // Handled by ConsoleLogger and FileLogger since filelogger implements Warning & Error
            logger.Message("Customer Address details missing in Branch DataBase.", LogLevel.Warning);
            logger.Message("Customer Address details missing in Organization DataBase.", LogLevel.Error);

            // Handled by ConsoleLogger and EmailLogger as it implements functional error
            logger.Message("Unable to Process Order ORD1 Dated D1 For Customer C1.", LogLevel.FunctionalError);

            // Handled by ConsoleLogger and EmailLogger
            logger.Message("Order Dispatched.", LogLevel.FunctionalMessage);

            Console.ReadKey();
        }
    }

}

