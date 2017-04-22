using System;
using Command = Pathfinder.Command;

namespace OpenAllPortsMod
{
    public class OpenAllPortsMod : Pathfinder.PathfinderMod
    {
        public override string GetIdentifier()
        {
            return "Open All Ports Mod";
        }

        public override void Load()
        {
            Console.WriteLine("Loading Open All Ports Mod");
        }

        public override void LoadContent()
        {
            bool DebugEnabled = true;
            Command.Handler.AddCommand("openAllPorts", Commands.OpenAllPorts, true); // Works
            Command.Handler.AddCommand("bypassProxy", Commands.BypassProxy, true); // Works
            Command.Handler.AddCommand("solveFirewall", Commands.SolveFirewall, true); // Works
            Command.Handler.AddCommand("getAdmin", Commands.GetAdmin, true); // Works
            Command.Handler.AddCommand("loseAdmin", Commands.LoseAdmin, true); // Works
            if (DebugEnabled)
            {
                Command.Handler.AddCommand("startDeathSeq", Commands.DeathSeq, false); // Works
                Command.Handler.AddCommand("cancelDeathSeq", Commands.CancelDeathSeq, false); // Works
                Command.Handler.AddCommand("setHomeNodeServer", Commands.SetHomeNodeServer, false); // Works
                Command.Handler.AddCommand("setHomeAssetServer", Commands.SetHomeAssetServer, false); // Works
                Command.Handler.AddCommand("debug", Commands.Debug, false); // Works
                Command.Handler.AddCommand("revealAll", Commands.RevealAll, false); // Works
                Command.Handler.AddCommand("addIRCMessage", Commands.AddIRCMessage, false); // Works
                Command.Handler.AddCommand("strikerAttack", Commands.StrikerAttack, false); // Works
                Command.Handler.AddCommand("themeAttack", Commands.ThemeAttack, false); // Works
                Command.Handler.AddCommand("callThePoliceSoTheyCanTraceYou", Commands.CallThePoliceSoTheyCanTraceYou, false); // Works
                Command.Handler.AddCommand("reportYourselfToFBI", Commands.ReportYourselfToFBI, false); // Works
                Command.Handler.AddCommand("traceYourselfIn", Commands.TraceYourselfIn, false); // Works
                Command.Handler.AddCommand("warningFlash", Commands.WarningFlash, false); // Works
                Command.Handler.AddCommand("stopTrace", Commands.StopTrace, false); // Works
                Command.Handler.AddCommand("hideDisplay", Commands.HideDisplay, false); // Works
                Command.Handler.AddCommand("hideNetMap", Commands.HideNetMap, false); // Works
                Command.Handler.AddCommand("hideTerminal", Commands.HideTerminal, false); // Works
                Command.Handler.AddCommand("hideRAM", Commands.HideRAM, false); // Works
                Command.Handler.AddCommand("showDisplay", Commands.ShowDisplay, false); // Works
                Command.Handler.AddCommand("showNetMap", Commands.ShowNetMap, false); // Works
                Command.Handler.AddCommand("showTerminal", Commands.ShowTerminal, false); // Unknown
                Command.Handler.AddCommand("showRAM", Commands.ShowRAM, false); // Works
                Command.Handler.AddCommand("getUniversalAdmin", Commands.GetUniversalAdmin, false); // Works
                Command.Handler.AddCommand("changeUserDetails", Commands.ChangeUserDetails, false); // Partial
                //Command.Handler.AddCommand("executeHack", Commands.ExecuteHack, false);
                Command.Handler.AddCommand("generateExampleAcademicRecord", Commands.GenerateExampleAcadmicRecord, false); // Works
                Command.Handler.AddCommand("generateExampleMedicalRecord", Commands.GenerateExampleMedicalRecord, false); // Fixed
                //Command.Handler.AddCommand("changeMusic", Commands.ChangeMusic, false); // Fixed
                Command.Handler.AddCommand("crashComputer", Commands.CrashComputer, false); // Works
                Command.Handler.AddCommand("addProxy", Commands.AddProxy, false); // Works
                Command.Handler.AddCommand("addFirewall", Commands.AddFirewall, false); // Works
                Command.Handler.AddCommand("addUser", Commands.AddUser, false); // Works
                //Command.Handler.AddCommand("openPort", Commands.OpenPort, false); 
                Command.Handler.AddCommand("closeAllPorts", Commands.CloseAllPorts, false); // Works
                Command.Handler.AddCommand("closePort", Commands.ClosePort, false); // Fixed
                Command.Handler.AddCommand("removeProxy", Commands.RemoveProxy, false); // Works
                Command.Handler.AddCommand("playSFX", Commands.PlaySFX, false); // Works
                Command.Handler.AddCommand("DeleteWhitelistDLL", Commands.DeleteWhitelistDLL, false); // Works
                Command.Handler.AddCommand("addComputer", Commands.AddComputer, false); // Works
                Command.Handler.AddCommand("getMoreRAM", Commands.GetMoreRAM, false); // Works
                Command.Handler.AddCommand("setFaction", Commands.SetFaction, false); // Works
                Command.Handler.AddCommand("tracedBehind250Proxies", Commands.TracedBehind250Proxies, false); // Works
                Command.Handler.AddCommand("oxygencraftStorageFacilityCache", Commands.OxygencraftStorageFaciltyCache, false); // Don't tell anyone about this command, keep it a secret
                Command.Handler.AddCommand("disableEmailIcon", Commands.DisableEmailIcon, false); // Works
                Command.Handler.AddCommand("enableEmailIcon", Commands.EnableEmailIcon, false); // Works
                Command.Handler.AddCommand("nodeRestore", Commands.NodeRestore, false); // Unknown
                Command.Handler.AddCommand("addWhiteCircle", Commands.AddRestoreCircle, false); // Works
                Command.Handler.AddCommand("whitelistBypass", Commands.WhitelistBypass, false);
            }

        }

        public override void Unload()
        {
            Console.WriteLine("Unloading Open All Ports Mod");
        }

    }
}
