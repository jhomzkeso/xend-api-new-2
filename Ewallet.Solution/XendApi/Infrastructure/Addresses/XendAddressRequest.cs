using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XendApi.Configuration;
using XendApi.Infrastructure.Authentication;
using XendApi.Infrastructure.DataRequester;
using XendApi.Interface;

namespace XendApi.Infrastructure.Addresses
{
    public class XendAddressRequest : IRequestAddress
    {
        private readonly IAuthenticate _authentication;
        
        private string _token;

        private Uri _provinceEndPoint;

        private Uri _citiesEndPoint;

        public XendAddressRequest(IAuthenticate authentication)
        {
            this._authentication = authentication;

            this._token = this._authentication.Authenticate();

            this._provinceEndPoint = new Uri(XENDENDPOINTCONFIG.ADDRESS_PROVINCES_ENDPOINT + this._token);

            this._citiesEndPoint = new Uri(XENDENDPOINTCONFIG.ADDRESS_CITIES_ENDPOINT + this._token);
           
        }

        public XendProvince GetProvince(int cityId = 0)
        {
            string parameters = string.Format("xdata={0}", InitializeXDataParameters(cityId));

            string response = XendDataManager.GetData(this._provinceEndPoint, parameters);

            return XendDataManager.GetObjects<XendProvince>(response);
        }

        public XendCity GetCities(int provinceId = 0)
        {
            string parameters = string.Format("xdata={0}", InitializeXDataParameters(provinceId));

            string response = XendDataManager.GetData(this._citiesEndPoint, parameters);

            return XendDataManager.GetObjects<XendCity>(response);
        }

        private  string InitializeXDataParameters(int id)
        {
            Xdata xdata = XdataManager.InitializeXData(id);

            string json = JsonConvert.SerializeObject(xdata, Formatting.None, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            return json;
        }
    }
}
