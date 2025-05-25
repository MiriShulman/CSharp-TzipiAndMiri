using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Code { get; }
        public int Id { get; }
        public int? MinimumAmount { get; set; }
        public double? Sum { get; }
        public bool? IsNeedClub { get; }
        public DateTime? BeginSale { get; }
        public DateTime? EndSale { get; }

        public Sale(int code, int id, int? minimumAmount, double? sum, bool? isNeedClub, DateTime? beginSale, DateTime? endSale)
        {
            Code = code;
            Id = id;
            MinimumAmount = minimumAmount;
            Sum = sum;
            IsNeedClub = isNeedClub;
            BeginSale = beginSale;
            EndSale = endSale;
        }

        public override string ToString() => this.ToStringProperty();

        internal object CastSaleToSaleInProduct(Func<Sale> castSale, int? productAmount)
        {
            throw new NotImplementedException();
        }
    }
}
