using MunicipalTax.Public.Interfaces.v1.Response;
using RestSharp;
using System.Text.Json;

namespace TaxTestClient.Service
{
    public class TaxServiceCaller : ITaxServiceCaller
    {
        public GetTaxResponse CallTaxServiceGet(string municipality, string date)
        {
            var client = new RestClient("http://localhost:13284/Tax");
            var request = new RestRequest(Method.GET);
            request.AddParameter("municipalityName", municipality);
            request.AddParameter("date", date);
            var response = client.Get(request);
            var tax = JsonSerializer.Deserialize<GetTaxResponse>(response.Content);
            return tax;
        }
    }
}
