﻿using Hacknet;
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

        public static bool OpenAllPorts(Hacknet.OS os, List<string> args)
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

        public static bool BypassProxy(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.proxyActive = false;
            return false;
        }

        public static bool SolveFirewall(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.firewall.solved = true;
            return false;
        }

        public static bool GetAdmin(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.thisComputer.ip;
            return false;
        }

        public static bool DeathSeq(Hacknet.OS os, List<string> args)
        {
            os.TraceDangerSequence.BeginTraceDangerSequence();
            return false;
        }
        public static bool CancelDeathSeq(Hacknet.OS os, List<string> args)
        {
            os.TraceDangerSequence.CancelTraceDangerSequence();
            return false;
        }

        public static bool SetHomeNodeServer(Hacknet.OS os, List<string> args)
        {
            os.homeNodeID = os.connectedComp.idName;
            return false;
        }
        public static bool SetHomeAssetServer(Hacknet.OS os, List<string> args)
        {
            os.homeAssetServerID = os.connectedComp.idName;
            return false;
        }
        public static bool Debug(Hacknet.OS os, List<string> args)
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
        public static bool LoseAdmin(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.adminIP = os.connectedComp.ip;
            return false;
        }
        public static bool RevealAll(Hacknet.OS os, List<string> args)
        {
            for (int index = 0; index < os.netMap.nodes.Count; ++index)
                os.netMap.visibleNodes.Add(index);


            return false;
        }
        public static bool AddIRCMessage(Hacknet.OS os, List<string> args)
        {
            string computer = args[1];
            string author = args[2];
            string messageInput1 = args[3];
            string messageInput2 = args[4];
            string messageInput3 = args[5];
            string messageInput4 = args[6];
            string messageInput5 = args[7];
            string messageInput6 = args[8];
            string messageInput7 = args[9];
            string messageInput8 = args[10];
            string messageInput9 = args[11];
            string messageInput10 = args[12];
            string messageInput11 = args[13];
            string messageInput12 = args[14];
            string messageInput13 = args[15];
            string messageInput14 = args[16];
            string message = messageInput1 + messageInput2 + messageInput3 + messageInput4 + messageInput5 + messageInput6 + messageInput7 + messageInput8 + messageInput9 + messageInput10 + messageInput11 + messageInput12 + messageInput13 + messageInput14;

            if (args.Count < 3)
            {
                os.write("Usage: addIRCMessage (ComputerID) (Author) (Message)");
                return false;
            }

            DLCHubServer IRC = Programs.getComputer(os, computer).getDaemon(typeof(DLCHubServer)) as DLCHubServer;
            IRC.IRCSystem.AddLog(author, message, null);
            return false;
        }
        public static bool StrikerAttack(Hacknet.OS os, List<string> args)
        {
            HackerScriptExecuter.runScript("DLC/ActionScripts/Hackers/SystemHack.txt", os, (string)null);
            return false;
        }
        public static bool ThemeAttack(Hacknet.OS os, List<string> args)
        {
            HackerScriptExecuter.runScript("HackerScripts/ThemeHack.txt", os, (string)null);
            return false;
        }
        public static bool CallThePoliceSoTheyCanTraceYou(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(100f);
            return false;
        }
        public static bool ReportYourselfToFBI(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(20f);
            return false;
        }
        public static bool TraceYourselfIn(Hacknet.OS os, List<string> args)
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
        public static bool WarningFlash(Hacknet.OS os, List<string> args)
        {
            os.warningFlash();
            return false;
        }
        public static bool StopTrace(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.stop();
            return false;
        }
        public static bool HideDisplay(Hacknet.OS os, List<string> args)
        {
            os.display.visible = false;
            return false;
        }
        public static bool HideNetMap(Hacknet.OS os, List<string> args)
        {
            os.netMap.visible = false;
            return false;
        }
        public static bool HideTerminal(Hacknet.OS os, List<string> args)
        {
            os.terminal.visible = false;
            return false;
        }
        public static bool HideRAM(Hacknet.OS os, List<string> args)
        {
            os.ram.visible = false;
            return false;
        }
        public static bool ShowDisplay(Hacknet.OS os, List<string> args)
        {
            os.display.visible = true;
            return false;
        }
        public static bool ShowNetMap(Hacknet.OS os, List<string> args)
        {
            os.netMap.visible = true;
            return false;
        }
        public static bool ShowTerminal(Hacknet.OS os, List<string> args)
        {
            os.terminal.visible = true;
            return false;
        }
        public static bool ShowRAM(Hacknet.OS os, List<string> args)
        {
            os.ram.visible = true;
            return false;
        }
        public static bool GetUniversalAdmin(Hacknet.OS os, List<string> args)
        {
            List<Computer> computerList = os.netMap.nodes;
            string str = os.thisComputer.ip;
            for (int index = 0; index <= computerList.Count; ++index)
            {
                computerList[index].adminIP = os.thisComputer.ip;
            }
            return false;
        }
        public static bool HackComputer(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            int RAMAvailable = os.ramAvaliable;
            
            return false;
        }
        public static bool ChangeUserDetails(Hacknet.OS os, List<string> args)
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
        public static bool GenerateExampleAcadmicRecord(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FULL NAME HERE\n\n--------------------\nDEGREE HERE\nUNIVERSITY HERE\nGPA HERE";
            folder.files.Add(new FileEntry(File, "FULL NAME HERE"));
            return false;
        }
        public static bool GenerateExampleMedicalRecord(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.thisComputer;
            Folder folder = os.thisComputer.files.root.searchForFolder("home");
            string File = "FIRST NAME HERE\n--------------------\nLAST NAME HERE\n--------------------\nmale OR female\n--------------------\nDATE OF BIRTH HERE TIME OF BIRTH HERE\n--------------------\nMedical Record\nDate of Birth :: DATE OF BIRTH HERE TIME OF BIRTH HERE\nBlood Type :: BLOOD TYPE HERE\nHeight :: HEIGHT HERE IN CM\n Allergies :: ALLERGIES HERE\nActive Prescriptions :: ACTIVE PRESCRIPTSION HERE\nRecorded Visits :: RECORDED VISTS HERE\nNotes :: NOTES HERE";
            folder.files.Add(new FileEntry(File, "LASTNAMEHERE FIRSTNAMEHERE"));
            return false;
        }
        public static bool ExecuteHack(Hacknet.OS os, List<string> args)
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
        public static bool DeleteWhitelistDLL(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            List<int> FolderPath = new List<int>();
            FolderPath.Add(5);
            Folder folder = computer.files.root.searchForFolder("Whitelist");
            folder.files.Remove(folder.files[0]);
            return false;
        }
        public static bool ChangeMusic(Hacknet.OS os, List<string> args)
        {
            string song = args[1];
            MusicManager.playSongImmediatley("Content\\" + song);
            return false;
        }
        public static bool CrashComputer(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.crash(os.thisComputer.ip);
            return false;
        }
        public static bool AddProxy(Hacknet.OS os, List<string> args)
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
        public static bool AddFirewall(Hacknet.OS os, List<string> args)
        {
            string Solution = args[1];
            string LevelInput = args[2];
            string AdditionalTimeInput = args[3];
            int Level = Convert.ToInt32(LevelInput);
            float AdditionalTime;
            float.TryParse(AdditionalTimeInput, out AdditionalTime);
            Computer computer = os.connectedComp;
            if (args.Count < 2)
            {
                os.write("Usage: addFirewall (Solution) (Level) [AdditionalTime]");
                return false;
            }
            computer.addFirewall(Level, Solution, AdditionalTime);
            return false;
        }
        public static bool AddUser(Hacknet.OS os, List<string> args)
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
        public static bool OpenPort(Hacknet.OS os, List<string> args)
        {
            int port = Convert.ToInt32(args[1]);
            Computer computer = os.thisComputer;
            computer.openPort(port, os.thisComputer.ip);
            return false;
        }
        public static bool CloseAllPorts(Hacknet.OS os, List<string> args)
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
        public static bool ClosePort(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            if (args.Count < 1)
            {
                os.write("Usage: closePort (PortToClose)");
                return false;
            }
            int port = Convert.ToInt32(args[1]);
            return false;
        }
        public static bool RemoveProxy(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.hasProxy = false;
            return false;
        }
        /*public static bool RemoveFirewall(Hacknet.OS os, List<string> args)
        {
            Computer computer = os.connectedComp;
            computer.
            return false;
        } */
        public static bool AddComputer(Hacknet.OS os, List<string> args)
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
        public static bool DefineComputer(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            string Action = args[2];
            string ActionArgs = args[3];

            if (Action == "tracetime")
            {
                float TraceTime;
                float.TryParse(ActionArgs, out TraceTime);
                computer.traceTime = TraceTime;
            } else if (Action == "isadminsuper"){
                bool TrueOrFalse;
                bool.TryParse(ActionArgs, out TrueOrFalse);
                computer.admin.IsSuper = TrueOrFalse ? true : false;
            }
            return false;
        }
        public static bool PlaySFX(Hacknet.OS os, List<string> args)
        {
            SoundEffect sound = os.content.Load<SoundEffect>(args[1]);
            sound.Play();
            return false;
        }
        public static bool GetMoreRAM(Hacknet.OS os, List<string> args)
        {
            os.totalRam = 2048;
            return false;
        }
        public static bool SetFaction(Hacknet.OS os, List<string> args)
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
        public static bool TracedBehind250Proxies(Hacknet.OS os, List<string> args)
        {
            os.traceTracker.start(500f);
            return false;
        }
        public static bool OxygencraftStorageFaciltyCache(Hacknet.OS os, List<string> args) // Don't tell anyone about this command, keep it a secret
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
            bin.files.Add(new FileEntry(PortExploits.ValidPacemakerFirmware, Utils.GetNonRepeatingFilename("PacemakerWorking", ".dll", bin)));
            bin.files.Add(new FileEntry(PortExploits.ValidAircraftOperatingDLL, Utils.GetNonRepeatingFilename("747FlightSystem", ".dll", bin)));
            os.netMap.nodes.Add(computer);
            return false;
        }
        public static bool DisableEmailIcon(Hacknet.OS os, List<string> args)
        {
            os.DisableEmailIcon = true;
            return false;
        }
        public static bool EnableEmailIcon(Hacknet.OS os, List<string> args)
        {
            os.DisableEmailIcon = false;
            return false;
        }
        public static bool NodeRestore(Hacknet.OS os, List<string> args)
        {
            DLC1SessionUpgrader.ReDsicoverAllVisibleNodesInOSCache(os);
            return false;
        }
        public static bool AddRestoreCircle(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            SFX.addCircle(computer.getScreenSpacePosition(), Utils.AddativeWhite * 0.4f, 70f);
            return false;
        }
        public static bool WhitelistBypass(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            Folder folder = computer.files.root.searchForFolder("Whitelist");
            folder.files.Remove(folder.files[1]);
            folder.files.Add(new FileEntry(os.thisComputer.ip, "list.txt"));
            os.execute("connect " + computer.ip);
            return false;
        }
        public static bool SetTheme(Hacknet.OS os, List<string> args)
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
        public static bool SetCustomTheme(Hacknet.OS os, List<string> args)
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
        public static bool UnlinkComputer(Hacknet.OS os, List<string> args)
        {
            Computer computer1 = Programs.getComputer(os, args[1]);
            Computer computer2 = Programs.getComputer(os, args[2]);
            computer1.links.Remove(os.netMap.nodes.IndexOf(computer2));
            return false;
        }
        public static bool LoseAllNodes(Hacknet.OS os, List<string> args)
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
        public static bool LoseNode(Hacknet.OS os, List<string> args)
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
        public static bool RevealNode(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            int CompToReveal = os.netMap.nodes.IndexOf(computer);
            os.netMap.visibleNodes.Add(CompToReveal);
            return false;
        }
        public static bool RemoveComputer(Hacknet.OS os, List<string> args)
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
        public static bool ResetIP(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.ip = NetworkMap.generateRandomIP();
            return false;
        }
        public static bool ResetPlayerCompIP(Hacknet.OS os, List<string> args)
        {
            os.thisComputerIPReset();
            return false;
        }
        public static bool SetIP(Hacknet.OS os, List<string> args)
        {
            Computer computer = Programs.getComputer(os, args[1]);
            computer.ip = args[2];
            return false;
        }
        public static bool ShowFlags(Hacknet.OS os, List<string> args)
        {
            os.write(os.Flags.GetSaveString());
            return false;
        }
        public static bool AddFlag(Hacknet.OS os, List<string> args)
        {
            os.Flags.AddFlag(args[1]);
            return false;
        }
        public static bool RemoveFlag(Hacknet.OS os, List<string> args)
        {
            os.Flags.RemoveFlag(args[1]);
            return false;
        }
        public static bool AuthenticateToIRC(Hacknet.OS os, List<string> args)
        {
            os.Flags.RemoveFlag("DLC_Player_IRC_Authenticated");
            return false;
        }
        public static bool AddAgentToIRC(Hacknet.OS os, List<string> args)
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
        
    }
}