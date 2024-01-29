﻿using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using ScreenSound.ScreenSoundAPI.Endpoints;
using ScreenSound.Shared.Dados;
using ScreenSound.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.AddEndPointsArtistas();
app.AddEndPointsMusicas();

app.Run();

