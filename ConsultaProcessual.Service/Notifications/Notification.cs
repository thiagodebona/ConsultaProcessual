using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaProcessual.Service.Notifications
{
    public class Notificaton
    {
        public string Message { get; }

        public Notificaton(string message)
        {
            Message = message;
        }
    }
}
