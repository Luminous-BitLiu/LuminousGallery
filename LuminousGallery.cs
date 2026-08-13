using BepInEx;
using BepInEx.Hacknet;
using Pathfinder.Executable;
using Pathfinder.Port;
using System;

namespace LuminousGallery
{
    [BepInPlugin(ModGUID, ModName, ModVer)]
    public class LuminousGallery : HacknetPlugin
    {
        public const string ModGUID = "Luminous_BitLiu.LuminousGallery";
        public const string ModName = "LuminousGallery";
        public const string ModVer = "1.0";

        public override bool Load()
        {
            string str = @"
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
#               LuminousGallery 1.0:A Creative Mod                #
#                   Luminous_BitLiu  (C)  2026                    #
#        My limit is determined by the maximum light flux.        #
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
";
            string Stay = @"
I need you to stay, need you to stay, hey
";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Stay);
            Console.ResetColor();
            LogDebug("Loading Executables...");
            ExecutableManager.RegisterExecutable<BitLiuTool>("#BITLIU_TOOL#");
            ExecutableManager.RegisterExecutable<SSLFastTool>("#SSL_FAST#");
            PortManager.RegisterPort("BitLiuPort", "BitLiu Backdoor", 213);
            return true;
        }

        private void LogDebug(string message)
        {
            Log.LogDebug(message);
        }
    }
}