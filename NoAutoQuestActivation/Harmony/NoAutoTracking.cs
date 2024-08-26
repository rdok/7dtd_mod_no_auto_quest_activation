using HarmonyLib;

namespace NoAutoQuestActivation.Harmony
{
    [HarmonyPatch(typeof(XUiC_QuestOfferWindow), nameof(XUiC_QuestOfferWindow.btnAccept_OnPress))]
    public class NoAutoTracking
    {
        public static void Postfix(XUiC_QuestOfferWindow __instance)
        {
            __instance.Quest.Tracked = false;
            var entityPlayer = __instance.xui.playerUI.entityPlayer;
            entityPlayer.QuestJournal.TrackedQuest = null;
        }
    }
}