using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System.IO;
namespace CORplugin
{   [BepInProcess("Among Us.exe")]
    [BepInPlugin("Guid","CORplugin","1,00")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo("Plugin {CrescentOfRoles} is loaded!");
        }
    [HarmonyPatch(typeof (IL2CPPChainloader))]
    [HarmonyPatch("ModStamp.png")]
  class CORPatches
  {
     [HarmonyPostfix]
     static void CORPostfix();
}
}}
