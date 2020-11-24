using Dapper;
using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Recruitment.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public ArticleModel CreateArticle(ArticleModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"INSERT INTO ARTICLES (headerid, articlename, quantity, net, gross) " +
                            $"VALUES ('{model.HeaderId}','{model.ArticleName}','{model.Quantity}', '{model.Net}', '{model.Gross}' );" +
                            $"SELECT SCOPE_IDENTITY();";
                        var iid = connection.ExecuteScalar(query);
                        model.Id = Convert.ToInt32(iid);
                        MessageBox.Show($"Article {model.ArticleName} added successfully.");
            }
            UpdateHeader(model.HeaderId);
            return model;
        }

        public HeaderModel CreateHeader(HeaderModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                #region todo?
                // TODO? - change to stored procedure spHeader_Insert
                //var p = new DynamicParameters();
                //p.Add("@Date", model.Date);
                //p.Add("@HeaderName", model.HeaderName);
                //p.Add("@CustomerId", model.CustomerId);
                //p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //connection.Execute("spHeader_Insert", p, commandType: CommandType.StoredProcedure);
                //model.Id = p.Get<int>("@id")
                #endregion

                var query = $"INSERT INTO HEADERS (date, headername, customerid) " +
                    $"VALUES ('{model.Date}','{model.HeaderName}','{model.CustomerId}');" +
                    $"SELECT SCOPE_IDENTITY();";
                var iid = connection.ExecuteScalar(query);
                model.Id = Convert.ToInt32(iid);
                MessageBox.Show($"Header {model.HeaderName} added successfully.");
            }
            return model;
        }

        public void DeteleArticle(int articleId, int headerId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"DELETE Articles WHERE id = '{articleId}'";
                connection.Execute(query);
                MessageBox.Show($"Header {articleId} deleted successfully.");
            }
            UpdateHeader(headerId);
        }

        public void DeteleHeader(int headerId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"DELETE Articles WHERE headerid = '{headerId}';" +
                            $"DELETE Headers WHERE id = '{headerId}';";
                connection.Execute(query);
                MessageBox.Show($"Header {headerId} deleted successfully.");
            }
        }

        public List<HeaderModel> GetAllHeaders()
        {
            List<HeaderModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"SELECT id, date, headername, customerid, net, gross FROM Headers";
                output = (List<HeaderModel>)connection.Query<HeaderModel>(query);
            }
            return output;
        }

        public List<ArticleModel> GetAllArticles(int headerid)
        {
            List<ArticleModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"SELECT id, headerid, articlename, quantity, net, gross FROM Articles WHERE headerid='{headerid}'";
                output = (List<ArticleModel>)connection.Query<ArticleModel>(query);
            }
            return output;

        }

        public void UpdateArticle(ArticleModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"UPDATE Articles SET articlename='{model.ArticleName}', quantity='{model.Quantity}', net ='{model.Net}', gross='{model.Gross}' WHERE id = '{model.Id}';";
                connection.Execute(query);
                MessageBox.Show($"Article {model.Id} updated successfully.");
            }
            UpdateHeader(model.HeaderId);

        }

        public void UpdateHeader(HeaderModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"UPDATE Headers SET date='{model.Date}', headername='{model.HeaderName}', customerid='{model.CustomerId}' WHERE id = '{model.Id}';";
                connection.Execute(query);
                MessageBox.Show($"Header {model.Id} updated successfully.");
            }
        }


        private void UpdateHeader(int headerId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionStr()))
            {
                var query = $"SELECT sum(quantity*net) FROM Articles WHERE headerid='{headerId}'";
                var net = connection.ExecuteScalar(query);
                MessageBox.Show($" new net for header {headerId} = {net}");
            }
        }
    }
}
