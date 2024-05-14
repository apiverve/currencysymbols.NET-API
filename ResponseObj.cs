using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class countriesFound
{
    [JsonProperty("country_name")]
    public string countryname { get; set; }

    [JsonProperty("currency_name")]
    public string currencyname { get; set; }

    [JsonProperty("currency_iso_code")]
    public string currencyisocode { get; set; }

    [JsonProperty("currency_number")]
    public string currencynumber { get; set; }

    [JsonProperty("currency_mnr_unts")]
    public string currencymnrunts { get; set; }

    [JsonProperty("currency_symbol")]
    public string currencysymbol { get; set; }

}

public class data
{
    [JsonProperty("countriesFound")]
    public countriesFound[] countriesFound { get; set; }

    [JsonProperty("currency")]
    public string currency { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
