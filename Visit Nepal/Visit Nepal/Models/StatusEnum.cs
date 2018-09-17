using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visit_Nepal.Models
{
    public sealed class StatusEnum
    {
        public enum Status : int
        {
            Deleted=0,
            Active= 1,
            Modified=2
        }
    }
}