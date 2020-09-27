using BepInEx;
using RoR2;

namespace PurpleLeprecaun
{

    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.thatsSickLOL.HauntingLightning", "Haunting Lightning", "1.0.0")]
    public class HauntingLightning : BaseUnityPlugin
    {
        public void Awake()
        {
            On.EntityStates.FrozenState.OnEnter += (orig, self) =>
            {
                Chat.AddMessage("[Lightning Mcqueen]: I fucked your mom shitlips");

                orig(self);
            };
        }
    }
}
