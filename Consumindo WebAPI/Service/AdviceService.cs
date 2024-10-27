using Consumindo_WebAPI.Entities;
using Consumindo_WebAPI.Interface;
using Consumindo_WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_WebAPI.Service
{
    public class AdviceService : IAdviceService
    {
        private readonly IAdvice _advice;

        public AdviceService(IAdvice advice)
        {
            _advice = advice;
        }

        public async Task<AdviceResponse> AdviceServiceGet()
        {
            var response = _advice.AdviceGet();
            if (response is null)
            {
                Console.WriteLine("Erro ao chamar API, ela não retornou o Json");
            }

                return await response;
        }
    }
}
