var builder = WebApplication.CreateBuilder(args); //Skapar ny webbapplikation
builder.Services.AddControllersWithViews(); //Aktiverar MVC-mönstret
var app = builder.Build();
app.UseStaticFiles(); //wwwroot - aktiverarar statiska filer
app.UseRouting(); // Aktiverar routing


//routing
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}" //struktur på sökväg i adressraden
);



app.Run();   //kör webbapplikationen

