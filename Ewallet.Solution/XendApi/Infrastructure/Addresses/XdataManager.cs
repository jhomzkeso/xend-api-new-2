using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XendApi.Configuration;

namespace XendApi.Infrastructure.Addresses
{
    public class XdataManager
    {
        public static Xdata InitializeXData(int id = 0)
        {
            Xdata xdata = new XdataProvince()
            {
                Account_no = XENDENDPOINTCONFIG.XEND_ACCOUNT_NUMBER,

                Province_id = id
            };

            return xdata;
        }

        public static XdataAddress InitializeXDataAddress(int cityid)
        {
            XdataAddress xdata = new XdataAddress()
            {
                Account_no = XENDENDPOINTCONFIG.XEND_ACCOUNT_NUMBER,

                City_id = cityid
            };

            return xdata;
        }
    }
}
