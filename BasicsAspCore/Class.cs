namespace BasicsAspCore
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }

    public class Message
    {
        ILogger Logger;
        public string Text { get; set; } = "";
        public Message(ILogger logger)
        {
            Logger = logger;
        }
        public void Print() => Logger.Log(Text);
    }

    interface ITimeService
    {
        public string GetTime();
    }

    public class ShortTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.UtcNow.ToShortTimeString();
        }
    }
    public class LongTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.UtcNow.ToLongTimeString();
        }
    }

    public interface ICounter
    {
        public int Value { get; }
    }

    public class RandomCounter : ICounter
    {
        static Random random = new Random();
        private int _value;
        public RandomCounter()
        {
            _value = random.Next(0, 1000000);
        }

        public int Value
        {
            get => _value;
        }
    }
    public class CounterService
    {
        public ICounter Counter { get; set; }
        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }

    public class CounterMiddleWare
    {
        RequestDelegate RequestDelegate;
        int count = 0;
        public CounterMiddleWare(RequestDelegate request)
        {
            RequestDelegate = request;
        }
        public async Task InvokeAsync(HttpContext httpContext, ICounter counter, CounterService counterService)
        {
            count++;
            httpContext.Response.ContentType = "text/html";
            await httpContext.Response.WriteAsync($"Request {count}; " +
                $"Counter: {counter.Value};" +
                $"Service: {counterService.Counter.Value}");
        }
    }
}
