using Hacknet;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA = Microsoft.Xna.Framework;

namespace DebugMod
{
    static class Commands
    {

        public static bool OpenAllPorts(OS os, List<string> args)
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
        public static bool CloseAllPorts(OS os, List<string> args)
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
        public static bool BypassProxy(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.proxyActive = false;
            return false;
        }

        public static bool SolveFirewall(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.firewall.solved = true;
            return false;
        }

        public static bool GetAdmin(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.thisComputer.ip;
            return false;
        }

        public static bool DeathSeq(OS os, List<string> args)
        {
            os.TraceDangerSequence.BeginTraceDangerSequence();
            return false;
        }
        public static bool CancelDeathSeq(OS os, List<string> args)
        {
            os.TraceDangerSequence.CancelTraceDangerSequence();
            return false;
        }

        public static bool SetHomeNodeServer(OS os, List<string> args)
        {
            os.homeNodeID = os.connectedComp.idName;
            return false;
        }
        public static bool SetHomeAssetServer(OS os, List<string> args)
        {
            os.homeAssetServerID = os.connectedComp.idName;
            return false;
        }
        public static bool Debug(OS os, List<string> args)
        {
            int num = PortExploits.services.Count;
            for (int index = 0; index < PortExploits.services.Count && index < num; ++index)
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
        public static bool LoseAdmin(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.connectedComp.ip;
            return false;
        }
        public static bool RevealAll(OS os, List<string> args)
        {
            for (int index = 0; index < os.netMap.nodes.Count; ++index)
                os.netMap.visibleNodes.Add(index);


            return false;
        }
        public static bool AddIRCMessage(OS os, List<string> args)
        {
            string computer = args[1];
            string author = args[2];
            string message = args[3];
            if (args.Count < 3)
            {
                os.write("Usage: addIRCMessage (ComputerID) (Author) (Message)");
                return false;
            }

            DLCHubServer IRC = Programs.getComputer(os, computer).getDaemon(typeof(DLCHubServer)) as DLCHubServer;
            IRC.IRCSystem.AddLog(author, message, null);
            return false;
        }
        public static bool StrikerAttack(OS os, List<string> args)
        {
            HackerScriptExecuter.runScript("DLC/ActionScripts/Hackers/SystemHack.txt", (object)os, (string)null);
            return false;
        }
        public static bool ThemeAttack(OS os, List<string> args)
        {
            HackerScriptExecuter.runScript("HackerScripts/ThemeHack.txt", (object)os, (string)null);
            return false;
        }
        public static bool CallThePoliceSoTheyCanTraceYou(OS os, List<string> args)
        {
            os.traceTracker.start(100f);
            return false;
        }
        public static bool ReportYourselfToFBI(OS os, List<string> args)
        {
            os.traceTracker.start(20f);
            return false;
        }
        public static bool TraceYourselfIn(OS os, List<string> args)
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
        public static bool WarningFlash(OS os, List<string> args)
        {
            os.warningFlash();
            return false;
        }
        public static bool StopTrace(OS os, List<string> args)
        {
            os.traceTracker.stop();
            return false;
        }
        public static bool HideDisplay(OS os, List<string> args)
        {
            os.display.visible = false;
            return false;
        }
        public static bool HideNetMap(OS os, List<string> args)
        {
            os.netMap.visible = false;
            return false;
        }
        public static bool HideTerminal(OS os, List<string> args)
        {
            os.terminal.visible = false;
            return false;
        }
        public static bool HideRAM(OS os, List<string> args)
        {
            os.ram.visible = false;
            return false;
        }
        public static bool ShowDisplay(OS os, List<string> args)
        {
            os.display.visible = true;
            return false;
        }
        public static bool ShowNetMap(OS os, List<string> args)
        {
            os.netMap.visible = true;
            return false;
        }
        public static bool ShowTerminal(OS os, List<string> args)
        {
            os.terminal.visible = true;
            return false;
        }
        public static bool ShowRAM(OS os, List<string> args)
        {
            os.ram.visible = true;
            return false;
        }
        public static bool GetUniversalAdmin(OS os, List<string> args)
        {
            List<Computer> computerList = os.netMap.nodes;
            string str = os.thisComputer.ip;
            for (int index = 0; index <= computerList.Count; ++index)
            {
                computerList[index].adminIP = os.thisComputer.ip;
            }
            return false;
        }
        public static bool HackComputer(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            int RAMAvailable = os.ramAvaliable;

            return false;
        }
        public static bool ChangeUserDetails(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            string oldUser = args[1];
            string newUser = args[2];
            string newPass = args[3];
            if (args.Count < 3)
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
        public static bool GenerateExampleAcadmicRecord(OS os, List<string> args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FULL NAME HERE\n\n--------------------\nDEGREE HERE\nUNIVERSITY HERE\nGPA HERE";
            folder.files.Add(new FileEntry(File, "FULL NAME HERE"));
            return false;
        }
        public static bool GenerateExampleMedicalRecord(OS os, List<string> args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FIRST NAME HERE\n--------------------\nLAST NAME HERE\n--------------------\nmale OR female\n--------------------\nDATE OF BIRTH HERE TIME OF BIRTH HERE\n--------------------\nMedical Record\nDate of Birth :: DATE OF BIRTH HERE TIME OF BIRTH HERE\nBlood Type :: BLOOD TYPE HERE\nHeight :: HEIGHT HERE IN CM\n Allergies :: ALLERGIES HERE\nActive Prescriptions :: ACTIVE PRESCRIPTSION HERE\nRecorded Visits :: RECORDED VISTS HERE\nNotes :: NOTES HERE";
            folder.files.Add(new FileEntry(File, "LASTNAMEHERE FIRSTNAMEHERE"));
            return false;
        }
        public static bool ExecuteHack(OS os, List<string> args)
        {
            string HackerScript = args[1];
            if (args.Count < 0)
            {
                os.write("Usage: executeHack (HackerScriptLocation)\nHacker script must be in Content/HackerScripts");
                return false;
            }
            HackerScriptExecuter.runScript("HackerScripts/" + HackerScript, (string)null);
            return false;
        }
        public static bool DeleteWhitelistDLL(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            List<int> FolderPath = new List<int>();
            FolderPath.Add(5);
            Folder folder = computer.files.root.searchForFolder("Whitelist");
            for (int index = 0; index < folder.files.Count; ++index)
            {
                if (folder.files[index].name.Equals("authenticator.dll"))
                {
                    folder.files.Remove(folder.files[index]);
                    os.execute("connect " + computer.ip);
                }
            }
            return false;
        }
        public static bool ChangeMusic(OS os, List<string> args)
        {
            string SongInput = args[1];
            string Song = args[1].Replace("/", "\\");
            if (Song == SongInput)
            {
                Song = args[1].Replace("\\", "\\");
            }
            MusicManager.playSongImmediatley(Song);
            return false;
        }
        public static bool CrashComputer(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.crash(os.thisComputer.ip);
            return false;
        }
        public static bool AddProxy(OS os, List<string> args)
        {
            string ProxyTimeInput = args[1];
            float ProxyTime;
            float.TryParse(ProxyTimeInput, out ProxyTime);
            Computer computer = os.connectedComp;
            if (args.Count < 0)
            {
                os.write("Usage: addProxy (Time)");
                return false;
            }
            computer.addProxy(ProxyTime);
            return false;
        }
        public static bool AddFirewall(OS os, List<string> args)
        {
            string Solution = args[1];
            string LevelInput = args[2];
            string AdditionalTimeInput = args[3];
            int Level = Convert.ToInt32(LevelInput);
            float AdditionalTime;
            float.TryParse(AdditionalTimeInput, out AdditionalTime);
            Computer computer = os.connectedComp;
            if (args.Count == 1 && args[1] != null)
            {
                computer.addFirewall(Level);
            } else if (args.Count == 2 && args[1] != null && args[2] != null)
            {
                computer.addFirewall(Level, Solution);
            } else if (args.Count == 3 && args[1] != null && args[2] != null && args[3] != null)
            {
                computer.addFirewall(Level, Solution, AdditionalTime);
            }
            else
            {
                os.write("Usage: addFirewall (Level) [Solution] [AdditionalTime]");
            }
            return false;
        }
        public static bool AddUser(OS os, List<string> args)
        {
            string Username = args[1];
            string Password = args[2];
            string TypeInput = args[3];
            byte Type = Convert.ToByte(TypeInput);
            Computer computer = os.connectedComp;
            if (args.Count < 3)
            {
                os.write("Usage: addUser (Username) (Password) (Type)");
                return false;
            }
            computer.addNewUser(os.thisComputer.ip, Username, Password, Type);
            return false;
        }
        /*public static bool OpenPort(OS os, List<string> args)
        {
            int port = Convert.ToInt32(args[1]);
            string ip = os.thisComputer.ip;
            Computer computer = os.connectedComp;
            Console.WriteLine(computer.ports);
            if (port == 22)
            {
                computer.openPort(22, ip);
            }
            else if (port == 21)
            {
                computer.openPort(21, ip);
            }
            else if (port == 25)
            {
                computer.openPort(25, ip);
            }
            else if (port == 80)
            {
                computer.openPort(80, ip);
            }
            else if (port == 1433)
            {
                computer.openPort(1433, ip);
            }
            else if (port == 3724)
            {
                computer.openPort(3724, ip);
            }
            else if (port == 104)
            {
                computer.openPort(104, ip);
            }
            else if (port == 3659)
            {
                computer.openPort(3659, ip);
            }
            else if (port == 192)
            {
                computer.openPort(192, ip);
            }
            else if (port == 6881)
            {
                computer.openPort(6881, ip);
            }
            else if (port == 443)
            {
                computer.openPort(443, ip);
            }
            else if (port == 9418)
            {
                computer.openPort(9418, ip);
            }
            return false;
        }
        public static bool ClosePort(OS os, List<string> args)
        {
            int port = Convert.ToInt32(args[1]);
            string ip = os.thisComputer.ip;
            Computer computer = os.connectedComp;
            Console.WriteLine(computer.ports);
            if (port == 22)
            {
                computer.closePort(22, ip);
            }
            else if (port == 21)
            {
                computer.closePort(21, ip);
            }
            else if (port == 25)
            {
                computer.closePort(25, ip);
            }
            else if (port == 80)
            {
                computer.closePort(80, ip);
            }
            else if (port == 1433)
            {
                computer.closePort(1433, ip);
            }
            else if (port == 3724)
            {
                computer.closePort(3724, ip);
            }
            else if (port == 104)
            {
                computer.closePort(104, ip);
            }
            else if (port == 3659)
            {
                computer.closePort(3659, ip);
            }
            else if (port == 192)
            {
                computer.closePort(192, ip);
            }
            else if (port == 6881)
            {
                computer.closePort(6881, ip);
            }
            else if (port == 443)
            {
                computer.closePort(443, ip);
            }
            else if (port == 9418)
            {
                computer.closePort(9418, ip);
            }
            return false;
        } */
        public static bool OpenPort(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            if (args.Count < 1)
            {
                os.write("Usage: openPort (PortToopen)");
                return false;
            }
            int port = Convert.ToInt32(args[1]);
            string ip = os.thisComputer.ip;
            computer.openPort(port, ip);
            return false;
        }
        public static bool ClosePort(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            if (args.Count < 1)
            {
                os.write("Usage: closePort (PortToClose)\n");
                return false;
            }
            int port = Convert.ToInt32(args[1]);
            string ip = os.thisComputer.ip;
            computer.closePort(port, ip);
            return false;
        }
        public static bool RemoveProxy(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.hasProxy = false;
            return false;
        }
        public static bool RemoveFirewall(OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.firewall = null;
            return false;
        }
        public static bool AddComputer(OS os, List<string> args)
        {
            if (args.Count < 5)
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
            os.netMap.nodes.Add(computer); // If you are adding a new computer, you must add the object to nodes list
            return false;
        }
        public static bool DefineComputer(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            string Action = args[2];
            string ActionArgs = args[3];

            if (Action == "tracetime")
            {
                float TraceTime;
                float.TryParse(ActionArgs, out TraceTime);
                computer.traceTime = TraceTime;
            } else if (Action == "isadminsuper") {
                bool TrueOrFalse;
                bool.TryParse(ActionArgs, out TrueOrFalse);
                computer.admin.IsSuper = TrueOrFalse ? true : false;
            }
            return false;
        }
        public static bool PlaySFX(OS os, List<string> args)
        {
            SoundEffect sound = os.content.Load<SoundEffect>(args[1]);
            sound.Play();
            return false;
        }
        public static bool GetMoreRAM(OS os, List<string> args)
        {
            os.totalRam = 2048;
            return false;
        }
        public static bool SetFaction(OS os, List<string> args)
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
        public static bool TracedBehind250Proxies(OS os, List<string> args)
        {
            os.traceTracker.start(500f);
            return false;
        }
        public static bool OxygencraftStorageFaciltyCache(OS os, List<string> args) // Don't tell anyone about this command, keep it a secret
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
                    if (os.username == "oxygencraft" || os.username == "oxygencraft2" || os.username == "oxygencraft3" || os.username == "oxygencraft4")
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
            bin.files.Add(new FileEntry(PortExploits.ValidPacemakerFirmware, Utils.GetNonRepeatingFilename("PacemakerWorking", ".dll", bin)));
            bin.files.Add(new FileEntry(PortExploits.ValidAircraftOperatingDLL, Utils.GetNonRepeatingFilename("747FlightSystem", ".dll", bin)));
            os.netMap.nodes.Add(computer);
            return false;
        }
        public static bool DisableEmailIcon(OS os, List<string> args)
        {
            os.DisableEmailIcon = true;
            return false;
        }
        public static bool EnableEmailIcon(OS os, List<string> args)
        {
            os.DisableEmailIcon = false;
            return false;
        }
        public static bool NodeRestore(OS os, List<string> args)
        {
            DLC1SessionUpgrader.ReDsicoverAllVisibleNodesInOSCache(os);
            return false;
        }
        public static bool AddRestoreCircle(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            SFX.addCircle(computer.getScreenSpacePosition(), Utils.AddativeWhite * 0.4f, 70f);
            return false;
        }
        public static bool WhitelistBypass(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Folder folder = computer.files.root.searchForFolder("Whitelist");
            for (int index = 0; index < folder.files.Count; ++index)
            {
                if (folder.files[index].name.Equals("list.txt") || folder.files[index].name.Equals("source.txt"))
                {
                    folder.files.Remove(folder.files[index]);
                    folder.files.Add(new FileEntry(os.thisComputer.ip, "list.txt"));
                    os.execute("connect " + computer.ip);
                }
            }
            return false;
        }
        public static bool SetTheme(OS os, List<string> args)
        {
            OSTheme Theme;
            string ThemeInput = args[1];
            if (ThemeInput == "TerminalOnly")
            {
                Theme = OSTheme.TerminalOnlyBlack;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Blue") {
                Theme = OSTheme.HacknetBlue;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Teal")
            {
                Theme = OSTheme.HacknetTeal;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Yellow")
            {
                Theme = OSTheme.HacknetYellow;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Green")
            {
                Theme = OSTheme.HackerGreen;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "White")
            {
                Theme = OSTheme.HacknetWhite;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Purple")
            {
                Theme = OSTheme.HacknetPurple;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Mint")
            {
                Theme = OSTheme.HacknetMint;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Colamaeleon")
            {
                Theme = OSTheme.Colamaeleon;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "GreenCompact")
            {
                Theme = OSTheme.GreenCompact;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Riptide")
            {
                Theme = OSTheme.Riptide;
                ThemeManager.switchTheme(os, Theme);
            } else if (ThemeInput == "Riptide2")
            {
                Theme = OSTheme.Riptide2;
                ThemeManager.switchTheme(os, Theme);
            } else
            {
                os.write("Usage: setTheme: (Theme)\nValid Options: TerminalOnly,Blue,Teal,Yellow,Green,White,Purple,Mint,Colamaeleon,GreenCompact,Riptide,Riptide2");
            }
            return false;
        }
        public static bool SetCustomTheme(OS os, List<string> args)
        {
            ThemeManager.switchTheme(os, args[1]);
            return false;
        }
        public static bool LinkComputer(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Computer computer2 = Programs.getComputer(os, args[2]);
            try
            {
                string IsComputer = computer2.adminPass;
            }
            catch
            {
                os.write("Usage: linkComputer: (SourceIP) (RemoteIP)");
            }
            computer.links.Add(os.netMap.nodes.IndexOf(computer2));
            return false;
        }
        public static bool UnlinkComputer(OS os, List<string> args)
        {
            Computer computer1 = Programs.getComputer(os, args[1]);
            Computer computer2 = Programs.getComputer(os, args[2]);
            computer1.links.Remove(os.netMap.nodes.IndexOf(computer2));
            return false;
        }
        public static bool LoseAllNodes(OS os, List<string> args)
        {
            for (int index = 1; index < os.netMap.nodes.Count; ++index)
            {
                Computer computer = os.netMap.nodes[index];
                XNA.Vector2 Pos = computer.getScreenSpacePosition();
                List<TraceKillExe.PointImpactEffect> ImpactEffects = new List<TraceKillExe.PointImpactEffect>();
                ImpactEffects.Add(new TraceKillExe.PointImpactEffect()
                {
                    location = Pos,
                    scaleModifier = (float)(3.0 + (computer.securityLevel > 2 ? 1.0 : 0.0)),
                    cne = new ConnectedNodeEffect(os, true),
                    timeEnabled = 0.0f,
                    HasHighlightCircle = true
                });
                os.netMap.visibleNodes.Remove(index);
            }
            return false;
        }
        public static bool LoseNode(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            int CompToRemove = os.netMap.nodes.IndexOf(computer);
            XNA.Vector2 Pos = computer.getScreenSpacePosition();
            List<TraceKillExe.PointImpactEffect> ImpactEffects = new List<TraceKillExe.PointImpactEffect>();
            ImpactEffects.Add(new TraceKillExe.PointImpactEffect()
            {
                location = Pos,
                scaleModifier = (float)(3.0 + (computer.securityLevel > 2 ? 1.0 : 0.0)),
                cne = new ConnectedNodeEffect(os, true),
                timeEnabled = 0.0f,
                HasHighlightCircle = true
            });
            os.netMap.visibleNodes.Remove(CompToRemove);
            return false;
        }
        public static bool RevealNode(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            int CompToReveal = os.netMap.nodes.IndexOf(computer);
            os.netMap.visibleNodes.Add(CompToReveal);
            return false;
        }
        public static bool RemoveComputer(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            int CompToRemove = os.netMap.nodes.IndexOf(computer);
            XNA.Vector2 Pos = computer.getScreenSpacePosition();
            List<TraceKillExe.PointImpactEffect> ImpactEffects = new List<TraceKillExe.PointImpactEffect>();
            ImpactEffects.Add(new TraceKillExe.PointImpactEffect()
            {
                location = Pos,
                scaleModifier = (float)(3.0 + (computer.securityLevel > 2 ? 1.0 : 0.0)),
                cne = new ConnectedNodeEffect(os, true),
                timeEnabled = 0.0f,
                HasHighlightCircle = true
            });
            os.netMap.visibleNodes.Remove(CompToRemove);
            os.netMap.nodes.Remove(computer);
            return false;
        }
        public static bool ResetIP(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.ip = NetworkMap.generateRandomIP();
            return false;
        }
        public static bool ResetPlayerCompIP(OS os, List<string> args)
        {
            os.thisComputerIPReset();
            return false;
        }
        public static bool SetIP(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.ip = args[2];
            return false;
        }
        public static bool ShowFlags(OS os, List<string> args)
        {
            os.write(os.Flags.GetSaveString());
            return false;
        }
        public static bool AddFlag(OS os, List<string> args)
        {
            os.Flags.AddFlag(args[1]);
            return false;
        }
        public static bool RemoveFlag(OS os, List<string> args)
        {
            os.Flags.RemoveFlag(args[1]);
            return false;
        }
        public static bool AuthenticateToIRC(OS os, List<string> args)
        {
            os.Flags.RemoveFlag("DLC_Player_IRC_Authenticated");
            return false;
        }
        public static bool AddAgentToIRC(OS os, List<string> args)
        {
            Computer computerobject = Programs.getComputer(os, args[1]);
            if (args.Count < 6)
            {
                os.write("Usage: addAgentToIRC (NameORIDORIP) (AgentName) (AgentPassword) (AgentColourRed) (AgentColourBlue) (AgentColourGreen)");
                return false;
            }
            try
            {
                string IsComp = computerobject.adminIP;
                int IsNum = Convert.ToInt32(args[4]);
                int IsNum2 = Convert.ToInt32(args[5]);
                int IsNum3 = Convert.ToInt32(args[6]);
                if (args[2] == null || args[3] == null || args[4] == null || args[5] == null || args[6] == null)
                {
                    int ThrowError = Convert.ToInt32("a");
                }
            }
            catch
            {
                os.write("Usage: addAgentToIRC (NameORIDORIP) (AgentName) (AgentPassword) (AgentColourRed) (AgentColourBlue) (AgentColourGreen)");
                return false;
            }
            string computer = computerobject.idName;
            DLCHubServer IRC = Programs.getComputer(os, computer).getDaemon(typeof(DLCHubServer)) as DLCHubServer;
            XNA.Color colour = new XNA.Color(Convert.ToInt32(args[4]), Convert.ToInt32(args[5]), Convert.ToInt32(args[6]));
            IRC.AddAgent(args[2], args[3], colour);
            return false;
        }
        public static bool SetCompPorts(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            ComputerLoader.loadPortsIntoComputer(args[2], computer);
            return false;
        }
        /*public static bool RemovePortFromComp(OS os, List<string> args) Not used, probably should be removed
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.ports.Remove(Convert.ToInt32(args[2]));
            return false;
        }
        public static bool AddCustomPortToComp(OS os, List<string> args) Untested, test and release when pathfinder 3.0 comes out
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Pathfinder.Port.PortType port = new Pathfinder.Port.PortType(args[2], Convert.ToUInt32(args[3]));
            port.AssignTo(computer, false);
            Pathfinder.Port.Handler.AddPort(port.PortId, port);
            return false;
        }
        public static bool RemoveCustomPortFromComp(OS os, List<string> args) IDK how to do this.......
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Pathfinder.Computer.Extensions.GetModdedPortList(computer);
            return false;
        } */
        public static bool AddSongChangerDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            SongChangerDaemon daemon = new SongChangerDaemon(computer, os);
            computer.daemons.Add(daemon);
            return false;
        }
        public static bool AddRicerConnectDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            CustomConnectDisplayDaemon daemon = new CustomConnectDisplayDaemon(computer, os);
            computer.daemons.Add(daemon);
            return false;
        }
        public static bool AddDLCCreditsDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            DLCCreditsDaemon daemon = new DLCCreditsDaemon(computer, os);
            computer.daemons.Add(daemon);
            return false;
        }
        public static bool AddIRCDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            IRCDaemon daemon = new IRCDaemon(computer, os, args[2]);
            computer.daemons.Add(daemon);
            return false;
        }
        public static bool AddISPDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            ISPDaemon daemon = new ISPDaemon(computer, os);
            computer.daemons.Add(daemon);
            return false;
        }
        public static bool Quit(OS os, List<string> args)
        {
            Game1.getSingleton().Exit();
            return false;
        }
        public static bool DeleteLogs(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            //Console.WriteLine("Computer object obtained");
            Folder folder = computer.files.root.searchForFolder("log");
            //Console.WriteLine("Folder object obtained");
            folder.files.Clear();
            //Console.WriteLine("Deleted all logs");
            return false;
        }
        public static bool ForkbombProof(OS os, List<string> args)
        {
            os.totalRam = 1000000000;
            return false;
        }
        public static bool ChangeCompIcon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.icon = args[2];
            return false;
        }
        public static bool RemoveSongChangerDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Daemon daemon = computer.getDaemon(typeof(SongChangerDaemon));
            computer.daemons.Remove(daemon);
            return false;
        }
        public static bool RemoveRicerConnectDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Daemon daemon = computer.getDaemon(typeof(CustomConnectDisplayDaemon));
            computer.daemons.Remove(daemon);
            return false;
        }
        public static bool RemoveDLCCreditsDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Daemon daemon = computer.getDaemon(typeof(DLCCreditsDaemon));
            computer.daemons.Remove(daemon);
            return false;
        }
        public static bool RemoveIRCDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Daemon daemon = computer.getDaemon(typeof(IRCDaemon));
            computer.daemons.Remove(daemon);
            return false;
        }
        public static bool RemoveISPDaemon(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Daemon daemon = computer.getDaemon(typeof(ISPDaemon));
            computer.daemons.Remove(daemon);
            return false;
        }
        public static bool ForkbombVirus(OS os, List<string> args) // Bugged
        {
            for (int index = 1; index < os.netMap.nodes.Count; ++index)
                os.netMap.nodes[index].crash(os.thisComputer.ip);



            return false;
        }
        public static bool InstallInviolabilty(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.portsNeededForCrack = 9999999;
            return false;
        }
        public static bool RemoveAllDaemons(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.daemons.Clear();
            return false;
        }
        public static bool ShowIPNamesAndID(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            os.write("ID: " + computer.idName);
            os.write("Name: " + computer.name);
            os.write("IP: " + computer.ip);
            return false;
        }
        public static bool SummonDebugModDaemonComp(OS os, List<string> args)
        {
            Computer computer = new Computer("DebugMod Comp", NetworkMap.generateRandomIP(), os.netMap.getRandomPosition(), 50000, 2, os);
            computer.idName = "debugMod";
            os.netMap.nodes.Add(computer);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Daemon daemon = Pathfinder.Daemon.Instance.CreateInstance("DebugModDaemon", computer, dict);
            //computer.daemons.Add(daemon);
            os.execute("connect " + computer.ip);
            return false;
        }
        public static bool ChangeAdmin(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            if (args[2] == "basic")
            {
                computer.admin = new BasicAdministrator();
            } else if (args[2] == "fastbasic")
            {
                computer.admin = new FastBasicAdministrator();
            } else if (args[2] == "fastprogress")
            {
                computer.admin = new FastProgressOnlyAdministrator();
            } else if (args[2] == "alwaysactive")
            {
                computer.admin = new AlwaysActiveAdmin();
            } else if (args[2] == "none")
            {
                computer.admin = null;
            }
            else
            {
                os.write("Usage: changeAdmin (IDORIPORName) (Admin)");
                os.write("Valid options: basic,fastbasic,fastprogress,alwaysactive,none");
            }
            return false;
        }
        public static bool ViewAdmin(OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            if (computer.admin == new BasicAdministrator())
            {
                os.write("Basic Admin");
            } else if (computer.admin == new FastBasicAdministrator())
            {
                os.write("Fast Basic Admin");
            } else if (computer.admin == new FastProgressOnlyAdministrator())
            {
                os.write("Fast Progress Admin");
            } else if (computer.admin == new AlwaysActiveAdmin())
            {
                os.write("Always Active Admin");
            }
            else
            {
                os.write("You may of entered the computer incorrectly or there is no admin for the computer.");
                os.write("Usage: viewAdmin (IPORIDORName)");
            }
            return false;
        }
        public static bool ExportGraphic(OS os, List<string> args)
        {
            string PathString2 = "C:/Users/groun/OneDrive/Documents/Hacknet Graphics and Sounds/";
            string FileName = args[1] + ".png";
            string PathString = System.IO.Path.Combine(PathString2, FileName);
            try
            {
                XNA.Graphics.Texture2D graphic = os.content.Load<XNA.Graphics.Texture2D>(args[1]);
                System.IO.Stream stream = System.IO.File.Create(PathString);
                graphic.SaveAsPng(stream, graphic.Width, graphic.Height);
            }
            catch (Exception ex)
            {
                os.write("Graphics export failed");
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool ReplayPlaneMission(OS os, List<string> args)
        {
            string IRCLogData = @"#11:34//D3f4ult//Man, the spindown time on TorrentStreamInjector is so damn annoying.
#11:35//D3f4ult//The port is saturated just fine after a few seconds, but it hangs around forever. Makes me want to decompile it, but I bet it|##SIQ##|s a mess in there.
#11:35//Coel//That|##SIQ##|s not really a problem though, is it?
#11:35//D3f4ult//???
#11:35//D3f4ult//It kinda slows me down, and is annoying, how is that not a problem?
#11:35//Coel//ps -|##RAB##| kill the process when it|##SIQ##|s done what you want, what|##SIQ##|s the problem?
#11:35//D3f4ult//...
#11:35//D3f4ult//I actually never even thought of that. Don|##SIQ##|t mind me.
#11:34//Coel//Haha
#11:34//Channel//!ANNOUNCEMENT!
#11:34//Channel//User |##QOT##|oxygencraft|##QOT##| added to whitelist.
#11:34//Kaguya//@channel, I|##SIQ##|d like to welcome oxygencraft to the fold.
#11:35//Kaguya//@oxygencraft - congratulations on beating the trials.
The others are out on assignments right now - there should be time for you to catch up if you want in on this round.
#11:35//Kaguya//You|##SIQ##|re on the team now, so the final contract belongs to you.
#11:35//Kaguya//Contracts are on a first come first served system here - I mostly take care of admin, recon and all that - making sure everyone has stuff to do that builds towards our goals, and everyone has all the tools and info they need to do their work.
#11:35//Kaguya//@Coel, @D3f4ult - introduce yourselves when you|##SIQ##|ve got a sec.
#11:35//Kaguya//In the meantime @oxygencraft, check out the server and take a look at that last job.
#11:35//Kaguya//Welcome to the team.
#11:35//D3f4ult//Hey @oxygencraft, good to have you with us.
#11:35//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|The Ricer|##QOT##|
#11:36//Coel//Welcome to the team @oxygencraft!
#11:39//D3f4ult//Decryption setup complete!
#11:39//D3f4ult//Unfortunately it|##SIQ##|s not that portable yet - I|##SIQ##|ll get to work building a new shareable .exe for it
#11:39//D3f4ult//But for now just run stuff past me and I|##SIQ##|ll take a look.
#11:38//Coel//I wonder how long it|##SIQ##|ll take until you|##SIQ##|ve spent more time decrypting stuff for us than it|##SIQ##|d have taken you to set this up properly.
#11:38//D3f4ult//Ok, yes I am ashamed of myself, but no I|##SIQ##|m not answering that. It works, it|##SIQ##|ll be better when I|##SIQ##|ve got time. I|##SIQ##|m sure we can all live with that for now -_-
#11:38//Coel//We have to, don|##SIQ##|t we?
#11:38//D3f4ult//-_-
#11:39//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|The Ricer|##QOT##|
#11:39//D3f4ult//Alright, I|##SIQ##|m looking at this SSL stuff, getting it decrypted and packed into something convenient.
#11:39//D3f4ult//It actually looks like most of this is already done for me here - i|##SIQ##|ve seen this trojan style before..
#11:39//D3f4ult//It|##SIQ##|s a bit untested, but this build is usable if you want to rush into it. I|##SIQ##|ve uploaded it to the drop server (/bin).
#11:39//D3f4ult//!ATTACHMENT:link#%#Bibliotheque DropServer#%#69.58.186.118
#11:39//D3f4ult//!ATTACHMENT:account#%#Bibliotheque DropServer#%#69.58.186.118#%#admin#%#ka2gs69
#11:39//D3f4ult//Ok, so basically this program tunnels through an already opened port to hijack the SSL one.
#11:39//D3f4ult//So you|##SIQ##|ll need to provide it not only the SSL port number, but also a flag to say which port you want to tunnel through, and *THAT* port|##SIQ##|s number.
#11:39//D3f4ult//Current flags are -s, -w and -f, for ssh, http and ftp respectively.
#11:39//D3f4ult//Use it like this
#11:40//D3f4ult//SSLTrojan |##LSB##|SSL NUMBER|##RSB##| |##LSB##|FLAG|##RSB##| |##LSB##|TUNNEL PORT NUMBER|##RSB##|
#11:40//D3f4ult//Summary guide:
#11:40//D3f4ult//!ATTACHMENT:note#%#SSL Trojan Usage#%#SSLTrojan |##LSB##|1|##RSB##| |##LSB##|2|##RSB##| |##LSB##|3|##RSB##|
1 = Port number of SSL Port
2 =
|##QOT##|-s|##QOT##| for SSH Tunnel
|##QOT##|-f|##QOT##| for FTP Tunnel
|##QOT##|-w|##QOT##| for HTTP Tunnel
3 = Port number of the other service you are tunneling through.
I.E: |##QOT##|SSLTrojan 443 -w 80|##QOT##|
#11:40//D3f4ult//Remember - SSLTrojan goes *THROUGH* another port, so that port has to be open first.
#11:40//D3f4ult//@channel - New toys! Read above.
#11:40//Kaguya//Great rundown @D3f4ult - thanks.
#11:40//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|DDOSer on some critical servers|##QOT##|
#11:45//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|DDOSer on some critical servers|##QOT##|
#11:45//Kaguya//@channel ---- UPDATE --- 
#11:45//Kaguya//Excellent work on your recent tasks - It|##SIQ##|s time for a team project.
#11:45//Kaguya//I|##SIQ##|m going to have all of you looking at the same network. It|##SIQ##|s not a race or anything, but this is a complex job that I think will benefit from the group|##SIQ##|s collective attention.
#11:46//Kaguya//Missions are up, good luck all!
#11:46//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|The Hermetic Alchemists - oxygencraft|##QOT##|
#11:46//Coel//Looks fun
#11:46//D3f4ult//I|##SIQ##|m loving their tree logo thing
#11:46//Coel//Yeah, for such a super secret organization, they sure put a lot of time into making their servers look fancy
#11:51//D3f4ult//@channel I found an encrypted file on |##QOT##|Solve|##QOT##| that you two might be interested in.
#11:51//D3f4ult//Decrypted, it seems to say that the password to |##QOT##|Rebis|##QOT##| is |##QOT##|clarity|##QOT##|. Doesn|##SIQ##|t seem to be working for me for the admin account though?
#11:51//Coel//Thanks for the heads up @D3f4ult
#11:52//Coel//Are you all set for an eOS scanner btw?
#11:52//D3f4ult//Yeah, I|##SIQ##|m all good.. Why?
#11:52//Coel//You|##SIQ##|ll see :P
#11:57//Coel//@channel - can anyone remind me what the default eOS admin pass is?
#11:57//Kaguya//It|##SIQ##|s |##QOT##|alpine|##QOT##| by default.
#11:57//Coel//Thanks
#11:59//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|The Hermetic Alchemists - oxygencraft|##QOT##|
#12:00//Coel//!
#12:00//Coel//@oxygencraft Nice, didn|##SIQ##|t think you|##SIQ##|d beat me to it.
#12:00//D3f4ult//Honestly, I|##SIQ##|m just going to go right ahead and claim full credit with that clutch decryption effort
#12:00//Coel//@D3f4ult zero doubts in my mind that that|##SIQ##|s how everyone sees it
#12:00//Kaguya//Solid work by everyone, great job all
#12:00//Coel//Not trying to beat us to the finish line though @D3f4ult ?
#12:00//D3f4ult//Nah, that|##SIQ##|d go against my motto
#12:00//D3f4ult//|##QOT##|Aim low, and miss|##QOT##|
#12:00//Coel//hahaha
#12:00//D3f4ult//Besides, *someone* left some logs on Coagula, and apparently *someone else* had to make sure it got cleaned up :P
#12:00//Coel//._.
#12:00//Coel//I am a raft floating on an ocean of pure shame
#12:00//D3f4ult//Fast raft tho :P
#12:01//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|Memory Forensics (2/3)|##QOT##|
#12:03//D3f4ult//Whoa
#12:03//D3f4ult//@channel , have you tried SignalScramble out yet? From the Alchemists servers?
#12:03//D3f4ult//This thing is crazy
#12:03//Coel//Yeah. It|##SIQ##|s very impressive. Where|##SIQ##|d you hear about this @Kaguya ?
#12:03//Kaguya//Trade secret.
#12:03//Kaguya//Glad you like though. I suspect it|##SIQ##|ll be very useful for some future tasks.
#12:04//D3f4ult//niiiiiice
#12:11//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|Memory Forensics (2/3)|##QOT##|
#12:12//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|Striker|##SIQ##|s Archives|##QOT##|
#12:15//D3f4ult//Job complete @Coel - sorry you had to deal with that. I|##SIQ##|ve done my best to take care of it cleanly.
#12:15//Coel//Thanks. It|##SIQ##|s something I would have liked to be able to take care of myself but... yeah.
#12:15//D3f4ult//Totally understand, don|##SIQ##|t worry about it. Your job go well?
#12:15//Kaguya//Thanks for dealing with this one @D3f4ult
#12:15//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|Striker|##SIQ##|s Archives|##QOT##|
#12:15//D3f4ult//You got it boss.
#12:15//Coel//Yeah - just going over all the Hermetic Alchemist servers again and making sure we|##SIQ##|re all cleaned up. Should be as safe as we|##SIQ##|re going to be from that now.
#12:15//Coel//Someone left some disconnect logs all over the place, but don|##SIQ##|t worry, I didn|##SIQ##|t go snooping.
#12:15//D3f4ult//Ugh, yeah. @Kaguya - any chance you could find us something to deal with DC log stuff?
#12:15//Coel//You mean, other than forkbombing?
#12:16//D3f4ult//It|##SIQ##|s so crude :|##BS##|
#12:16//Coel//mmm, wont argue with that.
#12:16//Kaguya//I|##SIQ##|ll see what I can do. No promises on that one though.
#12:16//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|It Follows|##QOT##|
#12:21//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|It Follows|##QOT##|
#12:22//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|Neopals - oxygencraft|##QOT##|
#12:23//D3f4ult//You and me for this one oxygencraft !
#12:23//D3f4ult//Race you to it :P
#12:23//Coel//Your job looks way more fun than mine ._.
#12:23//D3f4ult//Yeah, good luck on your mysterious secret business too Coel -_-
#12:24//D3f4ult//Ugh, everytime I tab-complete for my FTP breaker it completes to my old one
#12:24//D3f4ult//So frustrating.
#12:24//Coel//You know you could just...
#12:25//Coel//delete the old one...
#12:25//Coel//right?
#12:25//Coel//rename it with mv even?
#12:25//D3f4ult//uh
#12:25//D3f4ult//remember the thing earlier? With the raft?
#12:25//D3f4ult//Something about ocean of shame?
#12:25//Coel//Yeah?
#12:25//D3f4ult//same
#12:25//Coel//hahaha
#12:26//Kaguya//Some new information for once you|##SIQ##|re into the mainframe @channel
#12:26//Kaguya//Looks like their database is a little less fancy than I thought - they store all user records in a one-per-file structure, which makes our life a lot easier.
#12:26//Kaguya//Once you have the right user file, you should be able to use the standard replace command to swap out the values for what we want.
#12:48//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|Neopals - oxygencraft|##QOT##|
#12:48//D3f4ult//Oh damn - nice @oxygencraft . I was messing about on the Auth Server for too long.
#12:48//D3f4ult//@Coel - how|##SIQ##|s your thing going? Still super secret?
#12:48//Coel//Yep. Almost done though - triple checking for logs and such this time. Not really the sort of thing where I can afford to make mistakes.
#12:48//D3f4ult//Let us know if you need a hand... Kinda feeling in the dark here.
#12:48//Coel//Will do.
#12:49//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|Expo Grave|##QOT##|
#12:57//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|Expo Grave|##QOT##|
#12:57//Kaguya//@channel Excellent work all. Everyone|##SIQ##|s marked their tasks as complete, so lets move on. 
#12:58//Kaguya//This next network is a big one. You|##SIQ##|re all on this one together. Be thorough, be patient, look carefully, and take notes.
#12:58//Kaguya//Remember - you|##SIQ##|re here because you|##SIQ##|re the best.
#12:58//Kaguya//Good luck everyone.
#12:58//Coel//Uhm, any particular reason that this is our next target @Kaguya ?
#12:58//Kaguya//DM|##SIQ##|s Coel - this regards tracking Nisei MK III.
#12:58//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|Take Flight - oxygencraft|##QOT##|
#12:58//Kaguya//@channel Oh, and before I forget - I|##SIQ##|ve added a new program I picked up for you all to the drop server.
#12:59//D3f4ult//Awesome! I|##SIQ##|ve been looking for a new organizer like this. Thanks @Kaguya :D
#13:01//D3f4ult//Ugh, @channel everyone else running into the brick wall of this whitelist server?
#13:01//Coel//Yeah - I think I|##SIQ##|ve got an idea, though. If you can bring it down for a minute or two I|##SIQ##|ll take care of it.
#13:01//D3f4ult//Huh?.
#13:01//D3f4ult//I mean, sure, I can probably sort something out, but, no idea what you|##SIQ##|re thinking :|##BS##|
#13:02//Coel//Trade secret ;). You ready? Countdown me
#13:02//D3f4ult//Sure, hold on...
#13:02//D3f4ult//5
#13:02//D3f4ult//4
#13:02//D3f4ult//3
#13:02//D3f4ult//2
#13:02//D3f4ult//1
#13:02//D3f4ult//Done, gogogogo
#13:02//Coel//Almost got it...
#13:02//Coel//Annnnd done! We|##SIQ##|re good to go. Check it for me D3f4ult ?
#13:02//D3f4ult//Holy shit, how?
#13:03//Coel//;)
#13:03//Coel//Oh yeah, @oxygencraft - the whitelist server is down!
#13:03//Coel//You should be able to connect to the Bookings Mainframe now
#13:13//Channel//CONTRACT COMPLETE: @oxygencraft completed contract |##QOT##|Take Flight - oxygencraft|##QOT##|
#13:13//Channel//Additional details provided:
#13:13//Channel//|##LSB##|NU2N3|##RSB##|
#13:13//Coel//Nice! I|##SIQ##|ll test it now.
#13:13//Kaguya//Thanks Coel. My authenticator script approved it though, good from my end.
#13:13//Kaguya//There are a few time sensitive things to get done here.
#13:13//Kaguya//@Coel - the information you needed has come in, and it looks good. One last strike on your end should do it. You|##SIQ##|re up for that.
#13:14//Coel//Roger that. Also, the account looks good too oxygencraft , nice work.
#13:14//Kaguya//@oxygencraft - You got to the pacific server first, so I|##SIQ##|m going to have you following that up. You|##SIQ##|re installing our backup plan.
#13:14//Kaguya//@D3f4ult - You|##SIQ##|re with me sorting out some connection protocols - should be your specialty.
#13:14//Kaguya//Good luck everyone.
#13:14//Channel//CONTRACT CLAIMED: @oxygencraft claimed contract |##QOT##|oxygencraft - Take_Flight Cont.|##QOT##|
#13:14//D3f4ult//I|##SIQ##|m on it. Go get em @Coel , @oxygencraft";
            if (!os.Flags.HasFlag("") && args[1] == null)
            {
                os.write("You have not completed the dlc yet, if you want spoilers and wish to continue, type this command:");
                os.write("replayPlaneMission y");
                return false;
            }
            os.execute("loseAllNodes");
            return false;
        }
        public static bool TellPeopleYouAreGonnaHackThemOnline(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(200);
            return false;
        }
        public static bool MyFatherIsCCC(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(5);
            return false;
        }
        public static bool CantTouchThis(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(99999);
            return false;
        }
    }
}
