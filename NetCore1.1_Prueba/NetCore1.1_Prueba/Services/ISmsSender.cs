using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore1._1_Prueba.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
