using System.Text;
using ITI.Library.Models;

namespace EmptyMVC.MiddleWares
{
    public class PublihserListMiddleWare
    {
        RequestDelegate next;
        public PublihserListMiddleWare(RequestDelegate _next)
        {
            next = _next;
        }
        public async Task InvokeAsync(HttpContext _context)
        {
            LibraryContext db = new LibraryContext();
            if (_context.Request.Path == "/PublisherList")
            {
                StringBuilder str = new StringBuilder();

                foreach (var Pub in db.Publishers)
                    str.Append("<h1 style='color:red'>" + Pub.Name + "</h1>");
                 await _context.Response.WriteAsync(str.ToString());
            }
            await next(_context);
        }
    }
}
