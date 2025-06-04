using System;
using System.Collections.Generic;
using System.Text;

namespace AstralCheatMenu.Mods
{
    internal class TestMod
    {
        public static void TestSpeedMod ()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
    }
}
