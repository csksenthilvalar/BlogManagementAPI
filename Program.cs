using BlogManagementSysAPI.DataAccessLayer.Interface;
using BlogManagementSysAPI.DataAccessLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddCors();
var myorigins = "myorigins";
builder.Services.AddCors(option =>
{
    option.AddPolicy(name: myorigins, policy => { policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod(); });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILoginUser, LoginUserRepository>();
builder.Services.AddTransient<IJSONBlogMngmt, JSONBlogMngmtRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(myorigins);
//app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));
app.UseAuthorization();
app.MapControllers();

app.Run();
