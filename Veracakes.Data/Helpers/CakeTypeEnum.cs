using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Veracakes.Data.Helpers.Enums
{
    public class CakeTypeEnum
    {
        public enum CakeType
        {
            
            [Description("Cupcake")]
            Cupcake = 1,

            [Description("SheetCake")]
            SheetCake = 2,

            SpecialtyCake = 3
        }
    }
}
