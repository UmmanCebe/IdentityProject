using IdentityProject.WebAPI.Contexts;
using IdentityProject.WebAPI.Repositories.Abstracts;
using IdentityProject.WebAPI.Repositories.Concretes;
using IdentityProject.WebAPI.Services.Abstracts;
using IdentityProject.WebAPI.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, EfUserRepository>(); // burada farkl� dblerle �al��ma imkan� sa�l�yoruz kendimize
builder.Services.AddScoped<IUserService, UserService>();// �userservici g�rd��� yerde userserviceyi newleyerek bana verir dependecy injection yapt���m�z yerlerde bunu yapt�kk� kullanabilelim.
// EF core ba�lant�s�n� verdik.
builder.Services.AddDbContext<MsSqlContext>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();