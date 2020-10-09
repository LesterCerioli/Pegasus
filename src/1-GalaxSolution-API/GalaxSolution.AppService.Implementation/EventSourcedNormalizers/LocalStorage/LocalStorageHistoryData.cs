namespace GalaxSolution.AppService.Implemementation.EventSourcedNormalizers.LocalStorage
{
    public class LocalStorageHistoriData
    {
        public string Action { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Actived { get; set; }
        public object Timestamp { get; internal set; }

    }

}