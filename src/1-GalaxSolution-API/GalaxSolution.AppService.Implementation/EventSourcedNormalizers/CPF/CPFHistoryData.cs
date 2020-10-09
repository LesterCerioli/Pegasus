namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.CPF
{
    public class CPFHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string NumCPF { get; set; }
        public bool Actived { get; set; }
        public string TimeStamp { get; set; }
        public string Who { get; set; }

    }
}