using Hacknet;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA = Microsoft.Xna.Framework;

namespace OpenAllPortsMod
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
        public static bool ChangeUserDetails(Hacknet.OS os, string[] args)
        {
            Computer computer = os.connectedComp;
            string oldUser = args[1];
            string newUser = args[2];
            string newPass = args[3];
            if (args.Length < 3)
            {
                os.write("Usage: changeUserDetails (NewPassword)");
                return false;
            }
            for (int index = 0; index < computer.users.Count; ++index)
            {
                if (computer.users[index].name.ToLower().Equals(oldUser))
                    computer.users[index] = new UserDetail(newUser, newPass, (byte)0);
                    UserDetail user = computer.users[index];
                    user.known = true;
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
            Computer computer = Programs.getComputer(os, args[1]);
            computer.deleteFile(os.thisComputer.ip, "authenticator.dll", );
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
            if (args.Length < 5)
            {
                os.write("Usage: addComputer (Name) (IP) (SecurityLevel) (CompType) (ID)");
                return false;
            }
            try
            {
                int IsNumber = Convert.ToInt32(args[3]);
                byte IsByte = Convert.ToByte(args[4]);
            }
            catch
            {
                os.write("Usage: addComputer (Name) (IP) (SecurityLevel) (CompType) (ID)");
                return false;
            }
            string Name = args[1];
            string IP = args[2];
            int SecurityLevel = Convert.ToInt32(args[3]);
            byte CompType = Convert.ToByte(args[4]);
            string ID = args[5];
            Computer computer = new Computer(Name, IP, os.netMap.getRandomPosition(), SecurityLevel, CompType, os);
            computer.idName = ID;
            return false;
        }
        public static bool PlaySFX(Hacknet.OS os, string[] args)
        {
            SoundEffect sound = os.content.Load<SoundEffect>(args[1]);
            sound.Play();
            return false;
        }
        public static bool GetMoreRAM(Hacknet.OS os, string[] args)
        {
            os.totalRam = 2048;
            return false;
        }
        public static bool SetFaction(Hacknet.OS os, string[] args)
        {
            string factionInput = args[1];
            if (factionInput == "entropy")
            {
                os.allFactions.setCurrentFaction("entropy", os);
            }
            else if (factionInput == "csec")
            {
                os.allFactions.setCurrentFaction("hub", os);
            }
            else if (factionInput == "bibliotheque")
            {
                os.allFactions.setCurrentFaction("Bibliotheque", os);
            }
            else
            {
                os.write("Usage: setFaction entropy/csec");
            }
            return false;
        }
        public static bool TracedBehind250Proxies(Hacknet.OS os, string[] args)
        {
            os.traceTracker.start(500f);
            return false;
        }
        public static bool OxygencraftStorageFaciltyCache(Hacknet.OS os, string[] args) // Don't tell anyone about this command, keep it a secret
        {
            Computer computer = new Computer("oxygencraft Storage Facility", "4825.18.385.2956", os.netMap.getRandomPosition(), 2000, 2, os);
            computer.idName = "oxyStorageCache";
            computer.adminPass = "edhufguHUFHJGHLRWEHU32867837@!^&*$^&#@^&74";
            computer.admin.IsSuper = true;
            computer.admin.ResetsPassword = true;
            computer.addFirewall(25, "ijijUFERHUHUGR2184327567uGgyregyhwuiEHUT43UHI887328", 15);
            computer.portsNeededForCrack = 13;
            computer.addProxy(3600);
            computer.HasTracker = true;
            computer.traceTime = 45f;
            computer.ports.Add(25);
            computer.ports.Add(22);
            computer.ports.Add(21);
            computer.ports.Add(80);
            computer.ports.Add(1433);
            computer.ports.Add(104);
            computer.ports.Add(3724);
            computer.ports.Add(443);
            computer.ports.Add(6881);
            computer.ports.Add(192);
            computer.ports.Add(3659);
            computer.ports.Add(9418);
            for (int index = 0; index < computer.users.Count; ++index)
            {
                if (computer.users[index].name.ToLower().Equals("admin")) {
                    UserDetail user = computer.users[index];
                    if (os.username == "oxygencraft")
                    {
                        user.known = true;
                    }
                }
            }
            Folder bin = computer.files.root.searchForFolder("bin");
            bin.files.Add(new FileEntry(PortExploits.crackExeData[25], Utils.GetNonRepeatingFilename("SMTPoverflow", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[22], Utils.GetNonRepeatingFilename("SSHCrack", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[21], Utils.GetNonRepeatingFilename("FTPBounce", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[211], Utils.GetNonRepeatingFilename("FTPSprint", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[80], Utils.GetNonRepeatingFilename("WebServerWorm", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[1433], Utils.GetNonRepeatingFilename("SQL_MemCorrupt", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[104], Utils.GetNonRepeatingFilename("KBT_PortTest", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[3724], Utils.GetNonRepeatingFilename("WoWHack", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[443], Utils.GetNonRepeatingFilename("SSLTrojan", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[6881], Utils.GetNonRepeatingFilename("TorrentStreamInjector", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[192], Utils.GetNonRepeatingFilename("PacificPortcrusher", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[3659], Utils.GetNonRepeatingFilename("confloodEOS", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[9418], Utils.GetNonRepeatingFilename("GitTunnel", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[4], Utils.GetNonRepeatingFilename("SecurityTracer", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[9], Utils.GetNonRepeatingFilename("Decypher", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[10], Utils.GetNonRepeatingFilename("DECHead", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[11], Utils.GetNonRepeatingFilename("Clock", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[12], Utils.GetNonRepeatingFilename("TraceKill", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[13], Utils.GetNonRepeatingFilename("eosDeviceScan", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[14], Utils.GetNonRepeatingFilename("themechanger", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[15], Utils.GetNonRepeatingFilename("hacknet", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[16], Utils.GetNonRepeatingFilename("HexClock", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[17], Utils.GetNonRepeatingFilename("Sequencer", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[31], Utils.GetNonRepeatingFilename("KaguyaTrials", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[32], Utils.GetNonRepeatingFilename("SignalScramble", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[33], Utils.GetNonRepeatingFilename("MemForensics", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[34], Utils.GetNonRepeatingFilename("MemDumpGenerator", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[35], Utils.GetNonRepeatingFilename("NetMapOrganizer", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[36], Utils.GetNonRepeatingFilename("ComShell", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[37], Utils.GetNonRepeatingFilename("DNotes", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[38], Utils.GetNonRepeatingFilename("ClockV2", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.crackExeData[39], Utils.GetNonRepeatingFilename("TuneSwap", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.DangerousPacemakerFirmware, Utils.GetNonRepeatingFilename("PacemakerDangerous", ".dll", bin)));
            bin.files.Add(new FileEntry(PortExploits.ValidPacemakerFirmware, Utils.GetNonRepeatingFilename("PacemakerWorking", ".exe", bin)));
            bin.files.Add(new FileEntry(PortExploits.ValidAircraftOperatingDLL, Utils.GetNonRepeatingFilename("747FlightSystem", ".dll", bin)));
            return false;
        }
        public static bool DisableEmailIcon(Hacknet.OS os, string[] args)
        {
            os.DisableEmailIcon = true;
            return false;
        }
        public static bool EnableEmailIcon(Hacknet.OS os, string[] args)
        {
            os.DisableEmailIcon = false;
            return false;
        }
        public static bool NodeRestore(Hacknet.OS os, string[] args)
        {
            DLC1SessionUpgrader.ReDsicoverAllVisibleNodesInOSCache(os);
            return false;
        }
        public static bool AddRestoreCircle(Hacknet.OS os, string[] args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            SFX.addCircle(computer.getScreenSpacePosition(), Utils.AddativeWhite * 0.4f, 70f);
            return false;
        }
        /*public static bool WhitelistBypass(Hacknet.OS os, string[] args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            
            return false;
        } */
    }
}
