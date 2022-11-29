using eRezervacija.Repository;
using eRezervacija.Service;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddCors(options =>
//{
//	options.AddPolicy(name: MyAllowSpecificOrigins,
//		policy =>
//		{
//			policy.WithOrigins("http://localhost:4200",
//								"https://localhost:4200",
//								"localhost://4200").WithHeaders("*").WithMethods("*");
//		});
//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = new ConfigurationBuilder()
	.AddJsonFile("appsettings.json", false)
	.Build();

builder.Services.AddDbContext<eRezervacijaDbContext>(options =>
	options.UseSqlServer(config.GetConnectionString("eRezervacijaDB")));
//Ovdje se konfigurisu veze interfacea sa njihovim klasama, sto se tice servisa
//te znaci kad se zahtijeva tip IStudentService da se instancira StudentService, npr
//builder.Services.AddTransient<IStudentService, StudentService>(); 
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors(
	options => options
		.SetIsOriginAllowed(x => _ = true)
		.AllowAnyMethod()
		.AllowAnyHeader()
		.AllowCredentials()
); //This needs to set everything allowed
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
