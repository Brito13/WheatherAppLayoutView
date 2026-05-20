namespace WheatherAppLayoutView.Models
{
    public class CityWheater
    {
        public string CityUniqueCode { get; set; }
        public string CityName { get; set; }
        public DateTime? DateAndTime { get; set; }
        int Temperature { get; set; }
    }
}
