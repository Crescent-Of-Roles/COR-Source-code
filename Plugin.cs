using BepInEx;
using BepInEx.IL2CPP;

namespace CORplugin
{
    [BepInPlugin("create by,olive", "CORplugin", "1,00")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo("Plugin {CrescentOfRoles} is loaded!");
        }
    }
}
