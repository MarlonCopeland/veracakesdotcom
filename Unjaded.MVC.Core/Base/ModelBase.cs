using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unjaded.Core.MVC
{
    [Serializable]
    public class ModelBase: IModel
    {
        public ModelBase()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
            CreatedSessionID = CreatedSessionID;
        }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedSessionID { get; set; }
        public int? ModifySessionID { get; set; }

        
    }
}
