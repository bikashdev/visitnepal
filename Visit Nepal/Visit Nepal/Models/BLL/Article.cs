using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Visit_Nepal.Models.DAL;
using static Visit_Nepal.Models.StatusEnum;

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
        public DateTime InfoUpdateDate { get; set; }
        public Status Status { get; set; }

        #endregion
        #region functions
        public List<Article> GetArticles()
        {
            List<Article> ListOfArticles = new List<Article>();
            try
            {
                using (VisitNepaDataContext db = new VisitNepaDataContext())
                {
                    var result = db.Articles.Where(x => x.Status != (int)StatusEnum.Status.Active).ToList();
                    if (result != null && result.Count > 0)
                    {
                        foreach (var item in result)
                        {
                            Article Art = new Article();
                            Art.InfoId = item.InfoID;
                            Art.InfoCategory = item.InfoCategory;
                            Art.InfoTitle = item.InfoTitle;
                            Art.InfoBody = item.InfoBody;
                            Art.InfoSource = item.InfoSource;
                            Art.InfoUpdateDate = item.InfoUpdateDate;
                            Art.Status = (Status)item.Status;
                            ListOfArticles.Add(Art);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ListOfArticles;
        }
        public string AddArticle(Int64 InfoId, string InfoCategory, string InfoTitle, string InfoBody, string InfoSource, string InfoUpdateDate)
        {
            try
            {
                using (VisitNepaDataContext db = new VisitNepaDataContext())
                {
                    Models.DAL.Article art = new Models.DAL.Article();
                    art.InfoCategory = InfoCategory;
                    art.InfoTitle = InfoTitle;
                    art.InfoBody = InfoBody;
                    art.InfoSource = InfoSource;
                    art.InfoUpdateDate = DateTime.Now;
                    //status 0= deleted, status 1= created and active, status=2 updated
                    art.Status = 1;
                    db.Articles.InsertOnSubmit(art);
                    return "success";
                }
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }
        public void DeleteArticle(Int64 InfoId, string InfoUpdateDate)
        {
            try
            {
                Models.DAL.Article art = new Models.DAL.Article()
                {
                    InfoID = InfoId,
                    Status = 0,
                    InfoUpdateDate = DateTime.Now
                };

                using (VisitNepaDataContext db = new VisitNepaDataContext())
                {
                    var result = db.Articles.FirstOrDefault(a => a.InfoID == InfoId);
                    if (result != null)
                    {
                        db.Articles.Attach(art);
                    }
                    //db.Articles.Attach(art);
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}