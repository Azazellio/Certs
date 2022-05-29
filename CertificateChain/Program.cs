using Application.ECDsaAlgorithmProvider;
using Application.ECDsaProvider;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IECDsaAlgorithmProvider>(_ => new ECDsaAlgorithmProvider(() => null));
builder.Services.AddScoped<IECDsaProvider, ECDsaProvider>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpLogging(); 
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

// if (app.Environment.IsDevelopment())
if (true)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();