using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Visit_Nepal.Models.DAL;

namespace Visit_Nepal.Models.BLL
{
    public class Article
    {
        #region variables                           
        public Int64 InfoId { get; set; }
        public string InfoCategory { get; set; }
        public string InfoTitle { get; set; }
        public string InfoBody { get; set; }
        public string InfoSource { get; set; }
        public string InfoUpdateDate { get; set; }

        #endregion
        #region functions
        public string AddArticle(Article article)
        {
            try
            {
                using (VisitNepaDataContext db = new VisitNepaDataContext())
                {
                    Visit_Nepal.Models.DAL.Article dbArticle = new Visit_Nepal.Models.DAL.Article()
                    {
                        InfoBody = article.InfoBody,
                        InfoCategory = article.InfoCategory,
                        InfoID = article.InfoId,
                        InfoSource = article.InfoSource,
                        InfoTitle = article.InfoTitle,
                        InfoUpdateDate = Convert.ToDateTime(article.InfoUpdateDate),
                    };

                    db.Articles.InsertOnSubmit(dbArticle);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }          
            
            return "";

        }
        #endregion

    }


}