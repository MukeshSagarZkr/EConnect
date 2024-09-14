using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace EConnect.API.Middleware
{
	public class ValidationMiddleware
	{
		private readonly RequestDelegate _next;
		
		public ValidationMiddleware(RequestDelegate next)
		{
			_next = next;
		}
		
		public async Task InvokeAsync(HttpContext context)
		{
			if (context.Request.Method == "POST" || context.Request.Method == "PUT")
			{
				context.Request.EnableBuffering();
				var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
				if (string.IsNullOrWhiteSpace(body))
				{
					context.Response.StatusCode = StatusCodes.Status400BadRequest;
					await context.Response.WriteAsync("Request body cannot be empty.");
					return;
				}
				context.Request.Body.Position = 0;
			}
			
			await _next(context);
		}
	}
}
