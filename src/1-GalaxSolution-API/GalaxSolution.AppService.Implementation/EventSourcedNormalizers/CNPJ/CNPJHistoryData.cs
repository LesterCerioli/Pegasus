namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.CNPJ
{
    public class CNPJHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string NumCNPJ { get; set; }
        public bool Actived { get; set; }
        public string TimeStamp { get; set; }
        public string Who { get; set; }

    }
}
