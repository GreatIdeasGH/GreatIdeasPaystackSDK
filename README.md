# <img src="https://paystack.com/favicon.png" height="40"/> GreatIdeas.Paystack.SDK

[//]: # ([![Version]&#40;https://img.shields.io/nuget/vpre/GreatIdeas.Paystack.SDK&#41;]&#40;https://www.nuget.org/packages/GreatIdeas.Paystack.SDK&#41;)
[//]: # ([![Downloads]&#40;https://img.shields.io/nuget/dt/GreatIdeas.Paystack.SDK&#41;]&#40;https://www.nuget.org/packages/GreatIdeas.Paystack.SDK&#41;)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

# What is it?
This is the .Net wrapper for [Paystack](https://paystack.com) RESTful API. It is a simple library that allows you to easily integrate Paystack's payment gateway into your application for African countries (Nigeria, Ghana, South Africa) and accepting international currencies (USD).

# API Endpoints
- [Transactions](https://paystack.com/docs/api/#transaction)
- [Transaction Splits](https://paystack.com/docs/api/#transaction-split)
- [Customer](https://paystack.com/docs/api/#customer)
- [Dedicated Virtual Account](https://paystack.com/docs/api/#dedicated-virtual-account)
- [Subaccount](https://paystack.com/docs/api/#subaccount)
- [Plan](https://paystack.com/docs/api/#plan)
- [Subscription](https://paystack.com/docs/api/#subscription)
- [Product](https://paystack.com/docs/api/#product)
- [Page](https://paystack.com/docs/api/#page)
- [Payment Request](https://paystack.com/docs/api/#payment-request)
- [Settlement](https://paystack.com/docs/api/#settlement)
- [Transfer Recipient](https://paystack.com/docs/api/#transfer-recipient)
- [Transfer](https://paystack.com/docs/api/#transfer)
- [Balance](https://paystack.com/docs/api/#balance)
- [Charge](https://paystack.com/docs/api/#charge)
- [Bulk Charge](https://paystack.com/docs/api/#bulk-charge)
- [Integration](https://paystack.com/docs/api/#integration)
- [Refund](https://paystack.com/docs/api/#refund)
- [Dispute](https://paystack.com/docs/api/#dispute)
- [Verification](https://paystack.com/docs/api/#verification)

# Getting Started
This section will briefly guide you through the steps to get started with the library.

1. Install the NuGet package
```csharp
dotnet add package GreatIdeas.Paystack.SDK
```
2. Add the Paystack dependency to your project. It is recommended to use the appsettings or other secret management to store your secret key.
```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPaystack(secretKey);
```
3. Usage of the library
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
