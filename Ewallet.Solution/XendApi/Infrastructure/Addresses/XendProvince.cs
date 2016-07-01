using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XendApi.Infrastructure.Addresses
{
    public class XendProvince
    {
        public ProvinceDetail[] Data { get; set; }
    }

    public class ProvinceDetail
    {
        public string Province_id { get; set; }
        public string Province { get; set; }
        public string Province_area_id { get; set; }

    }
}
