using System;
using Command = Pathfinder.Command;

namespace OpenAllPortsMod
{
    public class OpenAllPortsMod : Pathfinder.IPathfinderMod
    {

        public string GetIdentifier()
        {
            return "Debug Mod";
        }

        public string Identifier => GetIdentifier();

        public void Load()
        {
            Console.WriteLine("Loading Debug Mod");
        }

        public void LoadContent()
        {
            bool DebugEnabled = true;
            Command.Handler.AddCommand("openAllPorts", Commands.OpenAllPorts, autoComplete:true); // Works
            Command.Handler.AddCommand("bypassProxy", Commands.BypassProxy, autoComplete:true); // Works
            Command.Handler.AddCommand("solveFirewall", Commands.SolveFirewall, autoComplete:true); // Works
            Command.Handler.AddCommand("getAdmin", Commands.GetAdmin, autoComplete:true); // Works
            Command.Handler.AddCommand("loseAdmin", Commands.LoseAdmin, autoComplete:true); // Works
            if (DebugEnabled)
            {
                Command.Handler.AddCommand("startDeathSeq", Commands.DeathSeq, autoComplete:false); // Works
                Command.Handler.AddCommand("cancelDeathSeq", Commands.CancelDeathSeq, autoComplete:false); // Works
                Command.Handler.AddCommand("setHomeNodeServer", Commands.SetHomeNodeServer, autoComplete:false); // Works
                Command.Handler.AddCommand("setHomeAssetServer", Commands.SetHomeAssetServer, autoComplete:false); // Works
                Command.Handler.AddCommand("debug", Commands.Debug, autoComplete:false); // Works
                Command.Handler.AddCommand("revealAll", Commands.RevealAll, autoComplete:false); // Works
                Command.Handler.AddCommand("addIRCMessage", Commands.AddIRCMessage, autoComplete:false); // Works
                Command.Handler.AddCommand("strikerAttack", Commands.StrikerAttack, autoComplete:false); // Works
                Command.Handler.AddCommand("themeAttack", Commands.ThemeAttack, autoComplete:false); // Works
                Command.Handler.AddCommand("callThePoliceSoTheyCanTraceYou", Commands.CallThePoliceSoTheyCanTraceYou, autoComplete:false); // Works
                Command.Handler.AddCommand("reportYourselfToFBI", Commands.ReportYourselfToFBI, autoComplete:false); // Works
                Command.Handler.AddCommand("traceYourselfIn", Commands.TraceYourselfIn, autoComplete:false); // Works
                Command.Handler.AddCommand("warningFlash", Commands.WarningFlash, autoComplete:false); // Works
                Command.Handler.AddCommand("stopTrace", Commands.StopTrace, autoComplete:false); // Works
                Command.Handler.AddCommand("hideDisplay", Commands.HideDisplay, autoComplete:false); // Works
                Command.Handler.AddCommand("hideNetMap", Commands.HideNetMap, autoComplete:false); // Works
                Command.Handler.AddCommand("hideTerminal", Commands.HideTerminal, autoComplete:false); // Works
                Command.Handler.AddCommand("hideRAM", Commands.HideRAM, autoComplete:false); // Works
                Command.Handler.AddCommand("showDisplay", Commands.ShowDisplay, autoComplete:false); // Works
                Command.Handler.AddCommand("showNetMap", Commands.ShowNetMap, autoComplete:false); // Works
                Command.Handler.AddCommand("showTerminal", Commands.ShowTerminal, autoComplete:false); // Unknown
                Command.Handler.AddCommand("showRAM", Commands.ShowRAM, autoComplete:false); // Works
                Command.Handler.AddCommand("getUniversalAdmin", Commands.GetUniversalAdmin, autoComplete:false); // Works
                Command.Handler.AddCommand("changeUserDetails", Commands.ChangeUserDetails, autoComplete:false); // Partial
                //Command.Handler.AddCommand("executeHack", Commands.ExecuteHack, autoComplete:false);
                Command.Handler.AddCommand("generateExampleAcademicRecord", Commands.GenerateExampleAcadmicRecord, autoComplete:false); // Works
                Command.Handler.AddCommand("generateExampleMedicalRecord", Commands.GenerateExampleMedicalRecord, autoComplete:false); // Fixed
                //Command.Handler.AddCommand("changeMusic", Commands.ChangeMusic, autoComplete:false); // Fixed
                Command.Handler.AddCommand("crashComputer", Commands.CrashComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("addProxy", Commands.AddProxy, autoComplete:false); // Works
                Command.Handler.AddCommand("addFirewall", Commands.AddFirewall, autoComplete:false); // Works
                Command.Handler.AddCommand("addUser", Commands.AddUser, autoComplete:false); // Works
                //Command.Handler.AddCommand("openPort", Commands.OpenPort, autoComplete:false); 
                Command.Handler.AddCommand("closeAllPorts", Commands.CloseAllPorts, autoComplete:false); // Works
                Command.Handler.AddCommand("closePort", Commands.ClosePort, autoComplete:false); // Fixed
                Command.Handler.AddCommand("removeProxy", Commands.RemoveProxy, autoComplete:false); // Works
                Command.Handler.AddCommand("playSFX", Commands.PlaySFX, autoComplete:false); // Works
                Command.Handler.AddCommand("deleteWhitelistDLL", Commands.DeleteWhitelistDLL, autoComplete:false); // Works
                Command.Handler.AddCommand("addComputer", Commands.AddComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("getMoreRAM", Commands.GetMoreRAM, autoComplete:false); // Works
                Command.Handler.AddCommand("setFaction", Commands.SetFaction, autoComplete:false); // Works
                Command.Handler.AddCommand("tracedBehind250Proxies", Commands.TracedBehind250Proxies, autoComplete:false); // Works
                Command.Handler.AddCommand("oxygencraftStorageFacilityCache", Commands.OxygencraftStorageFaciltyCache, autoComplete:false); // Don't tell anyone about this command, keep it a secret: Note: Bugged
                Command.Handler.AddCommand("disableEmailIcon", Commands.DisableEmailIcon, autoComplete:false); // Works
                Command.Handler.AddCommand("enableEmailIcon", Commands.EnableEmailIcon, autoComplete:false); // Works
                Command.Handler.AddCommand("nodeRestore", Commands.NodeRestore, autoComplete:false); // Unknown
                Command.Handler.AddCommand("addWhiteCircle", Commands.AddRestoreCircle, autoComplete:false); // Works
                Command.Handler.AddCommand("whitelistBypass", Commands.WhitelistBypass, autoComplete:false); // Works
                Command.Handler.AddCommand("setTheme", Commands.SetTheme, autoComplete:false);
                Command.Handler.AddCommand("setCustomTheme", Commands.SetCustomTheme, autoComplete:false);
                Command.Handler.AddCommand("linkComputer", Commands.LinkComputer, autoComplete:false);
                Command.Handler.AddCommand("unlinkComputer", Commands.UnlinkComputer, autoComplete:false);
                Command.Handler.AddCommand("loseAllNodes", Commands.LoseAllNodes, autoComplete:false);
                Command.Handler.AddCommand("loseNode", Commands.LoseNode, autoComplete:false);
                Command.Handler.AddCommand("revealNode", Commands.RevealNode, autoComplete:false);
                Command.Handler.AddCommand("removeComputer", Commands.RemoveComputer, autoComplete:false);
                Command.Handler.AddCommand("resetIP", Commands.ResetIP, autoComplete:false);
                Command.Handler.AddCommand("resetPlayerCompIP", Commands.ResetPlayerCompIP, autoComplete:false);
                Command.Handler.AddCommand("setIP", Commands.SetTheme, autoComplete:false);
            }

        }

        public void Unload()
        {
            Console.WriteLine("Unloading Debug Mod");
        }

    }
}
