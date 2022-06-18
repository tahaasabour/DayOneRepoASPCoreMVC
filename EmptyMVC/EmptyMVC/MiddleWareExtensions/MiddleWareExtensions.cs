using EmptyMVC.MiddleWares;
namespace EmptyMVC.MiddleWareExtensions
{
    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder HandlePublihserList
             (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PublihserListMiddleWare>();
        }

        public static IApplicationBuilder HandlePublihserByID
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandlePublihserInfoByID>();
        }
    }
}
