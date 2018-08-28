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
        public string AddArticle()
        {                                
            using(VisitNepaDataContext db = new VisitNepaDataContext())
            {

            }
            return "";

        }
        #endregion

    }


}