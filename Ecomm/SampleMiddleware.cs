namespace Ecomm
{
    public class SampleMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.WriteAsync("Custome Middleware is called");
            await next.Invoke(context);
        }
    }
}
