using GreatIdeas.Paystack.Sample.Resources;
using GreatIdeas.Paystack.SDK;
using GreatIdeas.Paystack.SDK.Models.Transactions;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var secretKey = builder.Configuration["Paystack:SecretKey"];

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPaystack(secretKey);

builder.Services.AddScoped<Transaction>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region Transactions

app.MapGet("/transaction/initialize",
        async ([FromServices] Transaction paystack, [FromBody] TransactionInitializeModel model) =>
        {
            var result = await paystack.AcceptPayment(model, CancellationToken.None);
            return result;
        })
    .WithName("InitializeTransaction");

app.MapGet("/transaction/verify/{reference}", async ([FromServices] Transaction paystack, string reference) =>
    {
        var result = await paystack.VerifyPayment(reference, CancellationToken.None);
        return result;
    })
    .WithName("VerifyTransaction");

app.MapGet("/transaction", async (
        [FromServices] Transaction paystack, int? perPage, int? page, DateTime? from, DateTime? to) =>
    {
        var result = await paystack.List(perPage, page, from, to, CancellationToken.None);
        return result;
    })
    .WithName("ListTransactions");

app.MapGet("/transaction/{id}", async ([FromServices] Transaction paystack, string id) =>
    {
        var result = await paystack.Fetch(id, CancellationToken.None);
        return result;
    })
    .WithName("FetchTransaction");

app.MapGet("/transaction/totals", async (
        [FromServices] Transaction paystack,
        int? perPage, int? page, DateTime? from, DateTime? to) =>
    {
        var result = await paystack.Totals(perPage, page, from, to, CancellationToken.None);
        return result;
    })
    .WithName("TransactionTotals");

app.MapGet("/transaction/timeline/{idReference}", async (
        [FromServices] Transaction paystack,
        string idReference) =>
    {
        var result = await paystack.Timeline(idReference, CancellationToken.None);
        return result;
    })
    .WithName("TransactionTimeline");

app.MapGet("/transaction/export", async (
        [FromServices] Transaction paystack,
        int? perPage, int? page, DateTime? from, DateTime? to) =>
    {
        var result = await paystack.Export(perPage, page, from, to, CancellationToken.None);
        return result;
    })
    .WithName("DownloadTransaction");

#endregion

app.Run();