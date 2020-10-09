namespace GalaxSolution.AppService.Implemementation.EventSourcedNormalizers.City
{
    public class CityHistoryData
    {
        public string Action { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Actived { get; set; }
        public string Timestamp { get;  set; }
        public string Who { get; set; }
    }
}