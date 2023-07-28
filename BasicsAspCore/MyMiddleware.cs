namespace BasicsAspCore
{
    public class MyMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public MyMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context) 
        { 
            var test = context.Request.Query["test"];
            if(test != "55")
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync($"Test not 55");
            }
            else
            {
                await requestDelegate.Invoke(context);
            }
        }
    }
}
