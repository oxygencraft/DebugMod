using System;
using Command = Pathfinder.Command;
using Hacknet;
using Pathfinder.Event;
using System.Net;

namespace DebugMod
{
    public class DebugMod : Pathfinder.ModManager.IMod
    {
        public static string version = "2.0-beta2.5c";
        public static string newVersion = GetVersion();
        public string GetIdentifier()
        {
            return "Debug Mod";
        }

        private static string GetVersion()
        {
            WebClient client = new WebClient();
            return client.DownloadString("https://raw.githubusercontent.com/oxygencraft/DebugMod/master/VersionFile.txt");
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
            Command.Handler.RegisterCommand("openAllPorts", Commands.OpenAllPorts, autoComplete:true); // Works
            Command.Handler.RegisterCommand("bypassProxy", Commands.BypassProxy, autoComplete:true); // Works
            Command.Handler.RegisterCommand("solveFirewall", Commands.SolveFirewall, autoComplete:true); // Works
            Command.Handler.RegisterCommand("getAdmin", Commands.GetAdmin, autoComplete:true); // Works
            Command.Handler.RegisterCommand("loseAdmin", Commands.LoseAdmin, autoComplete:true); // Works


            if (DebugEnabled)
            {
                Command.Handler.RegisterCommand("startDeathSeq", Commands.DeathSeq, autoComplete:false); // Works
                Command.Handler.RegisterCommand("cancelDeathSeq", Commands.CancelDeathSeq, autoComplete:false); // Works
                Command.Handler.RegisterCommand("setHomeNodeServer", Commands.SetHomeNodeServer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("setHomeAssetServer", Commands.SetHomeAssetServer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("debug", Commands.Debug, autoComplete:false); // Works   
                Command.Handler.RegisterCommand("revealAll", Commands.RevealAll, autoComplete:false); // Works
                Command.Handler.RegisterCommand("addIRCMessage", Commands.AddIRCMessage, autoComplete:false); // Works
                Command.Handler.RegisterCommand("strikerAttack", Commands.StrikerAttack, autoComplete:false); // Works
                Command.Handler.RegisterCommand("themeAttack", Commands.ThemeAttack, autoComplete:false); // Works
                Command.Handler.RegisterCommand("callThePoliceSoTheyCanTraceYou", Commands.CallThePoliceSoTheyCanTraceYou, autoComplete:false); // Works
                Command.Handler.RegisterCommand("reportYourselfToFBI", Commands.ReportYourselfToFBI, autoComplete:false); // Works
                Command.Handler.RegisterCommand("traceYourselfIn", Commands.TraceYourselfIn, autoComplete:false); // Works
                Command.Handler.RegisterCommand("warningFlash", Commands.WarningFlash, autoComplete:false); // Works
                Command.Handler.RegisterCommand("stopTrace", Commands.StopTrace, autoComplete:false); // Works
                Command.Handler.RegisterCommand("hideDisplay", Commands.HideDisplay, autoComplete:false); // Works
                Command.Handler.RegisterCommand("hideNetMap", Commands.HideNetMap, autoComplete:false); // Works
                Command.Handler.RegisterCommand("hideTerminal", Commands.HideTerminal, autoComplete:false); // Works
                Command.Handler.RegisterCommand("hideRAM", Commands.HideRAM, autoComplete:false); // Works
                Command.Handler.RegisterCommand("showDisplay", Commands.ShowDisplay, autoComplete:false); // Works
                Command.Handler.RegisterCommand("showNetMap", Commands.ShowNetMap, autoComplete:false); // Works
                Command.Handler.RegisterCommand("showTerminal", Commands.ShowTerminal, autoComplete:false); // Unknown
                Command.Handler.RegisterCommand("showRAM", Commands.ShowRAM, autoComplete:false); // Works
                Command.Handler.RegisterCommand("getUniversalAdmin", Commands.GetUniversalAdmin, autoComplete:false); // Works
                Command.Handler.RegisterCommand("changeUserDetails", Commands.ChangeUserDetails, autoComplete:false); // Partial
                //Command.Handler.RegisterCommand("executeHack", Commands.ExecuteHack, autoComplete:false);
                Command.Handler.RegisterCommand("generateExampleAcademicRecord", Commands.GenerateExampleAcadmicRecord, autoComplete:false); // Works
                Command.Handler.RegisterCommand("generateExampleMedicalRecord", Commands.GenerateExampleMedicalRecord, autoComplete:false); // Fixed
                Command.Handler.RegisterCommand("changeMusic", Commands.ChangeMusic, autoComplete:false); // Fixed
                Command.Handler.RegisterCommand("crashComputer", Commands.CrashComputer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("addProxy", Commands.AddProxy, autoComplete:false); // Works
                Command.Handler.RegisterCommand("addFirewall", Commands.AddFirewall, autoComplete:false); // Works
                Command.Handler.RegisterCommand("addUser", Commands.AddUser, autoComplete:false); // Works
                Command.Handler.RegisterCommand("openPort", Commands.OpenPort, autoComplete:false); 
                Command.Handler.RegisterCommand("closeAllPorts", Commands.CloseAllPorts, autoComplete:false); // Works
                Command.Handler.RegisterCommand("closePort", Commands.ClosePort, autoComplete:false); // Fixed
                Command.Handler.RegisterCommand("removeProxy", Commands.RemoveProxy, autoComplete:false); // Works
                Command.Handler.RegisterCommand("playSFX", Commands.PlaySFX, autoComplete:false); // Works
                Command.Handler.RegisterCommand("deleteWhitelistDLL", Commands.DeleteWhitelistDLL, autoComplete:false); // Works
                Command.Handler.RegisterCommand("addComputer", Commands.AddComputer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("getMoreRAM", Commands.GetMoreRAM, autoComplete:false); // Works
                Command.Handler.RegisterCommand("setFaction", Commands.SetFaction, autoComplete:false); // Works
                Command.Handler.RegisterCommand("tracedBehind250Proxies", Commands.TracedBehind250Proxies, autoComplete:false); // Works
                Command.Handler.RegisterCommand("oxygencraftStorageFacilityCache", Commands.OxygencraftStorageFaciltyCache, autoComplete:false); // Don't tell anyone about this command, keep it a secret: Note: Bugged
                Command.Handler.RegisterCommand("disableEmailIcon", Commands.DisableEmailIcon, autoComplete:false); // Works
                Command.Handler.RegisterCommand("enableEmailIcon", Commands.EnableEmailIcon, autoComplete:false); // Works
                Command.Handler.RegisterCommand("nodeRestore", Commands.NodeRestore, autoComplete:false); // Unknown
                Command.Handler.RegisterCommand("addWhiteCircle", Commands.AddRestoreCircle, autoComplete:false); // Works
                Command.Handler.RegisterCommand("whitelistBypass", Commands.WhitelistBypass, autoComplete:false); // Works
                Command.Handler.RegisterCommand("setTheme", Commands.SetTheme, autoComplete:false);  // Works
                Command.Handler.RegisterCommand("setCustomTheme", Commands.SetCustomTheme, autoComplete:false); // Works
                Command.Handler.RegisterCommand("linkComputer", Commands.LinkComputer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("unlinkComputer", Commands.UnlinkComputer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("loseAllNodes", Commands.LoseAllNodes, autoComplete:false); // Works
                Command.Handler.RegisterCommand("loseNode", Commands.LoseNode, autoComplete:false); // Works
                Command.Handler.RegisterCommand("revealNode", Commands.RevealNode, autoComplete:false); // Works
                Command.Handler.RegisterCommand("removeComputer", Commands.RemoveComputer, autoComplete:false); // Works
                Command.Handler.RegisterCommand("resetIP", Commands.ResetIP, autoComplete:false); // Works
                Command.Handler.RegisterCommand("resetPlayerCompIP", Commands.ResetPlayerCompIP, autoComplete:false); // Works
                Command.Handler.RegisterCommand("setIP", Commands.SetIP, autoComplete:false); // Works
                Command.Handler.RegisterCommand("showFlags", Commands.ShowFlags, autoComplete: false); // Works
                Command.Handler.RegisterCommand("addFlag", Commands.AddFlag, autoComplete: false); // Works
                Command.Handler.RegisterCommand("removeFlag", Commands.RemoveFlag, autoComplete: false); // Works
                Command.Handler.RegisterCommand("authenticateToIRC", Commands.AuthenticateToIRC, autoComplete: false); // Works
                Command.Handler.RegisterCommand("addAgentToIRC", Commands.AddAgentToIRC, autoComplete: false); // Works
                Command.Handler.RegisterCommand("setCompPorts", Commands.SetCompPorts, autoComplete: false); // Works
                //Command.Handler.RegisterCommand("removePortFromComp", Commands.RemovePortFromComp, autoComplete: false); Replaced with setCompPorts
                Command.Handler.RegisterCommand("addSongChangerDaemon", Commands.AddSongChangerDaemon, autoComplete: false); // Works
                Command.Handler.RegisterCommand("addRicerConnectDaemon", Commands.AddRicerConnectDaemon, autoComplete: false); // Works
                Command.Handler.RegisterCommand("addDLCCreditsDaemon", Commands.AddDLCCreditsDaemon, autoComplete: false); // Works
                //Command.Handler.RegisterCommand("addIRCDaemon", Commands.AddIRCDaemon, autoComplete: false);
                Command.Handler.RegisterCommand("addISPDaemon", Commands.AddISPDaemon, autoComplete: false); // Works
                Command.Handler.RegisterCommand("quit", Commands.Quit, autoComplete: false); // Works
                Command.Handler.RegisterCommand("deleteLogs", Commands.DeleteLogs, autoComplete: false); // Works
                Command.Handler.RegisterCommand("forkbombProof", Commands.ForkbombProof, autoComplete: false); // Works

                Command.Handler.RegisterCommand("changeCompIcon", Commands.ChangeCompIcon, autoComplete: false);
                Command.Handler.RegisterCommand("removeSongChangerDaemon", Commands.RemoveSongChangerDaemon, autoComplete: false);
                Command.Handler.RegisterCommand("removeRicerConnectDaemon", Commands.RemoveRicerConnectDaemon, autoComplete: false);
                Command.Handler.RegisterCommand("removeDLCCreditsDaemon", Commands.RemoveDLCCreditsDaemon, autoComplete: false);
                //Command.Handler.RegisterCommand("removeIRCDaemon", Commands.RemoveIRCDaemon, autoComplete: false);
                Command.Handler.RegisterCommand("removeISPDaemon", Commands.RemoveISPDaemon, autoComplete: false);
                Command.Handler.RegisterCommand("forkbombVirus", Commands.ForkbombVirus, autoComplete: false);
                Command.Handler.RegisterCommand("installInviolabilty", Commands.InstallInviolabilty, autoComplete: false);
                Command.Handler.RegisterCommand("removeAllDaemons", Commands.RemoveAllDaemons, autoComplete: false);
                Command.Handler.RegisterCommand("showIPNamesAndID", Commands.ShowIPNamesAndID, autoComplete: false);
                Command.Handler.RegisterCommand("changeAdmin", Commands.ChangeAdmin, autoComplete: false);
                Command.Handler.RegisterCommand("viewAdmin", Commands.ViewAdmin, autoComplete: false);
                Command.Handler.RegisterCommand("tellPeopleYouAreGonnaHackThemOnline", Commands.TellPeopleYouAreGonnaHackThemOnline, autoComplete: false);
                Command.Handler.RegisterCommand("myFatherIsCCC", Commands.MyFatherIsCCC, autoComplete: false);
                Command.Handler.RegisterCommand("cantTouchThis", Commands.CantTouchThis, autoComplete: false);
                Command.Handler.RegisterCommand("replayPlaneMission", Commands.ReplayPlaneMission, autoComplete: false);
                Command.Handler.RegisterCommand("replayPlaneMissionSecondary", Commands.ReplayPlaneMissionSecondary, autoComplete: false);
                Command.Handler.RegisterCommand("viewFaction", Commands.ViewFaction, autoComplete: false);
                Command.Handler.RegisterCommand("viewPlayerVal", Commands.ViewPlayerVal, autoComplete: false);
                Command.Handler.RegisterCommand("kaguyaTrialEffect", Commands.KaguyaTrialEffect, autoComplete: false);
                Command.Handler.RegisterCommand("kaguyaTrialEffect2", Commands.KaguyaTrialEffect2, autoComplete: false);
                Command.Handler.RegisterCommand("kaguyaTrialEffect3", Commands.KaguyaTrialEffect3, autoComplete: false);
                Command.Handler.RegisterCommand("summonDebugModDaemonComp", Commands.SummonDebugModDaemonComp, autoComplete: false);
                Pathfinder.Daemon.IInterface daemon = new DebugDaemon();
                Pathfinder.Daemon.Handler.RegisterDaemon("DebugModDaemon", daemon);
                /*if (version != newVersion)
                {
                    EventManager.RegisterListener<OSLoadSaveFileEvent>(NewUpdateAlert);
                } */
            }
        }

        public void NewUpdateAlert(OSLoadSaveFileEvent obj)
        {
            OS os = obj.OS;
            double time = 6;
            Action action = (Action)(() =>
            {
                os.write("New update of Debug Mod is available");
                os.write("You are currently running: " + version + "New version: " + newVersion);
            });
            os.delayer.Post(ActionDelayer.Wait(time), action);
            obj.IsCancelled = true;
        }

        public void Unload()
        {
            Console.WriteLine("Unloading Debug Mod");
        }

    }
}
