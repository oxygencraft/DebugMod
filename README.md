# DebugMod

This is a mod for Hacknet that allows the user to use various debug commands

To report bugs or feature requests, open an issue in the issues section 

Requires Hacknet Pathfinder: https://github.com/Arkhist/Hacknet-Pathfinder

# How to report issues:

1. Search before opening, someone else may of opened it.
2. Make sure that your game files aren't broken before reporting the issue.
3. Tell me how to replicate the bug.

# Empty exception and event listener call failed:

There isn't much I can do about it, it's a pathfinder bug not calling the command method.

# Warning:

Use this at your own risk, this may corrupt saves.

# Beta Commands (Download the beta build from releases):

NameORIDORIP or similar means you can put the name of the computer, id of the computer or the ip of the computer

showFlags - Shows all the flags for save

addFlag - Adds a flag to the save: Usage: addFlag (FlagToAdd)

removeFlag - Removes a flag from the save: Usage: removeFlag (FlagToRemove)

authenticateToIRC - Shows IRC Authentication screen when you connect to IRC

addAgentToIRC - Adds an agent to IRC: Usage: addAgentToIRC (NameORIDORIP) (AgentName) (AgentPassword) (AgentColourRed) (AgentColourBlue) (AgentColourGreen)

setCompPorts - Sets the ports of the computer to what you input: Usage: setCompPorts (NameORIDORIP) (Port eg. 21,25,22,80 (This will remove all ports then add 21,25,22,80))

addSongChangerDaemon - Adds the song changer like the credits server had: Usage: addSongChanger (NameORIDORIP)

addRicerConnectDaemon - Adds the connect screen like ricer had: Usage: addRicerConnect (NameORIDORIP)

addDLCCreditsDaemon - Adds the dlc credits screen like Kaguya_Projects had: Usage: addDLCCredits (NameORIDIORIP)

addIRCDaemon - A bit buggy currently, this one will come in the stable release of 2.0

addISPDaemon - Adds the ISP Management like ISP Management Server had: Usage: addISPDaemon (NameORIPORID)

quit - Exits the game

deleteLogs - Auto deletes logs from the computer in argument 1: Usage: deleteLogs (NameORIPORID)

forkbombProof - Makes you forkbomb proof by setting your ram 1 above the forkbomb (1000000000) ram target

showIPNamesAndID - Shows the IP, Name and the ID of argument 1: Usage: showIPNamesAndID (IPORIDORName)

changeAdmin - Changes the admin of the computer in argument 1: Usage: changeAdmin (IPORIDORName) (Admin)

Valid Options: basic,fastbasic,fastprogress,alwaysactive,none

viewAdmin - Outputs to the console of the admin of argument 1: Usage: viewAdmin (IPORIDORName)

# New Commands:

setTheme - Sets the theme to argument one: Usage: setTheme [THEME]

Valid Options: TerminalOnly,Blue,Teal,Yellow,Green,White,Purple,Mint,Colamaeleon,GreenCompact,Riptide,Riptide2

setCustomTheme - Sets the theme to a custom one, root path is Content/: Usage: setCustomTheme: (PathToTheme)

linkComputer - Links SourceIP to RemoteIP like when you do scan: Usage: linkComputer (SourceIP) (RemoteIP)

unlinkComputer - Unlinks SourceIP to RemoteIP: Usage: unlinkComputer (SourceIP) (RemoteIP)

loseAllNodes - Makes you lose all nodes except for your player computer

loseNode - Loses the node in argument 1: Usage: loseNode (IPORIDORName)

revealNode - Reveals the node in argument 1: Usage: revealNode (IPORIDORName)

removeComputer - Removes computer in argument 1: Usage: removeComputer (IPORIDORName)

resetIP - Resets the ip of the computer in argument 1 like when you do it in ISP server (This does not complete the ETAS, see resetPlayerCompIP): Usage: resetIP (IPORIDORName)

resetPlayerCompIP - Resets the player computer IP and completes ETAS

setIP - Sets the target computer to the IP in argument 2: Usage: setIP (IPORIDORName) (NewIP)

# Command List:

openAllPorts - Opens all ports on connected computer

bypassProxy - Disable proxy on connected computer

solveFirewall - Solves firewall on connected computer

getAdmin- Gives admin on connected computer

loseAdmin - Lose admin on connected computer

startDeathSeq - Starts ETAS

cancelDeathSeq - Stops ETAS

setHomeNodeServer - Sets home contracts server

setHomeAssetServer - Sets home assets server

debug - gives all executables in the game (You can't use port exploits that open unhackable ports)

revealAll - Reveals all computers in game save

addIRCMessage - Adds IRC Message to server: Usage: addIRCMessage (ComputerID) (Author) (Message)

strikerAttack - Starts Striker hack (May be bugged for some users)

themeAttack - Starts Naix hack (May be bugged for some users)

callThePoliceSoTheyCanTraceYou - 100 sec trace

reportYourselfToFBI - 20 sec trace

traceYourselfIn - However long you want trace: Usage: traceYourselfIn (TimeInSeconds)

warningFlash - Shows a warning flash

stopTrace - Stops a trace

hideDisplay - Hides display

hideNetMap - Hides NetMap

hideTerminal - Hides terminal (There is no way to get it back apart from restart the game)

hideRAM - Hides RAM

showDisplay - Shows display

showNetMap - Shows NetMap

showTerminal - Shows Terminal

showRAM - Shows RAM

getUniversalAdmin - Gets admin on every computer in game save

changeUserDetails - Changes admin password: Usage: changeUserDetails (OldUsername) (NewUsername) (NewPassword)

executeHack - Executes a hacker script (Put hacker scripts in Content/HackerScripts)

generateExampleAcademicRecord - Generates an example academic record

generateExampleMedicalRecord - Generates an example medical record

changeMusic - Changes music (Music must be .ogg and in Content/)

crashComputer - Crashes computer you are connected to

addProxy - adds proxy to computer you are connected to: Usage: addProxy (TimeInSeconds)

addFirewall - adds firewall to computer you are connected to: Usage: addFirewall (Solution) (Level) [AdditionalTime]

addUser - adds a user to computer you are connected to: Usage: addUser (Username) (Password)

openPort - Opens port on the computer you are connected to: Usage: openPort (PortToOpen)

closeAllPorts - Closes all ports on the computer you are connected to

closePort - Closes port on the computer you are connected to: Usage: closePort (PortToClose)

removeProxy - Removes proxy from the computer you are connected to

playSFX - Plays a sound effect, root directory is Content: Usage: playSFX (PathToSoundEffect eg. SFX/EmailSound)

deleteWhitelistDLL - Deletes authenticator.dll from a whitelist server or whitelist protected server: Usage: DeleteWhitelistDLL (IPOrIDOrName)

addComputer - Adds a computer on the fly: Usage: addComputer (Name) (IP) (SecurityLevel) (CompType) (ID)

getMoreRAM - Sets available RAM to 2048

setFaction - Sets faction according to argument one: setFaction entropy/csec/bibliotheque

tracedBehind250Proxies - Trace of 500 secs

disableEmailIcon - Disables the email icon like the Kaguya Trials

enableEmailIcon - Enables the email icon

nodeRestore - Restores nodes like when you click disable tracking in the dlc credits server

addWhiteCircle - Maybe addes the circle when each node is restored

