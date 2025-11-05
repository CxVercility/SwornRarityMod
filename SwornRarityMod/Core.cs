using Il2Cpp;
using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(SwornRarityMod.Core), "SwornRarityMod", "1.0.0", "Vercility", null)]
[assembly: MelonGame("Windwalk Games", "SWORN")]

namespace SwornRarityMod
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}
[HarmonyPatch(typeof(BlessingGenerator), "GenerateBlessings")]
class Patch
{
    private static Boolean hasRun = false;
    static void Prefix(BlessingGenerator __instance)
    {
        if (!hasRun)
        {
            __instance.legendaryBlessingBaseChance = 0.03f;
            __instance.epicBlessingBaseChance = 0.08f;
            __instance.rareBlessingBaseChance = 0.20f;
            __instance.uncommonBlessingBaseChance = 0.25f;
        }
        
    }
}