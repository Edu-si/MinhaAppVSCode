

public class MeuMiddleware {
    private readonly RequestDelegate _next;

    public MeuMiddleware(RequestDelegate mext){
        _next = mext;
    }
    public async Task InvokeAsync(HttpContext context){
    
        Console.WriteLine("n\r ----- Antes ---- \n\r");

        await _next(context);

        Console.WriteLine("n\r ----- Depois ---- \n\r");
    }

    public static class MeuMiddlewareExtension
    {
        public static IApplicationBuilder UseMeuMiddleware(this IApplicationBuilder builder){
            return builder.UseMiddleware<MeuMiddleware>();
        }
    }

}