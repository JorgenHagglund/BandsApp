namespace BandsApp.Web
{
    public class Program
    {
        // Kommentar här
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllers();

            app.Run(); //comment
        }
    }
}
