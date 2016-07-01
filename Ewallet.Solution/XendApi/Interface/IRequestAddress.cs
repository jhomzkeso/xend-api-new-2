using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XendApi.Infrastructure.Addresses;

namespace XendApi.Interface
{
    public interface IRequestAddress
    {
       XendProvince GetProvince(int cityId=0);

       XendCity GetCities(int provinceId = 0);
    }
}
