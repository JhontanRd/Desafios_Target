using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01.Services
{
    public interface CommissionService
    {
        public decimal CommissionRate(decimal amount);
    }
}
