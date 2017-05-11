using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugMod
{
    class LongVariables
    {
        public static string IRCLog(Hacknet.OS os)
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
#11:34//Channel//User |##QOT##|" + os.defaultUser.name + @"|##QOT##| added to whitelist.
#11:34//Kaguya//@channel, I|##SIQ##|d like to welcome " + os.defaultUser.name + @"to the fold.
#11:35//Kaguya//@" + os.defaultUser.name + @"- congratulations on beating the trials.
The others are out on assignments right now - there should be time for you to catch up if you want in on this round.
#11:35//Kaguya//You|##SIQ##|re on the team now, so the final contract belongs to you.
#11:35//Kaguya//Contracts are on a first come first served system here - I mostly take care of admin, recon and all that - making sure everyone has stuff to do that builds towards our goals, and everyone has all the tools and info they need to do their work.
#11:35//Kaguya//@Coel, @D3f4ult - introduce yourselves when you|##SIQ##|ve got a sec.
#11:35//Kaguya//In the meantime @" + os.defaultUser.name + @", check out the server and take a look at that last job.
#11:35//Kaguya//Welcome to the team.
#11:35//D3f4ult//Hey @" + os.defaultUser.name + @", good to have you with us.
#11:35//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|The Ricer|##QOT##|
#11:36//Coel//Welcome to the team @" + os.defaultUser.name + @"!
#11:39//D3f4ult//Decryption setup complete!
#11:39//D3f4ult//Unfortunately it|##SIQ##|s not that portable yet - I|##SIQ##|ll get to work building a new shareable .exe for it
#11:39//D3f4ult//But for now just run stuff past me and I|##SIQ##|ll take a look.
#11:38//Coel//I wonder how long it|##SIQ##|ll take until you|##SIQ##|ve spent more time decrypting stuff for us than it|##SIQ##|d have taken you to set this up properly.
#11:38//D3f4ult//Ok, yes I am ashamed of myself, but no I|##SIQ##|m not answering that. It works, it|##SIQ##|ll be better when I|##SIQ##|ve got time. I|##SIQ##|m sure we can all live with that for now -_-
#11:38//Coel//We have to, don|##SIQ##|t we?
#11:38//D3f4ult//-_-
#11:39//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|The Ricer|##QOT##|
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
#11:40//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|DDOSer on some critical servers|##QOT##|
#11:45//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|DDOSer on some critical servers|##QOT##|
#11:45//Kaguya//@channel ---- UPDATE --- 
#11:45//Kaguya//Excellent work on your recent tasks - It|##SIQ##|s time for a team project.
#11:45//Kaguya//I|##SIQ##|m going to have all of you looking at the same network. It|##SIQ##|s not a race or anything, but this is a complex job that I think will benefit from the group|##SIQ##|s collective attention.
#11:46//Kaguya//Missions are up, good luck all!
#11:46//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|The Hermetic Alchemists - " + os.defaultUser.name + @"|##QOT##|
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
#11:59//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|The Hermetic Alchemists - " + os.defaultUser.name + @"|##QOT##|
#12:00//Coel//!
#12:00//Coel//@" + os.defaultUser.name + @" Nice, didn|##SIQ##|t think you|##SIQ##|d beat me to it.
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
#12:01//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|Memory Forensics (2/3)|##QOT##|
#12:03//D3f4ult//Whoa
#12:03//D3f4ult//@channel , have you tried SignalScramble out yet? From the Alchemists servers?
#12:03//D3f4ult//This thing is crazy
#12:03//Coel//Yeah. It|##SIQ##|s very impressive. Where|##SIQ##|d you hear about this @Kaguya ?
#12:03//Kaguya//Trade secret.
#12:03//Kaguya//Glad you like though. I suspect it|##SIQ##|ll be very useful for some future tasks.
#12:04//D3f4ult//niiiiiice
#12:11//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|Memory Forensics (2/3)|##QOT##|
#12:12//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|Striker|##SIQ##|s Archives|##QOT##|
#12:15//D3f4ult//Job complete @Coel - sorry you had to deal with that. I|##SIQ##|ve done my best to take care of it cleanly.
#12:15//Coel//Thanks. It|##SIQ##|s something I would have liked to be able to take care of myself but... yeah.
#12:15//D3f4ult//Totally understand, don|##SIQ##|t worry about it. Your job go well?
#12:15//Kaguya//Thanks for dealing with this one @D3f4ult
#12:15//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|Striker|##SIQ##|s Archives|##QOT##|
#12:15//D3f4ult//You got it boss.
#12:15//Coel//Yeah - just going over all the Hermetic Alchemist servers again and making sure we|##SIQ##|re all cleaned up. Should be as safe as we|##SIQ##|re going to be from that now.
#12:15//Coel//Someone left some disconnect logs all over the place, but don|##SIQ##|t worry, I didn|##SIQ##|t go snooping.
#12:15//D3f4ult//Ugh, yeah. @Kaguya - any chance you could find us something to deal with DC log stuff?
#12:15//Coel//You mean, other than forkbombing?
#12:16//D3f4ult//It|##SIQ##|s so crude :|##BS##|
#12:16//Coel//mmm, wont argue with that.
#12:16//Kaguya//I|##SIQ##|ll see what I can do. No promises on that one though.
#12:16//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|It Follows|##QOT##|
#12:21//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|It Follows|##QOT##|
#12:22//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|Neopals - " + os.defaultUser.name + @"|##QOT##|
#12:23//D3f4ult//You and me for this one " + os.defaultUser.name + @"!
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
#12:48//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|Neopals - " + os.defaultUser.name + @"|##QOT##|
#12:48//D3f4ult//Oh damn - nice @" + os.defaultUser.name + @" . I was messing about on the Auth Server for too long.
#12:48//D3f4ult//@Coel - how|##SIQ##|s your thing going? Still super secret?
#12:48//Coel//Yep. Almost done though - triple checking for logs and such this time. Not really the sort of thing where I can afford to make mistakes.
#12:48//D3f4ult//Let us know if you need a hand... Kinda feeling in the dark here.
#12:48//Coel//Will do.
#12:49//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|Expo Grave|##QOT##|
#12:57//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|Expo Grave|##QOT##|
#12:57//Kaguya//@channel Excellent work all. Everyone|##SIQ##|s marked their tasks as complete, so lets move on. 
#12:58//Kaguya//This next network is a big one. You|##SIQ##|re all on this one together. Be thorough, be patient, look carefully, and take notes.
#12:58//Kaguya//Remember - you|##SIQ##|re here because you|##SIQ##|re the best.
#12:58//Kaguya//Good luck everyone.
#12:58//Coel//Uhm, any particular reason that this is our next target @Kaguya ?
#12:58//Kaguya//DM|##SIQ##|s Coel - this regards tracking Nisei MK III.
#12:58//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|Take Flight - " + os.defaultUser.name + @"|##QOT##|
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
#13:03//Coel//Oh yeah, @" + os.defaultUser.name + @" - the whitelist server is down!
#13:03//Coel//You should be able to connect to the Bookings Mainframe now
#13:13//Channel//CONTRACT COMPLETE: @" + os.defaultUser.name + @" completed contract |##QOT##|Take Flight - " + os.defaultUser.name + @"|##QOT##|
#13:13//Channel//Additional details provided:
#13:13//Channel//|##LSB##|NU2N3|##RSB##|
#13:13//Coel//Nice! I|##SIQ##|ll test it now.
#13:13//Kaguya//Thanks Coel. My authenticator script approved it though, good from my end.
#13:13//Kaguya//There are a few time sensitive things to get done here.
#13:13//Kaguya//@Coel - the information you needed has come in, and it looks good. One last strike on your end should do it. You|##SIQ##|re up for that.
#13:14//Coel//Roger that. Also, the account looks good too " + os.defaultUser.name + @", nice work.
#13:14//Kaguya//@oxygencraft - You got to the pacific server first, so I|##SIQ##|m going to have you following that up. You|##SIQ##|re installing our backup plan.
#13:14//Kaguya//@D3f4ult - You|##SIQ##|re with me sorting out some connection protocols - should be your specialty.
#13:14//Kaguya//Good luck everyone.
#13:14//Channel//CONTRACT CLAIMED: @" + os.defaultUser.name + @" claimed contract |##QOT##|" + os.defaultUser.name + @" - Take_Flight Cont.|##QOT##|
#13:14//D3f4ult//I|##SIQ##|m on it. Go get em @Coel , @" + os.defaultUser.name + @"";
            return IRCLogData;
        }
    }
}
