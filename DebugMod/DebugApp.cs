using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hacknet;
using Pathfinder;

namespace DebugMod
{
    class DebugAppExe : Pathfinder.Executable.Interface
    {
        public override string Identifier => "DebugAppExe";
        public override bool NeedsProxyAccess => false;
        public override int RamCost => 500;

        public override bool? Update(Pathfinder.Executable.Instance instance, float time)
        {
            return true;
        }
    }
}
