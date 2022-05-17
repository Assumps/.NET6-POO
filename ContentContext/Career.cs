namespace OO.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
        : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // expression body ( usada quando voce so precisa de um retorno para a propriedade )
    }

    
}