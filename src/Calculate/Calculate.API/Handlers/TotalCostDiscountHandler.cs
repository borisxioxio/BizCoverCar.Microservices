using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Calculate.API.Commands;
using MediatR;
namespace Calculate.API.Handlers
{
    public class TotalCostDiscountHandler : IRequestHandler<TotalCostDiscountCommand, TotalCostDiscountRespone>
    {
        private IHttpClientFactory clientFactory;

        public TotalCostDiscountHandler(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<TotalCostDiscountRespone> Handle(TotalCostDiscountCommand request, CancellationToken cancellationToken)
        {
          //  var req = new HttpRequestMessage(HttpMethod.Get,
          //"https://localhost:56707/api/cars/get");
          //  req.Headers.Add("Access-Control-Allow-origin", "*");
          //  req.Headers.Add("Accept", "*/*");
          //  req.Headers.Add("User-Agent", "HttpClientFactory-Sample");
          //  var client = clientFactory.CreateClient();
          //  var resp = await client.SendAsync(req);
          //  if (resp.IsSuccessStatusCode)
          //  {
          //      using var responseStream = await resp.Content.ReadAsStreamAsync();
               
          //  }

            return await (Task<TotalCostDiscountRespone>)Task.CompletedTask;
        }
    }
}
