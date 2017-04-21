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
            Command.Handler.AddCommand("openAllPorts", Commands.OpenAllPorts, true);
            Command.Handler.AddCommand("bypassProxy", Commands.BypassProxy, true);
            Command.Handler.AddCommand("solveFirewall", Commands.SolveFirewall, true);
            Command.Handler.AddCommand("getAdmin", Commands.GetAdmin, true);
            Command.Handler.AddCommand("loseAdmin", Commands.LoseAdmin, true);
            if (DebugEnabled)
            {
                Command.Handler.AddCommand("startDeathSeq", Commands.DeathSeq, false);
                Command.Handler.AddCommand("cancelDeathSeq", Commands.CancelDeathSeq, false);
                Command.Handler.AddCommand("setHomeNodeServer", Commands.SetHomeNodeServer, false);
                Command.Handler.AddCommand("setHomeAssetServer", Commands.SetHomeAssetServer, false);
                Command.Handler.AddCommand("debug", Commands.Debug, false);
                Command.Handler.AddCommand("revealAll", Commands.RevealAll, false);
                Command.Handler.AddCommand("addIRCMessage", Commands.AddIRCMessage, false);
                Command.Handler.AddCommand("strikerAttack", Commands.StrikerAttack, false);
                Command.Handler.AddCommand("themeAttack", Commands.ThemeAttack, false);
                Command.Handler.AddCommand("callThePoliceSoTheyCanTraceYou", Commands.CallThePoliceSoTheyCanTraceYou, false);
                Command.Handler.AddCommand("reportYourselfToFBI", Commands.ReportYourselfToFBI, false);
                Command.Handler.AddCommand("traceYourselfIn", Commands.TraceYourselfIn, false);
                Command.Handler.AddCommand("warningFlash", Commands.WarningFlash, false);
                Command.Handler.AddCommand("stopTrace", Commands.StopTrace, false);
                Command.Handler.AddCommand("hideDisplay", Commands.HideDisplay, false);
                Command.Handler.AddCommand("hideNetMap", Commands.HideNetMap, false);
                Command.Handler.AddCommand("hideTerminal", Commands.HideTerminal, false);
                Command.Handler.AddCommand("hideRAM", Commands.HideRAM, false);
                Command.Handler.AddCommand("showDisplay", Commands.ShowDisplay, false);
                Command.Handler.AddCommand("showNetMap", Commands.ShowNetMap, false);
                Command.Handler.AddCommand("showTerminal", Commands.ShowTerminal, false);
                Command.Handler.AddCommand("showRAM", Commands.ShowRAM, false);
                Command.Handler.AddCommand("getUniversalAdmin", Commands.GetUniversalAdmin, false);
                Command.Handler.AddCommand("changeUserDetails", Commands.ChangeUserDetails, false);
                Command.Handler.AddCommand("executeHack", Commands.ExecuteHack, false);
                Command.Handler.AddCommand("generateExampleAcademicRecord", Commands.GenerateExampleAcadmicRecord, false);
                Command.Handler.AddCommand("generateExampleMedicalRecord", Commands.GenerateExampleMedicalRecord, false);
                Command.Handler.AddCommand("changeMusic", Commands.ChangeMusic, false);
                Command.Handler.AddCommand("crashComputer", Commands.CrashComputer, false);
                Command.Handler.AddCommand("addProxy", Commands.AddProxy, false);
                Command.Handler.AddCommand("addFirewall", Commands.AddFirewall, false);
                Command.Handler.AddCommand("addUser", Commands.AddUser, false);
                Command.Handler.AddCommand("openPort", Commands.OpenPort, false);
                Command.Handler.AddCommand("closeAllPorts", Commands.CloseAllPorts, false);
                Command.Handler.AddCommand("closePort", Commands.ClosePort, false);
                Command.Handler.AddCommand("removeProxy", Commands.RemoveProxy, false);
                Command.Handler.AddCommand("playSFX", Commands.PlaySFX, false);
            }

        }

        public override void Unload()
        {
            Console.WriteLine("Unloading Open All Ports Mod");
        }

    }
}
