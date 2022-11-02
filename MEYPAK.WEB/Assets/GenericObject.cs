namespace MEYPAK.WEB.Assets
{
    public class GenericObject<T> 
    {
        public string GUID { get; set; }
        public T nesne { get; set; }
        public List<T> liste { get; set; }

        
    }
}
