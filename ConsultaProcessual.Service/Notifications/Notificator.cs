using ConsultaProcessual.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ConsultaProcessual.Service.Notifications
{
    public class Notificator : INotificator
    {
        private List<Notificaton> _notifications;
        public bool HasNotifications() => _notifications.Any();
        public List<Notificaton> GetNotifications() => _notifications;
        public void Forward(Notificaton notification) => _notifications.Add(notification);
    }
}
