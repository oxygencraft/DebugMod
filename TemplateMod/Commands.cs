using Hacknet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMod
{
    static class Commands
    {

        public static bool OpenAllPorts(Hacknet.OS os, string[] args)
        {
            string ip = os.thisComputer.ip;
            Computer computer = os.connectedComp;
            Console.WriteLine(computer.ports);
            if (computer.ports.Contains(22))
            {
                computer.openPort(22, ip);
            }
            if (computer.ports.Contains(21))
            {
                computer.openPort(21, ip);
            }
            if (computer.ports.Contains(25))
            {
                computer.openPort(25, ip);
            }
            if (computer.ports.Contains(80))
            {
                computer.openPort(80, ip);
            }
            if (computer.ports.Contains(1433))
            {
                computer.openPort(1433, ip);
            }
            if (computer.ports.Contains(3724))
            {
                computer.openPort(3724, ip);
            }
            if (computer.ports.Contains(104))
            {
                computer.openPort(104, ip);
            }
            if (computer.ports.Contains(3659))
            {
                computer.openPort(3659, ip);
            }
            if (computer.ports.Contains(192))
            {
                computer.openPort(192, ip);
            }
            if (computer.ports.Contains(6881))
            {
                computer.openPort(6881, ip);
            }
            if (computer.ports.Contains(443))
            {
                computer.openPort(443, ip);
            }
            if (computer.ports.Contains(9418))
            {
                computer.openPort(9418, ip);
            }
            return false;
        }

        public static bool BypassProxy(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.proxyActive = false;
            return false;
        }

        public static bool SolveFirewall(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.firewall.solved = true;
            return false;
        }

        public static bool GetAdmin(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.thisComputer.ip;
            return false;
        }

        public static bool DeathSeq(Hacknet.OS os, string[] args)
        {
            os.TraceDangerSequence.BeginTraceDangerSequence();
            return false;
        }
        public static bool CancelDeathSeq(Hacknet.OS os, string[] args)
        {
            os.TraceDangerSequence.CancelTraceDangerSequence();
            return false;
        }

        public static bool SetHomeNodeServer(Hacknet.OS os, string[] args)
        {
            os.homeNodeID = os.connectedComp.idName;
            return false;
        }
        public static bool SetHomeAssetServer(Hacknet.OS os, string[] args)
        {
            os.homeAssetServerID = os.connectedComp.idName;
            return false;
        }
        public static bool Debug(Hacknet.OS os, string[] args)
        {
            int num = PortExploits.services.Count;
            for (int index = 0; index<PortExploits.services.Count && index<num; ++index)
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[PortExploits.portNums[index]], PortExploits.cracks[PortExploits.portNums[index]]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[9], PortExploits.cracks[9]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[10], PortExploits.cracks[10]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[11], PortExploits.cracks[11]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[12], PortExploits.cracks[12]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[13], PortExploits.cracks[13]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[14], PortExploits.cracks[14]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[15], PortExploits.cracks[15]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[16], PortExploits.cracks[16]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[17], PortExploits.cracks[17]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[31], PortExploits.cracks[31]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[33], PortExploits.cracks[33]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[34], PortExploits.cracks[34]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[35], PortExploits.cracks[35]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[36], PortExploits.cracks[36]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[37], PortExploits.cracks[37]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[38], PortExploits.cracks[38]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.crackExeData[39], PortExploits.cracks[39]));
            os.thisComputer.files.root.folders[2].files.Add(new FileEntry(PortExploits.DangerousPacemakerFirmware, "KBT_TestFirmware.dll"));
            return false;
        }
        public static bool LoseAdmin(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.connectedComp.ip;
            return false;
        }
        public static bool RevealAll(Hacknet.OS os, string[] args)
        {
            for (int index = 0; index < os.netMap.nodes.Count; ++index)
                os.netMap.visibleNodes.Add(index);


            return false;
        }
        public static bool AddIRCMessage(Hacknet.OS os, string[] args)
        {
            string computer = args[1];
            string author = args[2];
            string message = args[3];

            if (args.Length < 5)
            {
                os.write("Usage: addIRCMessage (ComputerID) (Author) (Message)");
                return false;
            }

            DLCHubServer IRC = Programs.getComputer(os, computer).getDaemon(typeof(DLCHubServer)) as DLCHubServer;
            IRC.IRCSystem.AddLog(author, message, null);
            return false;
        }
        public static bool StrikerAttack(Hacknet.OS os, string[] args)
        {
            HackerScriptExecuter.runScript("DLC/ActionScripts/Hackers/SystemHack.txt", os, (string)null);
            return false;
        }
        public static bool ThemeAttack(Hacknet.OS os, string[] args)
        {
            HackerScriptExecuter.runScript("HackerScripts/ThemeHack.txt", os, (string)null);
            return false;
        }
        public static bool CallThePoliceSoTheyCanTraceYou(Hacknet.OS os, string[] args)
        {
            os.traceTracker.start(100f);
            return false;
        }
        public static bool ReportYourselfToFBI(Hacknet.OS os, string[] args)
        {
            os.traceTracker.start(20f);
            return false;
        }
        public static bool TraceYourselfIn(Hacknet.OS os, string[] args)
        {
            string TraceTimeInput = args[1];
            float TraceTime;
            try
            {
                int IsNumber = Convert.ToInt32(args[1]);
            }
            catch
            {
                os.write("Usage: TraceYourselfIn: (TimeInSeconds)");
                return false;
            }
            float.TryParse(TraceTimeInput, out TraceTime);
            os.traceTracker.start(TraceTime);
            return false;
        }
        public static bool WarningFlash(Hacknet.OS os, string[] args)
        {
            os.warningFlash();
            return false;
        }
        public static bool StopTrace(Hacknet.OS os, string[] args)
        {
            os.traceTracker.stop();
            return false;
        }
        public static bool HideDisplay(Hacknet.OS os, string[] args)
        {
            os.display.visible = false;
            return false;
        }
        public static bool HideNetMap(Hacknet.OS os, string[] args)
        {
            os.netMap.visible = false;
            return false;
        }
        public static bool HideTerminal(Hacknet.OS os, string[] args)
        {
            os.terminal.visible = false;
            return false;
        }
        public static bool HideRAM(Hacknet.OS os, string[] args)
        {
            os.ram.visible = false;
            return false;
        }
        public static bool ShowDisplay(Hacknet.OS os, string[] args)
        {
            os.display.visible = true;
            return false;
        }
        public static bool ShowNetMap(Hacknet.OS os, string[] args)
        {
            os.netMap.visible = true;
            return false;
        }
        public static bool ShowTerminal(Hacknet.OS os, string[] args)
        {
            os.terminal.visible = true;
            return false;
        }
        public static bool ShowRAM(Hacknet.OS os, string[] args)
        {
            os.ram.visible = true;
            return false;
        }
        public static bool GetUniversalAdmin(Hacknet.OS os, string[] args)
        {
            List<Computer> computerList = os.netMap.nodes;
            string str = os.thisComputer.ip;
            for (int index = 0; index < computerList.Count; ++index)
            {
                computerList[index].adminIP = os.thisComputer.ip;
            }
            return false;
        }
        public static bool HackComputer(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            int RAMAvailable = os.ramAvaliable;
            
            return false;
        }
        public static bool ChangeAdminPassword(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            string newPass = args[1];
            if (args.Length < 0)
            {
                os.write("Usage: changeAdminPassword (NewPassword)");
                return false;
            }
            for (int index = 0; index < computer.users.Count; ++index)
            {
                if (computer.users[index].name.ToLower().Equals("admin"))
                    computer.users[index] = new UserDetail("admin", newPass, (byte)0);
            }
            return false;
        }
        public static bool GenerateExampleAcadmicRecord(Hacknet.OS os, string[] args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FULL NAME HERE\n\n--------------------\nDEGREE HERE\nUNIVERSITY HERE\nGPA HERE";
            folder.files.Add(new FileEntry(File, "FULL NAME HERE"));
            return false;
        }
        public static bool GenerateExampleMedicalRecord(Hacknet.OS os, string[] args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FIRST NAME HERE\n--------------------\nLAST NAME HERE\n--------------------\n male OR female\n--------------------\nDATE OF BIRTH HERE TIME OF BIRTH HERE\n--------------------\nMedical Record\nDate of Birth :: DATE OF BIRTH HERE TIME OF BIRTH HERE\nBlood Type :: BLOOD TYPE HERE\nHeight :: HEIGHT HERE IN CM\n Allergies\nActive Prescriptions :: ACTIVE PRESCRIPTSION HERE\nRecorded Visits :: RECORDED VISTS HERE\nNotes :: NOTES HERE";
            folder.files.Add(new FileEntry(File, "LASTNAMEHERE FIRSTNAMEHERE"));
            return false;
        }
        public static bool ExecuteHack(Hacknet.OS os, string[] args)
        {
            string HackerScript = args[1];
            if (args.Length < 0)
            {
                os.write("Usage: executeHack (HackerScriptLocation)\nHacker script must be in Content/HackerScripts");
                return false;
            }
            HackerScriptExecuter.runScript("HackerScripts/" + HackerScript, (string)null);
            return false;
        }
        public static bool DeleteWhitelistDLL(Hacknet.OS os, string[] args)
        {
            string ip = args[1];
            
            return false;
        }
        public static bool ChangeMusic(Hacknet.OS os, string[] args)
        {
            string song = args[1];
            MusicManager.playSongImmediatley("Content/" + song);
            return false;
        }
        public static bool CrashComputer(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.crash(os.thisComputer.ip);
            return false;
        }
        public static bool AddProxy(Hacknet.OS os, string[] args)
        {
            string ProxyTimeInput = args[1];
            float ProxyTime;
            float.TryParse(ProxyTimeInput, out ProxyTime);
            Computer computer = os.connectedComp;
            if (args.Length < 0)
            {
                os.write("Usage: addProxy (Time)");
                return false;
            }
            computer.addProxy(ProxyTime);
            return false;
        }
        public static bool AddFirewall(Hacknet.OS os, string[] args)
        {
            string Solution = args[1];
            string LevelInput = args[2];
            string AdditionalTimeInput = args[3];
            int Level = Convert.ToInt32(LevelInput);
            float AdditionalTime;
            float.TryParse(AdditionalTimeInput, out AdditionalTime);
            Computer computer = os.connectedComp;
            if (args.Length < 2)
            {
                os.write("Usage: addFirewall (Solution) (Level) [AdditionalTime]");
                return false;
            }
            computer.addFirewall(Level, Solution, AdditionalTime);
            return false;
        }
        public static bool AddUser(Hacknet.OS os, string[] args)
        {
            string Username = args[1];
            string Password = args[2];
            string TypeInput = args[3];
            byte Type = Convert.ToByte(TypeInput);
            Computer computer = os.connectedComp;
            if (args.Length < 3)
            {
                os.write("Usage: addUser (Username) (Password) (Type)");
                return false;
            }
            computer.addNewUser(os.thisComputer.ip, Username, Password, Type);
            return false;
        }
        public static bool OpenPort(Hacknet.OS os, string[] args)
        {
            int port = Convert.ToInt32(args[1]);
            Computer computer = os.thisComputer;
            computer.openPort(port, os.thisComputer.ip);
            return false;
        }
        public static bool CloseAllPorts(Hacknet.OS os, string[] args)
        {
            string ip = os.thisComputer.ip;
            Computer computer = os.connectedComp;
            Console.WriteLine(computer.ports);
            if (computer.ports.Contains(22))
            {
                computer.closePort(22, ip);
            }
            if (computer.ports.Contains(21))
            {
                computer.closePort(21, ip);
            }
            if (computer.ports.Contains(25))
            {
                computer.closePort(25, ip);
            }
            if (computer.ports.Contains(80))
            {
                computer.closePort(80, ip);
            }
            if (computer.ports.Contains(1433))
            {
                computer.closePort(1433, ip);
            }
            if (computer.ports.Contains(3724))
            {
                computer.closePort(3724, ip);
            }
            if (computer.ports.Contains(104))
            {
                computer.closePort(104, ip);
            }
            if (computer.ports.Contains(3659))
            {
                computer.closePort(3659, ip);
            }
            if (computer.ports.Contains(192))
            {
                computer.closePort(192, ip);
            }
            if (computer.ports.Contains(6881))
            {
                computer.closePort(6881, ip);
            }
            if (computer.ports.Contains(443))
            {
                computer.closePort(443, ip);
            }
            if (computer.ports.Contains(9418))
            {
                computer.closePort(9418, ip);
            }
            return false;
        }
        public static bool ClosePort(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            if (args.Length > 1)
            {
                os.write("Usage: closePort (PortToClose)");
                return false;
            }
            int port = Convert.ToInt32(args[1]);
            return false;
        }
        public static bool RemoveProxy(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.hasProxy = false;
            return false;
        }
        /*public static bool RemoveFirewall(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            computer.
            return false;
        } */
        public static bool AddComputer(Hacknet.OS os, string[] args)
        {
            



            Computer computer = new Computer()
            return false;
        }
    }
}
