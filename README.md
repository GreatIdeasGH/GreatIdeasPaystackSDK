# <img src="https://paystack.com/favicon.png" height="40"/> GreatIdeas.Paystack.SDK

[//]: # ([![Version]&#40;https://img.shields.io/nuget/vpre/GreatIdeas.Paystack.SDK&#41;]&#40;https://www.nuget.org/packages/GreatIdeas.Paystack.SDK&#41;)
[//]: # ([![Downloads]&#40;https://img.shields.io/nuget/dt/GreatIdeas.Paystack.SDK&#41;]&#40;https://www.nuget.org/packages/GreatIdeas.Paystack.SDK&#41;)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

# What is it?
This is a .Net wrapper for [Paystack](https://paystack.com) RESTful API. It is a simple library that allows you to easily integrate Paystack's payment gateway into your application for African countries (Nigeria, Ghana, South Africa) and accepting international currencies (USD).

# API Endpoints
- [Transactions](https://paystack.com/docs/api/#transaction)

[//]: # (- [Transaction Splits]&#40;https://paystack.com/docs/api/#transaction-split&#41;)

[//]: # (- [Customer]&#40;https://paystack.com/docs/api/#customer&#41;)

[//]: # (- [Dedicated Virtual Account]&#40;https://paystack.com/docs/api/#dedicated-virtual-account&#41;)

[//]: # (- [Subaccount]&#40;https://paystack.com/docs/api/#subaccount&#41;)

[//]: # (- [Plan]&#40;https://paystack.com/docs/api/#plan&#41;)

[//]: # (- [Subscription]&#40;https://paystack.com/docs/api/#subscription&#41;)

[//]: # (- [Product]&#40;https://paystack.com/docs/api/#product&#41;)

[//]: # (- [Page]&#40;https://paystack.com/docs/api/#page&#41;)

[//]: # (- [Payment Request]&#40;https://paystack.com/docs/api/#payment-request&#41;)

[//]: # (- [Settlement]&#40;https://paystack.com/docs/api/#settlement&#41;)

[//]: # (- [Transfer Recipient]&#40;https://paystack.com/docs/api/#transfer-recipient&#41;)

[//]: # (- [Transfer]&#40;https://paystack.com/docs/api/#transfer&#41;)

[//]: # (- [Balance]&#40;https://paystack.com/docs/api/#balance&#41;)

[//]: # (- [Charge]&#40;https://paystack.com/docs/api/#charge&#41;)

[//]: # (- [Bulk Charge]&#40;https://paystack.com/docs/api/#bulk-charge&#41;)

[//]: # (- [Integration]&#40;https://paystack.com/docs/api/#integration&#41;)

[//]: # (- [Refund]&#40;https://paystack.com/docs/api/#refund&#41;)

[//]: # (- [Dispute]&#40;https://paystack.com/docs/api/#dispute&#41;)

[//]: # (- [Verification]&#40;https://paystack.com/docs/api/#verification&#41;)

# Getting Started
This section will briefly guide you through the steps to get started with the library.

1. Install the NuGet package
```csharp
dotnet add package GreatIdeas.Paystack.SDK
```
2. Add the Paystack dependency to your project. It is recommended to use the appsettings or other secret management to store your secret key.
```csharp
// Using a web application
using GreatIdeas.Paystack.SDK;

var builder = WebApplication.CreateBuilder(args);

const string secretKey = "sk_test_xxx";

builder.Services
    .AddPaystack(secretKey);
    
// Using a console application
using GreatIdeas.Paystack.SDK;
using Microsoft.Extensions.Hosting;

const string secretKey = "sk_test_xxx";

var host = new HostBuilder()
    .ConfigureServices(services =>
    {
        services.AddPaystack(secretKey);
    })
    .Build();
    
```
3. Usage of the library
```Transaction```
```csharp
...

private readonly IPaystackTransaction _paystackTransaction;

public Transaction(IPaystackTransaction paystackTransaction)
{
    _paystackTransaction = paystackTransaction;
}

public async Task<TransactionInitializeResponse> AcceptPayment(TransactionInitializeModel model,
        CancellationToken cancellationToken)
{
    var response = await _paystackTransaction.InitializeAsync(model, cancellationToken);
    return response!;
}
  
```
