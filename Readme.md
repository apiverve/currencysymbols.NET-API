Currency Symbols API
============

Currency Symbols is a simple tool for getting currency symbols. It returns the currency symbol, name, and more of a currency.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Currency Symbols API](https://apiverve.com/marketplace/api/currencysymbols)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.CurrencySymbols
```

Using the Package Manager:
```
nuget install APIVerve.API.CurrencySymbols
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.CurrencySymbols
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.CurrencySymbols".
5. Click on the APIVerve.API.CurrencySymbols package, click Install.


---

## Configuration

Before using the currencysymbols API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Currency Symbols API documentation is found here: [https://docs.apiverve.com/api/currencysymbols](https://docs.apiverve.com/api/currencysymbols).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Currency Symbols API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new CurrencySymbolsAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new CurrencySymbolsQueryOptions {
  currency = "USD"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "countriesFound": [
      {
        "country_name": "AMERICAN SAMOA",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "BONAIRE, SINT EUSTATIUS AND SABA",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "BRITISH INDIAN OCEAN TERRITORY (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "ECUADOR",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "EL SALVADOR",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "GUAM",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "HAITI",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "MARSHALL ISLANDS (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "MICRONESIA (FEDERATED STATES OF)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "NORTHERN MARIANA ISLANDS (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "PALAU",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "PANAMA",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "PUERTO RICO",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "TIMOR-LESTE",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "TURKS AND CAICOS ISLANDS (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "UNITED STATES MINOR OUTLYING ISLANDS (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "UNITED STATES OF AMERICA (THE)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "VIRGIN ISLANDS (BRITISH)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      },
      {
        "country_name": "VIRGIN ISLANDS (U.S.)",
        "currency_name": "US Dollar",
        "currency_iso_code": "USD",
        "currency_number": "840",
        "currency_mnr_unts": "2",
        "currency_symbol": "$"
      }
    ],
    "currency": "USD"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.