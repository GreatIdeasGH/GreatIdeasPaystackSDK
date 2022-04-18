# <img src="https://paystack.com/favicon.png" height="40"/> GreatIdeas.Paystack.SDK

[![Version](https://img.shields.io/nuget/vpre/Paystack.Net.SDK)](https://www.nuget.org/packages/Paystack.Net.SDK)
[![Downloads](https://img.shields.io/nuget/dt/Paystack.Net.SDK)](https://www.nuget.org/packages/Paystack.Net.SDK)
[![Build Status](https://travis-ci.org/Paystack/Paystack.Net.SDK.svg?branch=master)](https://travis-ci.org/Paystack/Paystack.Net.SDK)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

# What is it?
This is the .Net wrapper for [Paystack](https://paystack.com) RESTful API. It is a simple library that allows you to easily integrate Paystack's payment gateway into your application for African countries (Nigeria, Ghana, South Africa) and accepting international currencies (USD).

# API Endpoints
- **Transactions**
  - [Initialize Transaction](https://paystack.com/docs/api/#transaction-initialize)
  - [Verify Transaction](https://paystack.com/docs/api/#transaction-verify)
  - [List Transactions](https://paystack.com/docs/api/#transaction-list)
  - [Fetch Transaction](https://paystack.com/docs/api/#transaction-fetch)
  - [Charge Authorization](https://paystack.com/docs/api/#transaction-charge-authorization)
  - [Check Authorization](https://paystack.com/docs/api/#transaction-check-authorization)
  - [View Transaction Timeline](https://paystack.com/docs/api/#transaction-timeline)
  - [Transaction Totals](https://paystack.com/docs/api/#transaction-totals)
  - [Export Transactions](https://paystack.com/docs/api/#transaction-export)
  - [Partial Debit](https://paystack.com/docs/api/#transaction-partial-debit)
- Transaction Splits]
- Customer
- Dedicated Virtual Account
- Subaccount
- Plan
- Subscription
- Product
- Page
- Payment Request
- Settlement
- Transfer Recipient
- Transfer
- Balance
- Charge
- Bulk Charge
- Integration
- Refund
- Dispute
- Verification

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
