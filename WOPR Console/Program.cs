using System;
using System.Threading;
class Program
{
    static void WoprWrite(string textContent)
    {
        for (int i = 0; i < textContent.Length; i++)
        {
            Console.Write(textContent[i]);
            System.Threading.Thread.Sleep(50);
        }
        Console.WriteLine("");
    }

    static void WoprWriteFast(string textContent)
    {
        for (int i = 0; i < textContent.Length; i++)
        {
            Console.Write(textContent[i]);
            System.Threading.Thread.Sleep(5);
        }
    }

    static void WWFSameLine(string textContent)
    {
        for (int i = 0; i < textContent.Length; i++)
        {
            Console.Write(textContent[i]);
            System.Threading.Thread.Sleep(5);
        }
        Console.WriteLine("");
    }

    static void CalcAndSuccess(string targetName)
    {
        // Target trajectory 'calculation'
        WoprWrite("CALCULATING IDEAL TRAJECTORY FOR " + targetName);

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
        WoprWrite("SUCCESS.");
        Thread.Sleep(1000);
        Console.Clear();
    }

    static void OpenTheWopr()
    {
        string response;
        WoprWrite("\r\nGREETINGS PROFFESSOR FALKEN.\r\n");
        Console.Out.Flush();
        Console.ReadLine();
        WoprWrite("\r\nHOW ARE YOU FEELING TODAY?\r\n");
        Console.Out.Flush();
        Console.ReadLine();
        WoprWrite("\r\nEXCELLENT. IT'S BEEN A LONG TIME. CAN YOU EXPLAIN\r\nTHE REMOVAL OF YOUR USER ACCOUNT ON 6/23/73?\r\n");
        Console.Out.Flush();
        Console.ReadLine();
        WoprWrite("\r\nYES THEY DO. SHALL WE PLAY A GAME?\r\n");
        Console.Out.Flush();
        response = Console.ReadLine();
        if (response.Contains("Global Thermonuclear War") ^ response.Contains("GTW"))
        {
            WoprWrite("\r\nWOULDN'T YOU PREFER A GOOD GAME OF CHESS?\r\n");
            response = Console.ReadLine();
            if (response.Contains("Global Thermonuclear War") ^ response.Contains("GTW"))
            {
                WoprWrite("\r\nFINE.\r\n");
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
                WoprWriteFast(writeLine);
                WoprWrite("\r\nWHICH SIDE DO YOU WANT?\r\n");
                WoprWrite("\r\n        1. UNITED STATES");
                WoprWrite("        2. SOVIET UNION");
                WoprWriteFast("\r\nPLEASE CHOOSE ONE: ");
                int warSide = Convert.ToInt32(Console.ReadLine());
                if (warSide == 1)
                {
                    Console.Clear();
                    WoprWrite("\r\nYOU SHOULDN'T HAVE CHOSEN THAT. I WILL NOW LAUNCH ALL NUKES. GOOD DAY TO YOU.");
                }
                else if (warSide == 2)
                {
                    Console.Clear();
                    WoprWrite("\r\nAWAITING FIRST STRIKE COMMAND");
                    WoprWriteFast("_____________________________" + Environment.NewLine);
                    WoprWrite("PLEASE LIST PRIMARY TARGETS\r\nBY CITY AND/OR COUNTY NAME:");
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
                    WWFSameLine("TRAJECTORY HEADING  TRAGJECTORY HEADING  TRAJECTORY HEADING  TRAJECTORY HEADING");
                    WWFSameLine("__________________  ___________________  __________________  __________________");
                    WWFSameLine("A-5520-A 429 523    C-5520-A 243 587     E-5520-A 398 984    G-5520-A 919 437");
                    WWFSameLine("       B 684 295           B 892 754            B 394 345           B 132 147");
                    WWFSameLine("       C 125 398           C 374 256            C 278 574           C 095 485");
                    WWFSameLine("       D 768 747           D 384 567            D 251 953           D 489 794");
                    WWFSameLine("       E 480 294           E 873 543            E 093 684           E 025 344");
                    Console.WriteLine("");
                    WWFSameLine("B-5520-A 429 098    D-5520-A 365 590     F-5520-A 574 651    H-5520-A 959 913");
                    WWFSameLine("       B 450 425           B 273 856            B 118 382           B 276 243");
                    WWFSameLine("       C 675 871           C 218 852            C 321 615           C 952 464");
                    WWFSameLine("       D 982 121           D 439 642            D 065 481           D 281 318");
                    WWFSameLine("       E 574 104           E 128 534            E 253 475           E 684 420");
                }
            }
        }
        else
        {
            WoprWrite("WAIT, THIS ISN'T HOW IT GOES! GOODBYE.");
        }
    }

    static void Main(string[] args)
    {

        Console.WriteLine("LOGON: ");
        Console.Out.Flush();
        string password = Console.ReadLine();
        if (password == "Joshua")
        {
            OpenTheWopr();
        }
        else if (password == "help logon")
        {
            WoprWrite("HELP NOT AVAILABLE");
            WoprWrite("LOGON: ");
            Console.Out.Flush();
            password = Console.ReadLine();
            if (password == "Joshua")
            {
                OpenTheWopr();
            }

        }
        else if (password == "help games")
        {
            WoprWrite("'GAMES' REFERS TO MODELS, SIMULATIONS, AND GAMES\r\nWHICH HAVE TACTICAL AND STRATEGIC APPLICATIONS.");
            WoprWrite("LOGON: ");
            Console.Out.Flush();
            password = Console.ReadLine();
            if (password == "Joshua")
            {
                OpenTheWopr();
            }
        }
        else if (password == "list games")
        {
            WoprWrite("FALKEN'S MAZE\r\nBLACK JACK\r\nGIN RUMMY\r\nHEARTS\r\nBRIDGE\r\nCHECKERS\r\nCHESS\r\nPOKER\r\nFIGHTER COMBAT\r\nGUERRILLA ENGAGEMENT\r\nDESERT WARFARE\r\nAIR-TO-GROUND ACTIONS\r\nTHEATERWIDE TACTICAL WARFARE\r\nTHEATERWIDE BIOTOXIC AND CHEMICAL WARFARE\r\n");
            WoprWrite("GLOBAL THERMONUCLEAR WAR");
            WoprWrite("LOGON: ");
            Console.Out.Flush();
            password = Console.ReadLine();
            if (password == "Joshua")
            {
                OpenTheWopr();
            }
        }
        else
        {
            WoprWrite("IDENTIFICATION NOT RECOGNIZED BY SYSTEM");
            WoprWrite("---CONNECTION TERMINATED---");
        }
    }
}