
namespace XendApi.Infrastructure.Addresses
{
    public class XendCity
    {
        public CityDetail[] Data { get; set; }
    }

    public class CityDetail
    {
        public string City_id { get; set; }
        public string City { get; set; }
        public string City_code { get; set; }
        public string Province_id { get; set; }
        public string Iata_code { get; set; }
    }
}
