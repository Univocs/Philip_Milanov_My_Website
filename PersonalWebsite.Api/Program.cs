using PersonalWebsite.Api.Application.Careers.GetCareerSummaries;
using PersonalWebsite.Api.Application.Mails.GetContactMessageSummaries;
using PersonalWebsite.Api.Application.Projects.GetProjectSummaries;
using PersonalWebsite.Api.Application.Skills.GetSkillGroupSummaries;
using PersonalWebsite.Api.Storage.Careers;
using PersonalWebsite.Api.Storage.ContactMessages;
using PersonalWebsite.Api.Storage.Projects;
using PersonalWebsite.Api.Storage.SkillGroups;

//Builder
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Repository in-memory data needs to exist between requests
builder.Services.AddSingleton<ISkillGroupsRepository, InMemorySkillGroupsRepository>();
builder.Services.AddSingleton<IProjectsRepository, InMemoryProjectsRepository>();
builder.Services.AddSingleton<IContactMessagesRepository, InMemoryContactMessagesRepository>();
builder.Services.AddSingleton<ICareersRepository, InMemoryCareersRepository>();

// Query-Command handlers (scoped -- new instance per request)
builder.Services.AddScoped<GetSkillGroupSummariesQueryHandler>();
builder.Services.AddScoped<GetCareerSummariesQueryHandler>();
builder.Services.AddScoped<GetProjectSummariesQueryHandler>();
builder.Services.AddScoped<GetContactMessageSummariesQueryHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.MapGet("/skill-groups", async (GetSkillGroupSummariesQueryHandler handler) =>
    Results.Ok(await handler.Execute()));

app.MapGet("/careers", async (GetCareerSummariesQueryHandler handler) =>
    Results.Ok(await handler.Execute()));

app.MapGet("/projects", async (GetProjectSummariesQueryHandler handler) =>
    Results.Ok(await handler.Execute()));

app.MapGet("/contact-messages", async (GetContactMessageSummariesQueryHandler handler) =>
    Results.Ok(await handler.Execute()));

app.Run();

public partial class Program;