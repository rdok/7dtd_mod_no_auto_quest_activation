using HarmonyLib;

namespace NoAutoQuestActivation.Harmony
{
    [HarmonyPatch(typeof(Quest), nameof(Quest.StartQuest))]
    public class NoNotification
    {
        public static void Prefix(Quest __instance, ref bool newQuest, ref bool notify)
        {
            if (!newQuest) return;

            notify = false;
        }
    }
}