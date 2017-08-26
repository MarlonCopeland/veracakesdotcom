using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unjaded.Core.MVC
{ 
    public interface IModel
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifyDate { get; set; }
        bool IsActive { get; set; }
        int? CreatedSessionID { get; set; }
        int? ModifySessionID { get; set; }
        
    }
}
