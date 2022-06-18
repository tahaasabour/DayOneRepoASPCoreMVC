

using System;
using System.Text;
using ITI.Library.Models;
using EmptyMVC.MiddleWareExtensions;
public class Program
{


    public static int Main()
    {

        var builder = WebApplication.CreateBuilder();
        WebApplication app = builder.Build();
        
        app.HandlePublihserList();
        app.HandlePublihserByID();

        app.Run(c=>c.Response.WriteAsync("End Of Day"));
        app.Run();

        return 0;
    }
}