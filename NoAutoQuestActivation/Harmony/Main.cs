namespace NoAutoQuestActivation.Harmony
{
    public class Main
    {
        public class Init : IModApi
        {
            public void InitMod(Mod modInstance)
            {
                const string id = "uk.co.rdok.7daystodie.mods.no_auto_quest_activation";

                var harmony = new HarmonyLib.Harmony(id);

                harmony.PatchAll();
            }
        }
    }
}