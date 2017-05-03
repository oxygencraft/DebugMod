using System;
using Command = Pathfinder.Command;
using Hacknet;

namespace DebugMod
{
    public class DebugMod : Pathfinder.IPathfinderMod
    {

        public string GetIdentifier()
        {
            return "Debug Mod";
        }

        public string Identifier
        {
            get
            {
                return GetIdentifier();
            }
        }

        public void Load()
        {
            Console.WriteLine("Loading Debug Mod");
        }

        public void LoadContent()
        {
            bool DebugEnabled = true;
            bool SettingsChanger = true;
            Command.Handler.AddCommand("openAllPorts", Commands.OpenAllPorts, autoComplete:true); // Works
            Command.Handler.AddCommand("bypassProxy", Commands.BypassProxy, autoComplete:true); // Works
            Command.Handler.AddCommand("solveFirewall", Commands.SolveFirewall, autoComplete:true); // Works
            Command.Handler.AddCommand("getAdmin", Commands.GetAdmin, autoComplete:true); // Works
            Command.Handler.AddCommand("loseAdmin", Commands.LoseAdmin, autoComplete:true); // Works
            if (SettingsChanger)
            {
                Settings.AllowExtensionPublish = true;
                Settings.debugDrawEnabled = true;
                //Settings.DrawHexBackground = true;
                Settings.isSpecialTestBuild = true;
                Settings.isServerMode = true;
                Settings.testingMenuItemsEnabled = true;
                Settings.slowOSStartup = false;
                Settings.HasLabyrinthsDemoStartMainMenuButton = true;
                Settings.FastBootText = true;
            }
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
                Command.Handler.AddCommand("changeMusic", Commands.ChangeMusic, autoComplete:false); // Fixed
                Command.Handler.AddCommand("crashComputer", Commands.CrashComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("addProxy", Commands.AddProxy, autoComplete:false); // Works
                Command.Handler.AddCommand("addFirewall", Commands.AddFirewall, autoComplete:false); // Works
                Command.Handler.AddCommand("addUser", Commands.AddUser, autoComplete:false); // Works
                Command.Handler.AddCommand("openPort", Commands.OpenPort, autoComplete:false); 
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
                Command.Handler.AddCommand("setTheme", Commands.SetTheme, autoComplete:false);  // Works
                Command.Handler.AddCommand("setCustomTheme", Commands.SetCustomTheme, autoComplete:false); // Works
                Command.Handler.AddCommand("linkComputer", Commands.LinkComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("unlinkComputer", Commands.UnlinkComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("loseAllNodes", Commands.LoseAllNodes, autoComplete:false); // Works
                Command.Handler.AddCommand("loseNode", Commands.LoseNode, autoComplete:false); // Works
                Command.Handler.AddCommand("revealNode", Commands.RevealNode, autoComplete:false); // Works
                Command.Handler.AddCommand("removeComputer", Commands.RemoveComputer, autoComplete:false); // Works
                Command.Handler.AddCommand("resetIP", Commands.ResetIP, autoComplete:false); // Works
                Command.Handler.AddCommand("resetPlayerCompIP", Commands.ResetPlayerCompIP, autoComplete:false); // Works
                Command.Handler.AddCommand("setIP", Commands.SetIP, autoComplete:false); // Works
                Command.Handler.AddCommand("showFlags", Commands.ShowFlags, autoComplete: false); // Works
                Command.Handler.AddCommand("addFlag", Commands.AddFlag, autoComplete: false); // Works
                Command.Handler.AddCommand("removeFlag", Commands.RemoveFlag, autoComplete: false); // Works
                Command.Handler.AddCommand("authenticateToIRC", Commands.AuthenticateToIRC, autoComplete: false); // Works
                Command.Handler.AddCommand("addAgentToIRC", Commands.AddAgentToIRC, autoComplete: false); // Works
                Command.Handler.AddCommand("setCompPorts", Commands.SetCompPorts, autoComplete: false); // Works
                //Command.Handler.AddCommand("removePortFromComp", Commands.RemovePortFromComp, autoComplete: false); Replaced with setCompPorts
                Command.Handler.AddCommand("addSongChangerDaemon", Commands.AddSongChangerDaemon, autoComplete: false); // Works
                Command.Handler.AddCommand("addRicerConnectDaemon", Commands.AddRicerConnectDaemon, autoComplete: false); // Works
                Command.Handler.AddCommand("addDLCCreditsDaemon", Commands.AddDLCCreditsDaemon, autoComplete: false); // Works
                //Command.Handler.AddCommand("addIRCDaemon", Commands.AddIRCDaemon, autoComplete: false);
                Command.Handler.AddCommand("addISPDaemon", Commands.AddISPDaemon, autoComplete: false); // Works
                Command.Handler.AddCommand("quit", Commands.Quit, autoComplete: false); // Works
                Command.Handler.AddCommand("deleteLogs", Commands.DeleteLogs, autoComplete: false); // Works
                Command.Handler.AddCommand("forkbombProof", Commands.ForkbombProof, autoComplete: false); // Works

                Command.Handler.AddCommand("changeCompIcon", Commands.ChangeCompIcon, autoComplete: false);
                Command.Handler.AddCommand("removeSongChangerDaemon", Commands.RemoveSongChangerDaemon, autoComplete: false);
                Command.Handler.AddCommand("removeRicerConnectDaemon", Commands.RemoveRicerConnectDaemon, autoComplete: false);
                Command.Handler.AddCommand("removeDLCCreditsDaemon", Commands.RemoveDLCCreditsDaemon, autoComplete: false);
                //Command.Handler.AddCommand("removeIRCDaemon", Commands.RemoveIRCDaemon, autoComplete: false);
                Command.Handler.AddCommand("removeISPDaemon", Commands.RemoveISPDaemon, autoComplete: false);
                Command.Handler.AddCommand("forkbombVirus", Commands.ForkbombVirus, autoComplete: false);
                Command.Handler.AddCommand("installInviolabilty", Commands.InstallInviolabilty, autoComplete: false);
                Command.Handler.AddCommand("removeAllDaemons", Commands.RemoveAllDaemons, autoComplete: false);
                Command.Handler.AddCommand("summonDebugModDaemonComp", Commands.SummonDebugModDaemonComp, autoComplete: false);
                Pathfinder.Daemon.IInterface daemon = new DebugDaemon();
                Pathfinder.Daemon.Handler.AddDaemon("DebugModDaemon", daemon);
            }

        }

        public void Unload()
        {
            Console.WriteLine("Unloading Debug Mod");
        }

    }
}
