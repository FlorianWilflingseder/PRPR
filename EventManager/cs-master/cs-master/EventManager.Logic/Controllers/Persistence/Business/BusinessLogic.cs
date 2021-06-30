using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Logic.Controllers.Persistence.Business
{
    public static class BusinessLogic
    {
        public static bool VerifyName(string name)
        {
            foreach(char c in name)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
