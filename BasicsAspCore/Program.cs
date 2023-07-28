using System.Text;

namespace BasicsAspCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //var services = builder.Services;
            // Add services to the container.
            // builder.Services.AddRazorPages();
            // builder.Services.AddTransient<ITimeService, LongTimeService>();
            // builder.Services.AddTransient<ShortTimeService>();
            //builder.Services.AddTransient<ICounter, RandomCounter>();
            //builder.Services.AddTransient<CounterService>();
            builder.Services.AddSingleton<ICounter, RandomCounter>();
            builder.Services.AddSingleton<CounterService>();


            // Transient Scoped Singleton 

            /*
             * отримати інформацію про авто і власників 
             * машини сервіс 
             * інформація про авто 
             * інформація про власника
             * пошук штрафів на авто 
             */

            var app = builder.Build();
            {   // app.UseMiddleware<MyMiddleware>();
                {  // Configure the HTTP request pipeline.
                   //if (!app.Environment.IsDevelopment())
                   //{
                   //    app.UseExceptionHandler("/Error");
                   //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                   //    app.UseHsts();
                   //}

                    //app.UseHttpsRedirection();
                    //app.UseStaticFiles();

                    //app.UseRouting();

                    //app.UseAuthorization();

                    //app.MapRazorPages();
                    //app.Run(async(context) => await context.Response.WriteAsync("Hello"));


                    // Microsoft.AspNetCore.Http.HttpContext
                }
                //app.Run(async (context) =>
                //{
                //    //var timeService = app.Services.GetService<ITimeService>();
                //    //await context.Response.WriteAsync($"Time: {timeService.GetTime()}");
                //    //var timeService2 = app.Services.GetService<ShortTimeService>();
                //    //await context.Response.WriteAsync($"Time: {timeService2.GetTime()}");
                //    {
                //        {   //var request = context.Request;
                //            //var response = context.Response;
                //            //response.Headers.ContentLanguage = "en";
                //            //response.Headers.ContentType = "text/html";
                //            //response.StatusCode = 300;
                //            //var sb = new StringBuilder();
                //            //foreach(var h in request.Headers)
                //            //{
                //            //    sb.Append($"<p>{h.Key} : {h.Value}</p>");
                //            //    sb.AppendLine();
                //            //}


                //            //await response.WriteAsync($"{sb.ToString()}");
                //            //if (request.Path == "/date")
                //            //    await response.WriteAsync($"Date: {DateTime.UtcNow.ToLongDateString()}");
                //            //else if(request.Path == "/time")
                //            //{
                //            //    await response.WriteAsync($"Time: {DateTime.UtcNow.ToLongTimeString()}");
                //            //}

                //            //await response.WriteAsync($"<p>Path: {request.Path}</p>");
                //            //foreach(var h in request.Query)
                //            //{
                //            //    await response.WriteAsync($"<p>Parameters: {h.Key}: {h.Value}</p>");
                //            //}

                //            //await response.WriteAsync($"Parameters test: {request.Query["test"]}");
                //        }
                //        //var response = context.Response;
                //        //var request = context.Request;
                //        //var path = request.Path;
                //        //var filledPath = $"html/{path}.html";
                //        //response.Headers.ContentType = "text/html";



                //        //if (File.Exists(filledPath))
                //        //{
                //        //    await context.Response.SendFileAsync(filledPath);
                //        //}
                //        //else
                //        //{
                //        //    await response.WriteAsync($"<p>NOT FOUND</p>");
                //        //}
                //        // await context.Response.SendFileAsync("html/htmlpage.html");
                //    }
                ////    var sb = new StringBuilder();
                ////    sb.AppendLine("<h1> All services </h1>");
                ////    sb.AppendLine("<table>");
                ////    sb.AppendLine($"<tr> <th> Type </th> <th> Lifetime </th>" +
                ////        $" <th> Implementation </th> </tr>");
                ////    foreach(var ser in services)
                ////    {
                ////        sb.AppendLine("<tr>");
                ////        sb.AppendLine($"<td>{ser.ServiceType.FullName}</td>");
                ////        sb.AppendLine($"<td>{ser.Lifetime}</td>");
                ////        sb.AppendLine($"<td>{ser.ImplementationType?.FullName}</td>");
                ////        sb.AppendLine("</tr>");
                ////    }
                ////    sb.AppendLine("</table>");
                ////    context.Response.ContentType = "text/html";
                ////    await context.Response.WriteAsync( sb.ToString() );
                //});
            }
            app.UseMiddleware<CounterMiddleWare>();
            app.Run();
        }
    }
}