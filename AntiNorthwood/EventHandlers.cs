using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace AntiNorthwood
{
    public class EventHandlers
    {
        public void OnFurryJoin(PreAuthenticatingEventArgs ev)
        {
            if (ev.UserId.Contains("@northwood"))
            {
                ev.Reject(Plugin.Singleton.Config.message, true);
            }
        }
    }
}
