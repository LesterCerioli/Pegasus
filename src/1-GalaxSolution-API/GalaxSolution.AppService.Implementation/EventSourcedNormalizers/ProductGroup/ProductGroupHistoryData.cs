namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.ProductGroup
{
    public class ProductGroupHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Actived {get; set;}
        public string TimeStamp { get; set; }
        public string Who { get; set; }

    }
}