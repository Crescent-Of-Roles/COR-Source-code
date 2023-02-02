using HarmonyLib;
using UnityEngine;
namespace CrescentOfRoles
{
   
   
   public class CORFirstPatcher
   {
      public static unsafe void  Brash()
      {
         var Brash = new ModManager("brash");
         
      
      }}
      [HarmonyPatch (typeof(ModManager), nameof(ModManager.ShowModStamp))]

      public class Brash
      {
        public static void OnDestroy();
        public string PatchAll()
        {
         return PatchAll();
        }
      
      }
   

}