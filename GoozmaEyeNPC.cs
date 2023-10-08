using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace EyeModOfGoozma
{
    public class GoozmaEyeNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public override void OnKill(NPC npc)
        {
            if (npc.type == ModContent.NPCType<CalamityHunt.Content.Bosses.Goozma.Goozma>())
            {
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                    Vector2 speed = new Vector2(0, 4);
                    Projectile.NewProjectile(npc.GetSource_FromAI(), npc.Center, speed, ModContent.ProjectileType<GoozmaEye>(), 0, 0f, Main.myPlayer);
            }
            }
        }
    }
}
