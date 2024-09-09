using API;
using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddAPI()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.Run();
}
