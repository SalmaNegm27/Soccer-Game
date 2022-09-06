using Coaches.Entities;
using Coaches.Repositories;
using Coaches.UnitOfWorks;
using Coaches.Validators;
using Coaches.ViewModels;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Players.Entities;
using Players.Repositories;
using Players.UnitOfWorks;
using Players.Validators;
using Players.ViewModels;
using Soccer_Game.Contexts;
using System.Text;
using Teams.Entities;
using Teams.Repositories;
using Teams.UnitOfWorks;
using Teams.Validators;
using Teams.ViewModels;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>
    (
options =>
{
    options
        .UseSqlServer(connectionString, builder => builder.MigrationsAssembly(typeof(Program).Assembly.FullName))
        .EnableDetailedErrors()
        .EnableSensitiveDataLogging()
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<DbContext, AppDbContext>();
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IPlayerUnitOfWork, PlayerUnitOfWork>();

builder.Services.AddScoped<ICoachRepository, CoachRepository>();
builder.Services.AddScoped<ICoachUnitOfWork, CoachUnitOfWork>();

builder.Services.AddScoped<IClubRepository, ClubRepository>();
builder.Services.AddScoped<IClubUnitOfWork, ClubUnitOfWork>();

builder.Services.AddScoped<INationlTeamRepository, NationalTeamRepository>();
builder.Services.AddScoped<INationalTeamUnitOfWork, NationalTeamUnitOfWork>();




builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Player).Assembly, typeof(Coach).Assembly,typeof(Club).Assembly,typeof(NationalTeam).Assembly);

builder.Services.AddScoped<IValidator<PlayerViewModel>, PlayerValidator>();
builder.Services.AddScoped<IValidator<CoachViewModel>, CoachValidator>();
builder.Services.AddScoped<IValidator<ClubViewModel>, ClubValidator>();
builder.Services.AddScoped<IValidator<NationalTeamViewModel>, NationalTeamValidator>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});


builder.Services.AddMvc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();