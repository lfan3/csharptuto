using System;

namespace ParticalClassSpace
{
    public partial class ParticalClass
    {
        private string Author_name;
        private int Total_articles;

        public ParticalClass(string name, int articleNum)
        {
            this.Author_name = name;
            this.Total_articles = articleNum;
        }
    }
}