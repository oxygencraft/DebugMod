using System;
using Command = Pathfinder.Command;
using Hacknet;
using Pathfinder.Event;
using System.Net;

namespace DebugMod
{
    public class DebugMod : Pathfinder.IPathfinderMod
    {
        public static string version = "2.0-beta3";
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
            Command.Handler.ResgisterCommand("openAllPorts", Commands.OpenAllPorts, autoComplete:true); // Works
            Command.Handler.ResgisterCommand("bypassProxy", Commands.BypassProxy, autoComplete:true); // Works
            Command.Handler.ResgisterCommand("solveFirewall", Commands.SolveFirewall, autoComplete:true); // Works
            Command.Handler.ResgisterCommand("getAdmin", Commands.GetAdmin, autoComplete:true); // Works
            Command.Handler.ResgisterCommand("loseAdmin", Commands.LoseAdmin, autoComplete:true); // Works
            bool SettingsChanger = true;
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
                Command.Handler.ResgisterCommand("startDeathSeq", Commands.DeathSeq, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("cancelDeathSeq", Commands.CancelDeathSeq, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("setHomeNodeServer", Commands.SetHomeNodeServer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("setHomeAssetServer", Commands.SetHomeAssetServer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("debug", Commands.Debug, autoComplete:false); // Works   
                Command.Handler.ResgisterCommand("revealAll", Commands.RevealAll, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("addIRCMessage", Commands.AddIRCMessage, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("strikerAttack", Commands.StrikerAttack, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("themeAttack", Commands.ThemeAttack, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("callThePoliceSoTheyCanTraceYou", Commands.CallThePoliceSoTheyCanTraceYou, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("reportYourselfToFBI", Commands.ReportYourselfToFBI, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("traceYourselfIn", Commands.TraceYourselfIn, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("warningFlash", Commands.WarningFlash, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("stopTrace", Commands.StopTrace, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("hideDisplay", Commands.HideDisplay, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("hideNetMap", Commands.HideNetMap, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("hideTerminal", Commands.HideTerminal, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("hideRAM", Commands.HideRAM, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("showDisplay", Commands.ShowDisplay, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("showNetMap", Commands.ShowNetMap, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("showTerminal", Commands.ShowTerminal, autoComplete:false); // Unknown
                Command.Handler.ResgisterCommand("showRAM", Commands.ShowRAM, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("getUniversalAdmin", Commands.GetUniversalAdmin, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("changeUserDetails", Commands.ChangeUserDetails, autoComplete:false); // Partial
                //Command.Handler.ResgisterCommand("executeHack", Commands.ExecuteHack, autoComplete:false);
                Command.Handler.ResgisterCommand("generateExampleAcademicRecord", Commands.GenerateExampleAcadmicRecord, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("generateExampleMedicalRecord", Commands.GenerateExampleMedicalRecord, autoComplete:false); // Fixed
                Command.Handler.ResgisterCommand("changeMusic", Commands.ChangeMusic, autoComplete:false); // Fixed
                Command.Handler.ResgisterCommand("crashComputer", Commands.CrashComputer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("addProxy", Commands.AddProxy, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("addFirewall", Commands.AddFirewall, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("addUser", Commands.AddUser, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("openPort", Commands.OpenPort, autoComplete:false); 
                Command.Handler.ResgisterCommand("closeAllPorts", Commands.CloseAllPorts, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("closePort", Commands.ClosePort, autoComplete:false); // Fixed
                Command.Handler.ResgisterCommand("removeProxy", Commands.RemoveProxy, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("playSFX", Commands.PlaySFX, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("deleteWhitelistDLL", Commands.DeleteWhitelistDLL, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("addComputer", Commands.AddComputer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("getMoreRAM", Commands.GetMoreRAM, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("setFaction", Commands.SetFaction, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("tracedBehind250Proxies", Commands.TracedBehind250Proxies, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("oxygencraftStorageFacilityCache", Commands.OxygencraftStorageFaciltyCache, autoComplete:false); // Don't tell anyone about this command, keep it a secret: Note: Bugged
                Command.Handler.ResgisterCommand("disableEmailIcon", Commands.DisableEmailIcon, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("enableEmailIcon", Commands.EnableEmailIcon, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("nodeRestore", Commands.NodeRestore, autoComplete:false); // Unknown
                Command.Handler.ResgisterCommand("addWhiteCircle", Commands.AddRestoreCircle, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("whitelistBypass", Commands.WhitelistBypass, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("setTheme", Commands.SetTheme, autoComplete:false);  // Works
                Command.Handler.ResgisterCommand("setCustomTheme", Commands.SetCustomTheme, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("linkComputer", Commands.LinkComputer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("unlinkComputer", Commands.UnlinkComputer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("loseAllNodes", Commands.LoseAllNodes, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("loseNode", Commands.LoseNode, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("revealNode", Commands.RevealNode, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("removeComputer", Commands.RemoveComputer, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("resetIP", Commands.ResetIP, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("resetPlayerCompIP", Commands.ResetPlayerCompIP, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("setIP", Commands.SetIP, autoComplete:false); // Works
                Command.Handler.ResgisterCommand("showFlags", Commands.ShowFlags, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("addFlag", Commands.AddFlag, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("removeFlag", Commands.RemoveFlag, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("authenticateToIRC", Commands.AuthenticateToIRC, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("addAgentToIRC", Commands.AddAgentToIRC, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("setCompPorts", Commands.SetCompPorts, autoComplete: false); // Works
                //Command.Handler.ResgisterCommand("removePortFromComp", Commands.RemovePortFromComp, autoComplete: false); Replaced with setCompPorts
                Command.Handler.ResgisterCommand("addSongChangerDaemon", Commands.AddSongChangerDaemon, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("addRicerConnectDaemon", Commands.AddRicerConnectDaemon, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("addDLCCreditsDaemon", Commands.AddDLCCreditsDaemon, autoComplete: false); // Works
                //Command.Handler.ResgisterCommand("addIRCDaemon", Commands.AddIRCDaemon, autoComplete: false);
                Command.Handler.ResgisterCommand("addISPDaemon", Commands.AddISPDaemon, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("quit", Commands.Quit, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("deleteLogs", Commands.DeleteLogs, autoComplete: false); // Works
                Command.Handler.ResgisterCommand("forkbombProof", Commands.ForkbombProof, autoComplete: false); // Works

                Command.Handler.ResgisterCommand("changeCompIcon", Commands.ChangeCompIcon, autoComplete: false);
                Command.Handler.ResgisterCommand("removeSongChangerDaemon", Commands.RemoveSongChangerDaemon, autoComplete: false);
                Command.Handler.ResgisterCommand("removeRicerConnectDaemon", Commands.RemoveRicerConnectDaemon, autoComplete: false);
                Command.Handler.ResgisterCommand("removeDLCCreditsDaemon", Commands.RemoveDLCCreditsDaemon, autoComplete: false);
                //Command.Handler.ResgisterCommand("removeIRCDaemon", Commands.RemoveIRCDaemon, autoComplete: false);
                Command.Handler.ResgisterCommand("removeISPDaemon", Commands.RemoveISPDaemon, autoComplete: false);
                Command.Handler.ResgisterCommand("forkbombVirus", Commands.ForkbombVirus, autoComplete: false);
                Command.Handler.ResgisterCommand("installInviolabilty", Commands.InstallInviolabilty, autoComplete: false);
                Command.Handler.ResgisterCommand("removeAllDaemons", Commands.RemoveAllDaemons, autoComplete: false);
                Command.Handler.ResgisterCommand("showIPNamesAndID", Commands.ShowIPNamesAndID, autoComplete: false);
                Command.Handler.ResgisterCommand("changeAdmin", Commands.ChangeAdmin, autoComplete: false);
                Command.Handler.ResgisterCommand("viewAdmin", Commands.ViewAdmin, autoComplete: false);
                Command.Handler.ResgisterCommand("tellPeopleYouAreGonnaHackThemOnline", Commands.TellPeopleYouAreGonnaHackThemOnline, autoComplete: false);
                Command.Handler.ResgisterCommand("myFatherIsCCC", Commands.MyFatherIsCCC, autoComplete: false);
                Command.Handler.ResgisterCommand("cantTouchThis", Commands.CantTouchThis, autoComplete: false);
                Command.Handler.ResgisterCommand("replayPlaneMission", Commands.ReplayPlaneMission, autoComplete: false);
                Command.Handler.ResgisterCommand("replayPlaneMissionSecondary", Commands.ReplayPlaneMissionSecondary, autoComplete: false);
                Command.Handler.ResgisterCommand("viewFaction", Commands.ViewFaction, autoComplete: false);
                Command.Handler.ResgisterCommand("viewPlayerVal", Commands.ViewPlayerVal, autoComplete: false);
                Command.Handler.ResgisterCommand("kaguyaTrialEffect", Commands.KaguyaTrialEffect, autoComplete: false);
                Command.Handler.ResgisterCommand("kaguyaTrialEffect2", Commands.KaguyaTrialEffect2, autoComplete: false);
                Command.Handler.ResgisterCommand("kaguyaTrialEffect3", Commands.KaguyaTrialEffect3, autoComplete: false);
                Command.Handler.ResgisterCommand("summonDebugModDaemonComp", Commands.SummonDebugModDaemonComp, autoComplete: false);
                Pathfinder.Daemon.IInterface daemon = new DebugDaemon();
                Pathfinder.Daemon.Handler.RegisterDaemon("DebugModDaemon", daemon);
                /*if (version != newVersion)
                {
                    EventManager.RegisterListener<Pathfinder.Event.OSLoadSaveFileEvent>(NewUpdateAlert);
                }*/
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
