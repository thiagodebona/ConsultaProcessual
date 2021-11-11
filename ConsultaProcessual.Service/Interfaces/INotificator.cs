using ConsultaProcessual.Service.Notifications;
using System.Collections.Generic;

namespace ConsultaProcessual.Service.Interfaces
{
    public interface INotificator
    {
        public bool HasNotifications();
        public List<Notificaton> GetNotifications();
        public void Forward(Notificaton notificacao);
    }
}
