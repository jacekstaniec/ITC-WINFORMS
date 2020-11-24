using System.Collections.Generic;

namespace Recruitment.Models
{
    public interface IDataConnection
    {
        HeaderModel CreateHeader(HeaderModel model);
        ArticleModel CreateArticle(ArticleModel model);

        List<HeaderModel> GetAllHeaders();
        List<ArticleModel> GetAllArticles(int headerid);

        void DeteleHeader(int headerId);
        void DeteleArticle(int articleId, int headerId);

        void UpdateHeader(HeaderModel model);
        void UpdateArticle(ArticleModel model);
    }
}
