using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hacknet;

namespace DebugMod
{
    class AlwaysActiveAdmin : Administrator
    {
        public override void disconnectionDetected(Computer c, OS os)
        {
            base.disconnectionDetected(c, os);
            for (int index = 0; index < c.ports.Count; ++index)
                c.closePort(c.ports[index], "LOCAL_ADMIN");
            if (c.firewall != null)
            {
                c.firewall.resetSolutionProgress();
                c.firewall.solved = false;
            }
            if (c.hasProxy)
            {
                c.proxyActive = true;
                c.proxyOverloadTicks = c.startingOverloadTicks;
            }
            Action action = (Action)(() =>
            {
                if (os.connectedComp != null && !(os.connectedComp.ip != c.ip))
                    return;
                for (int index = 0; index < c.ports.Count; ++index)
                    c.closePort(c.ports[index], "LOCAL_ADMIN");
                if (this.ResetsPassword)
                    c.setAdminPassword(PortExploits.getRandomPassword());
                c.adminIP = c.ip;
                if (c.firewall != null)
                    c.firewall.resetSolutionProgress();
            });
            action();
            double time;
            if (c.securityLevel == 0)
            {
                time = 60;
            } else if (c.securityLevel == 2) {
                time = 50.5;
            } else if (c.securityLevel == 4)
            {
                time = 25;
            } else
            {
                time = 10;
            }
            os.delayer.Post(ActionDelayer.Wait(time), action);
            os.timerExpired();
        }
    }
}
