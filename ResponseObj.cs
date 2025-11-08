using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// CountriesFound data
    /// </summary>
    public class CountriesFound
    {
        [JsonProperty("country_name")]
        public string Countryname { get; set; }

        [JsonProperty("currency_name")]
        public string Currencyname { get; set; }

        [JsonProperty("currency_iso_code")]
        public string Currencyisocode { get; set; }

        [JsonProperty("currency_number")]
        public string Currencynumber { get; set; }

        [JsonProperty("currency_mnr_unts")]
        public string Currencymnrunts { get; set; }

        [JsonProperty("currency_symbol")]
        public string Currencysymbol { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("countriesFound")]
        public CountriesFound[] CountriesFound { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
