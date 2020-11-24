namespace Recruitment.Models
{
    public class ArticleModel
    {
        protected ArticleModel() { }
        public ArticleModel(int headerId, string articleName, int quantity, float net)
        {
            HeaderId = headerId;
            ArticleName = articleName;
            Quantity = quantity;
            Net = net;
            Gross = quantity * net * GlobalConfig.VAT;
        }

        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string ArticleName { get; set; }
        public int Quantity { get; set; }
        public float Net { get; set; }
        public float Gross { get; private set; }
        public string IdArticleName
        {
            get { return $"{ArticleName} (id: {Id})"; }
        }

    }
}
