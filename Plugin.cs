using BepInEx;
using BepInEx.IL2CPP;
using Harmonylib;
namespace CORplugin
{
    [BepInPlugin("Guid","CORplugin","1,00")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo("Plugin {CrescentOfRoles} is loaded!");
        }
    [HarmonyPatch(typeof(COR))]  
    [HarmonyPatch("SomeMethodName")]
  class CORPatches
  {
    static void Postfix();
  }
}}
