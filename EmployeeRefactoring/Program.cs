var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adds our controllers
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/* Configure the HTTP request pipeline.
  
   CodeBlock Start: here a pipeline is created/the middleware where each request that user makes to the server
   will pass by each function in this code block

 >>the method call in this code block order matters !!! */
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//defaults to HTTPS so you cant ever go to a HTTP
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//CodeBlock End.
