using pr33_2.Data.Interfaces;
using pr33_2.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddScoped<IItems, MockItems>();
builder.Services.AddScoped<ICategories, MockCategories>();

var app = builder.Build();


app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();
