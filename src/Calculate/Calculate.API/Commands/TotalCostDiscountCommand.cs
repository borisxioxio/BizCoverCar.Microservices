using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
namespace Calculate.API.Commands
{
    public class TotalCostDiscountCommand: IRequest<TotalCostDiscountRespone>
    {
        public List<int> ids { get; set; }
    }

    public class TotalCostDiscountRespone
    {
        public decimal discount { get; set; }
    }
}
