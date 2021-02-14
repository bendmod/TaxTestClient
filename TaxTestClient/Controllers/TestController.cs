using Microsoft.AspNetCore.Mvc;
using MunicipalTax.Public.Interfaces.v1.Response;
using TaxTestClient.Service;

namespace TaxTestClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITaxServiceCaller _taxServiceCaller;

        public TestController(ITaxServiceCaller taxServiceCaller)
        {
            _taxServiceCaller = taxServiceCaller;
        }

        [HttpGet]
        public GetTaxResponse Get(string municipality, string date)
        {
            return _taxServiceCaller.CallTaxServiceGet(municipality, date);
        }
    }
}
