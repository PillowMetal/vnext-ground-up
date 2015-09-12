using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.Run(async context => await context.Response.WriteAsync("Hello World"));
    }
}
