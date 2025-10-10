var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region dals
builder.Services.AddSingleton<GeometriaModels.DALs.IFigurasDAL, GeometriaModels.DALs.FigurasListDAL>();
#endregion

#region services
builder.Services.AddSingleton<GeometriaModels.Services.FigurasService>();
#endregion


var app = builder.Build();


//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
