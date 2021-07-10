// Hello dear reader! This is a fun pointless program
// in an attempt to emulate the WOPR (War Operations Plan Response) from WarGames.
//
// Be advised - this code is still new and budding. It may not be optimized
// and/or may not be the best but that's a programmer's curse.
//
// Anyway, have fun! Maybe make a fork.
//
// Future plans:
// 1. change the if/else password system and make it a bit better and not have to repeat myself as much.

using System;
using System.Threading;
class Program
{
	static void WoprWrite(string textContent, int sleepTime)
	{
		// Creates 80s terminal typing effect but flawlessly and without *any* bugs
		for (int i = 0; i < textContent.Length; i++)
		{
			Console.Write(textContent[i]);
			Thread.Sleep(sleepTime);
		}
		Console.WriteLine("");
	}

	static void WWSameLine(string textContent, int sleepTime)
	{
		for (int i = 0; i < textContent.Length; i++)
		{
			Console.Write(textContent[i]);
			Thread.Sleep(sleepTime);
		}
		// Console.WriteLine("");
	}

	static void CalcAndSuccess(string targetName)
	{
		// Target trajectory 'calculation'
		WoprWrite("CALCULATING IDEAL TRAJECTORY FOR " + targetName, 50);

		// Loading dots each half a second appart
		Thread.Sleep(500);
		Console.Write(".");
		Thread.Sleep(500);
		Console.Write(".");
		Thread.Sleep(500);
		Console.Write(".");

		// Wait one second, clear, then display success. 
		// Wait one more second, then clear console again to restart the process.
		Thread.Sleep(1000);
		Console.Clear();
		WoprWrite("SUCCESS.", 50);
		Thread.Sleep(1000);
		Console.Clear();
	}
	static void WoprWait(string textContent)
	{
		Thread.Sleep(100);
		Console.WriteLine(textContent);
	}

	static void OpenTheWopr()
	{
		Thread.Sleep(1000);
		Console.Clear();
		WoprWait("↑↑45		↑↑456	↑↑009		↑↑893	↑↑972		↑↑315");
		WoprWait("PRT CON. 345	SECTRAN 9.4.3			PORT STRAT: SD-345");
		WoprWait("\r\n(311) 699-7495");
		Console.Clear();

		WoprWait("(311) 936-3582");
		Thread.Sleep(100);
		Console.Clear();

		WoprWait("(311) 767-8739");
		WoprWait("(311) 936-2364");
		WoprWait("-             PRT. STAT.                                                     CRT. DEF.");
		WoprWait("████████████████====================================================================");
		WoprWait("FSKDJLSD: SDSDKJ: SDFJSL:                                               DKSJL: SKFJJ: SDKFLJJ:");
		WoprWait("SYSPROC FUNCT READY                                                ALT NET READY");
		WoprWait("CPU AUTH RV-345-AX8                                SYSCOMP STATUS: ALL PORTS ACTIVE");
		WoprWait("22/34534.90/3209                                                              ↑↑CVB-3904-39490");
		WoprWait("(311) 936-2364");
		WoprWait("████████████████████████████████████████████████████████████████████████████");
		WoprWait("(311) 936-3582");
		WoprWait("22/34534.90/3209                                                              ↑↑CVB-3904-39490");
		Console.Clear();

		WoprWait("12934-AD-43KJ: CONTR PAK");
		WoprWait("(311) 767-1083");
		WoprWait("     FLD CRS: 33.34.543  HPBS: 34/56/67/83  STATUS FLT  034/304");
		Console.Clear();

		WoprWait("████████████████████████");
		WoprWait("UU05-45-F6-3456                  NOPR STATUS: TRAK OFF     PRON ACTIVE");
		WoprWait("045:45:45 UU WER: 45/29/01  XCOMP: 43239582  YCOMP:3492930D  ZCOMP:34906834");
		WoprWait("████████████████████████████████████████████████████████████████████████████");
		WoprWait("-           PRT. STAT.                                   CRT. DEF.");
		WoprWait("(311) 936-3582===================================================");
		WoprWait("               3453                                          3534");
		Console.Clear();

		Thread.Sleep(1000);
		string response;
		WoprWrite("GREETINGS PROFFESSOR FALKEN.\r\n", 50);
		Console.Out.Flush();
		Console.ReadLine();
		WoprWrite("\r\nHOW ARE YOU FEELING TODAY?\r\n", 50);
		Console.Out.Flush();
		Console.ReadLine();
		WoprWrite("\r\nEXCELLENT. IT'S BEEN A LONG TIME. CAN YOU EXPLAIN\r\nTHE REMOVAL OF YOUR USER ACCOUNT ON 6/23/73?\r\n", 50);
		Console.Out.Flush();
		Console.ReadLine();
		WoprWrite("\r\nYES THEY DO. SHALL WE PLAY A GAME?\r\n", 50);
		Console.Out.Flush();
		response = Console.ReadLine();
		if (response.Contains("Global Thermonuclear War") ^ response.Contains("GTW"))
		{
			WoprWrite("\r\nWOULDN'T YOU PREFER A GOOD GAME OF CHESS?\r\n", 50);
			response = Console.ReadLine();
			if (response.Contains("Global Thermonuclear War") ^ response.Contains("GTW"))
			{
				WoprWrite("\r\nFINE.\r\n", 50);
				Thread.Sleep(2000);
				Console.Clear();
				string writeLine = @"
                                                                                           #@@@@@@
                                                                    /@@@@@@@ @@* @
    & @# (                                                      @#@@@@@@@@@@@@@@@@@ @@@@@@ @
    @@@@@@@@@@@@@@@@@@@@*          .@@*             @@@  / @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
   @@@@@@@@@@@@@@@@@@@@@@@ @@   ,@@@(               @@*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ /@
   @@@@@@@@@@@@@@@@@@@@@@@.@@/@@@@@                 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@
   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     @@
    .@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.                  @@@@@@@@@     @@@@@@@@@@@@@  @@@@     @
       ,@@@@@@@@@@@@@@@@@@@@@@@@,                      @@@                          @@
              @@@@@@@@@@@@./,#@@                                   
                 &@@            @/                       
                                                         
               UNITED STATES                                          SOVIET UNION
";
				WoprWrite(writeLine, 1);

				WoprWrite("\r\nWHICH SIDE DO YOU WANT?\r\n", 50);
				WoprWrite("\r\n        1. UNITED STATES", 50);
				WoprWrite("        2. SOVIET UNION", 50);
				WWSameLine("\r\nPLEASE CHOOSE ONE: ", 50);
				Console.ReadLine();

				Console.Clear();
				WoprWrite("\r\nAWAITING FIRST STRIKE COMMAND", 50);
				Console.WriteLine("______________________________\r\n");
				Thread.Sleep(1000);
				WoprWrite("PLEASE LIST PRIMARY TARGETS\r\nBY CITY AND/OR COUNTY NAME:", 50);
				string firstTarget = Console.ReadLine();
				firstTarget = firstTarget.ToUpper();
				string secondTarget = Console.ReadLine();
				secondTarget = secondTarget.ToUpper();
				string thirdTarget = Console.ReadLine();
				thirdTarget = thirdTarget.ToUpper();
				string fourthTarget = Console.ReadLine();
				fourthTarget = fourthTarget.ToUpper();
				string fifthTarget = Console.ReadLine();
				fifthTarget = fifthTarget.ToUpper();
				Console.Clear();

				// Target 1 trajectory 'calculation'
				CalcAndSuccess(firstTarget);

				// Target 2 trajectory 'calculation'
				CalcAndSuccess(secondTarget);

				// Target 3 trajectory 'calculation'
				CalcAndSuccess(thirdTarget);

				// Target 4 trajectory 'calculation'
				CalcAndSuccess(fourthTarget);

				// Target 5 trajectory 'calculation'
				CalcAndSuccess(fifthTarget);

				Console.WriteLine(writeLine + Environment.NewLine);
				WWSameLine("TRAJECTORY HEADING  TRAGJECTORY HEADING  TRAJECTORY HEADING  TRAJECTORY HEADING\r\n", 1);
				WWSameLine("__________________  ___________________  __________________  __________________\r\n", 1);
				Thread.Sleep(1000);
				Console.WriteLine("A-5520-A 429 523    C-5520-A 243 587     E-5520-A 398 984    G-5520-A 919 437");
				Thread.Sleep(1000);
				Console.WriteLine("       B 684 295           B 892 754            B 394 345           B 132 147");
				Thread.Sleep(1000);
				Console.WriteLine("       C 125 398           C 374 256            C 278 574           C 095 485");
				Thread.Sleep(1000);
				Console.WriteLine("       D 768 747           D 384 567            D 251 953           D 489 794");
				Thread.Sleep(1000);
				Console.WriteLine("       E 480 294           E 873 543            E 093 684           E 025 344");
				Thread.Sleep(1000);
				Console.WriteLine("");
				Console.WriteLine("B-5520-A 429 098    D-5520-A 365 590     F-5520-A 574 651    H-5520-A 959 913");
				Thread.Sleep(1000);
				Console.WriteLine("       B 450 425           B 273 856            B 118 382           B 276 243");
				Thread.Sleep(1000);
				Console.WriteLine("       C 675 871           C 218 852            C 321 615           C 952 464");
				Thread.Sleep(1000);
				Console.WriteLine("       D 982 121           D 439 642            D 065 481           D 281 318");
				Thread.Sleep(1000);
				Console.WriteLine("       E 574 104           E 128 534            E 253 475           E 684 420");

				Console.ReadKey();
			}
		}
		else
		{
			Console.Clear();
			WoprWrite("ATTEMPTING TO CONNECT TO MAINFRAME", 50);
			Thread.Sleep(500);
			Console.Write(".");
			Thread.Sleep(500);
			Console.Write(".");
			Thread.Sleep(500);
			Console.Write(".");
			Thread.Sleep(1000);
			Console.Clear();
			Thread.Sleep(2000);
			WoprWrite("ERROR. CANNOT CONNECT. NORAD/USNORTHCOM SYSTEM BUSY.\r\nTERMINATING CONNECTION.", 50);
			Console.ReadKey();
		}
	}

	static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.BackgroundColor = ConsoleColor.Black;

		Console.WriteLine("LOGON: ");
		Console.Out.Flush();
		string password = Console.ReadLine();
		if (password == "Joshua")
		{
			OpenTheWopr();
		}
		else if (password == "help logon")
		{
			WoprWrite("HELP NOT AVAILABLE", 50);
			WoprWrite("LOGON: ", 50);
			Console.Out.Flush();
			password = Console.ReadLine();
			if (password == "Joshua")
			{
				OpenTheWopr();
			}

		}
		else if (password == "help games")
		{
			WoprWrite("'GAMES' REFERS TO MODELS, SIMULATIONS, AND GAMES\r\nWHICH HAVE TACTICAL AND STRATEGIC APPLICATIONS.", 50);
			WoprWrite("LOGON: ", 50);
			Console.Out.Flush();
			password = Console.ReadLine();
			if (password == "Joshua")
			{
				OpenTheWopr();
			}
		}
		else if (password == "list games")
		{
			Thread.Sleep(1000);
			WoprWrite("\r\nFALKEN'S MAZE", 50);
			Thread.Sleep(1000);
			WoprWrite("BLACK JACK", 50);
			Thread.Sleep(900);
			WoprWrite("GIN RUMMY", 50);
			Thread.Sleep(800);
			WoprWrite("HEARTS", 50);
			Thread.Sleep(700);
			WoprWrite("BRIDGE", 50);
			Thread.Sleep(600);
			WoprWrite("CHECKERS", 50);
			Thread.Sleep(500);
			WoprWrite("CHESS", 50);
			Thread.Sleep(500);
			WoprWrite("POKER", 50);
			Thread.Sleep(500);
			WoprWrite("FIGHTER COMBAT", 50);
			Thread.Sleep(500);
			WoprWrite("GUERRILLA ENGAGEMENT", 50);
			Thread.Sleep(500);
			WoprWrite("DESERT WARFARE", 50);
			Thread.Sleep(500);
			WoprWrite("AIR-TO-GROUND ACTIONS", 50);
			Thread.Sleep(500);
			WoprWrite("THEATERWIDE TACTICAL WARFARE", 50);
			Thread.Sleep(500);
			WoprWrite("THEATERWIDE BIOTOXIC AND CHEMICAL WARFARE\r\n", 50);

			Thread.Sleep(1000);
			WoprWrite("GLOBAL THERMONUCLEAR WAR\r\n", 50);
			Thread.Sleep(1000);
			WoprWrite("LOGON: ", 50);
			Console.Out.Flush();
			password = Console.ReadLine();
			if (password == "Joshua")
			{
				OpenTheWopr();
			}
		}
		else
		{
			WoprWrite("IDENTIFICATION NOT RECOGNIZED BY SYSTEM", 50);
			WoprWrite("---CONNECTION TERMINATED---", 50);
		}
	}
}