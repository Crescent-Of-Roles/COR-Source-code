using HarmonyLib;
using Playerinfo_GameData;
namespace AddPatcher
{
  public class PlayerPatcher
   { 
    static void AddPlayer()
   {
      var Harmony = new Harmony("MyfirstAddPatcher");
      Harmony.PatchAll();
   }
    }
     }
      [HarmonyPatch(typeof(GameData))]
      [HarmonyPatch("AddPlayer")]
     

public int PlayerControl
{
 get called AddPlayer, args: PlayerControl(0, "やぁ");

 get called AddPlayer, args: PlayerControl(1, "???");
 get called AddPlayer, args: PlayerControl(2,"???" );
get called AddPlayer, args: PlayerControl(3, "???");
 get called AddPlayer, args: PlayerControl(4, "???");
get called AddPlayer, args: PlayerControl(5, "???");
get called AddPlayer, args: PlayerControl(6, "???");
}