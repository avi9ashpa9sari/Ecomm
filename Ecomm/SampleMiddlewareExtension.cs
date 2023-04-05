namespace Ecomm
{
    public static class SampleMiddlewareExtension
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<SampleMiddleware>();
        }
    }
}
