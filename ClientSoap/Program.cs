using MyserviceSoap;
using System.Drawing;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//Minimal API ,EndPoint Get for consume web service  SOAP application

app.MapGet("/myServiceSoap", async () =>
{

    // request one service soap

    Service1Client service1Client = new Service1Client();// client soap
    string responseServiceSoap1 = await service1Client.GetDataAsync(4,5);

    // request two service soap

    CompositeType compositeType = new CompositeType()
    {
        BoolValue = true
    };

    var responseServiceSoap2= await service1Client.GetDataUsingDataContractAsync(compositeType);

    return $"response service soap one : {responseServiceSoap1} and response service soap two : {responseServiceSoap2.StringValue} ";
}
);

app.Run();


