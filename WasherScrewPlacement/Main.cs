using MelonLoader;
using HarmonyLib;
using Protobot;
using System.Collections.Generic;

namespace WasherScrewPlacement
{
    public static class BuildInfo
    {
        public const string Name = "WasherScrewPlacement"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Lets you put washers (How was this not already a thing?)"; // Description for the Mod.  (Set as null if none)
        public const string Author = "InvertedOwl"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.0.1"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class WasherScrewPlacement : MelonMod
    {

        [HarmonyPatch(typeof(StandoffPlaceDisplacement), "IsIdAllowed")]
        class AllowWashers
        {
            [HarmonyPrefix]
            internal static bool Prefix(PlacementData placementData, ref List<string> ___AllowedIds, ref bool __result) 
            {
                for (int i = 0; i < ___AllowedIds.Count; i++)
                {
                    if (placementData.objectId.Contains(___AllowedIds[i]) || placementData.objectId.Contains("WSHR"))
                    {
                        __result = true;
                        return false;
                    }
                    if (placementData.objectId.Contains(___AllowedIds[i]) || placementData.objectId.Contains("CLMP"))
                    {
                        __result = true;
                        return false;
                    }
                }
                __result = false;
                return false;

            }
        }

    }
}