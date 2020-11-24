using System;

namespace Recruitment.Models
{
    public class HeaderModel
    {
        protected HeaderModel() { }
        public HeaderModel(DateTime date, int customerId, string headerName)
        {
            Date = date;
            CustomerId = customerId;
            HeaderName = headerName;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string HeaderName { get; set; }
        public int CustomerId { get; set; }
        public float Net { get; private set; }
        public float Gross { get; private set; }
        public string IdHeaderName 
        {
            get { return $"{HeaderName} (id: {Id})"; }
        }

    }
}
