using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.Context;
using Casgem_DataAccessLayer.Concrete.EntityFramework;
using Casgem_EntityLayer.Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<KariyerNetDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<KariyerNetDbContext>();

builder.Services.AddAuthentication();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICompanyDal, EfCompanyDal>();
builder.Services.AddScoped<ICurriculumVitaeDal, EfCurriculumVitaeDal>();
builder.Services.AddScoped<IDegreeDal, EfDegreeDal>();
builder.Services.AddScoped<IEducationInformationDal, EfEducationInformationDal>();
builder.Services.AddScoped<IEmployerDal, EfEmployerDal>();
builder.Services.AddScoped<IEmployerJobAdvertisementSearchHistoryDal, EfEmployerJobAdvertisementSearchHistoryDal>();
builder.Services.AddScoped<IJobAdvertisementDal, EfJobAdvertisementDal>();
builder.Services.AddScoped<IJobApplicationDal, EfJobApplicationDal>();
builder.Services.AddScoped<IJobSeekerDal, EfJobSeekerDal>();
builder.Services.AddScoped<IJobSeekerJobAdvertisementSearchHistoryDal, EfJobSeekerJobAdvertisementSearchHistoryDal>();
builder.Services.AddScoped<IWorkExperienceDal, EfWorkExperienceDal>();

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
