using Consumindo_WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_WebAPI.Interface
{
    public interface IAdvice
    {
        public Task<AdviceResponse> AdviceGet();
    }
}
