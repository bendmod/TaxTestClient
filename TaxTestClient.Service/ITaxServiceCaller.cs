using MunicipalTax.Public.Interfaces.v1.Response;

namespace TaxTestClient.Service
{
    public interface ITaxServiceCaller
    {
        GetTaxResponse CallTaxServiceGet(string municipality, string date);
    }
}
