using AbstractFactory;
using ArrayOps;
using Factory;
using Observer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IFactoryPattern, FactoryPattern>();
builder.Services.AddSingleton<IAbstractFactoryPattern, AbstractFactoryPattern>();
builder.Services.AddSingleton<IObserverPattern, ObserverPattern>();
//builder.Services.AddSingleton<IStackHelper<string>>(new StackHelper<string>(100));
builder.Services.AddSingleton(
provider =>
  new Func<int, IStackHelper<string>>((size) => new StackHelper<string>(size)));
builder.Services.AddSingleton(
provider =>
  new Func<int, IQueueHelper<string>>((size) => new QueueHelper<string>(size)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
