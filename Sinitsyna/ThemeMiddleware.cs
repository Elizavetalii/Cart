//using Microsoft.AspNetCore.Http;
//using System.Threading.Tasks;

//namespace Sinitsyna
//{
//    public class ThemeMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public ThemeMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task InvokeAsync(HttpContext context)
//        {
//            // Проверяем, есть ли в куках тема
//            if (context.Request.Cookies.ContainsKey("Theme"))
//            {
//                var theme = context.Request.Cookies["Theme"];
//                context.Items["Theme"] = theme; // Сохраняем тему в items для дальнейшего использования
//            }
//            else
//            {
//                // Устанавливаем значение по умолчанию
//                context.Items["Theme"] = "light"; // светлая тема по умолчанию
//            }

//            await _next(context);
//        }
//    }
//}
