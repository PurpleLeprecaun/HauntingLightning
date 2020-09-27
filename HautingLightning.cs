using BepInEx;
using RoR2;

namespace PurpleLeprecaun
{
    public class HauntingLightning
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
