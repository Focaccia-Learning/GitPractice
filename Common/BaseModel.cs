using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice.Common
{
    public class BaseModel
    {
        public int DB_APPNO { get; set; }
        public DateTime DB_CRDAT { get; set; }
        public int DB_CRUSR { get; set; }

        public DateTime? DB_TRDAT { get; set; }
        public int? DB_TRUSR { get; set; }
    }
}
