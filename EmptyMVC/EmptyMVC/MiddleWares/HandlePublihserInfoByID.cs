
using ITI.Library.Models;
namespace EmptyMVC.MiddleWares
{
    public class HandlePublihserInfoByID
    {
        RequestDelegate next;
        public HandlePublihserInfoByID(RequestDelegate _next)
        {
            next = _next;
        }
        public async Task InvokeAsync(HttpContext _context)
        {
            LibraryContext db = new LibraryContext();
            if (_context.Request.Path == "/ByID")
            {
                int ID
                  = int.Parse(_context.Request.Query["ID"].ToString());
                Publisher? P
                 = db.Publishers.FirstOrDefault(i => i.ID == ID);

                if (P != null)
                    await _context.Response.WriteAsync(P.Name);
                else
                    await _context.Response.WriteAsync($"No Publisher With ID {ID}");
            }

            await next(_context);
        }
    }
}
