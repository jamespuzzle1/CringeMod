using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace CringeMod.NPCs
{
    public class AnnoyingOrange : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Annoying Orange");

        }
        private int beeTimer = 0;
        private int beeType;
        public override void SetDefaults()
        {
            npc.width = 200;
            npc.height = 200;
            npc.aiStyle = 1;
            aiType = 1;

            npc.npcSlots = 5;

            npc.lifeMax = 1000;
            npc.damage = 0;
            npc.defense = 0;
            npc.knockBackResist = 0f;

            npc.value = Item.buyPrice(gold: 15);

            npc.lavaImmune = false;
            npc.noTileCollide = false;
            npc.noGravity = false;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/AnnoyingOrangeTheme");
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
        }
        public override void AI()
        {
            beeTimer++;
            if (beeTimer >= 300)
            {
                beeTimer = 0;
                beeType = Main.rand.Next(10);
                {
                    if (beeType == 0)
                    {
                        Main.NewText("Hey, its annoying orange!", 255, 170, 0);
                      
                    }
                    if (beeType == 1)
                    {
                        Main.NewText("Have you seen Lemon? Hes such a sour puss!", 255, 170, 0);
                    }
                    if (beeType == 2)
                    {
                        Main.NewText("I used to be a banker, but I lost interest.", 255, 170, 0);
                    }
                    if (beeType == 3)
                    {
                        Main.NewText("I relish the fact that you've mustard enough strength to ketchup to me.", 255, 170, 0);
                    }
                    if (beeType == 4)
                    {
                        Main.NewText("hey WASSSAABIIII", 255, 170, 0);
                    }
                    if (beeType == 5)
                    {
                        Main.NewText("i am an orange", 255, 170, 0);
                    }
                    if (beeType == 6)
                    {
                        Main.NewText("To the guy who invented zero, thanks for nothing", 255, 170, 0);
                    }
                    if (beeType == 7)
                    {
                        Main.NewText("I had a crazy dream last night. I was swimming in an ocean of orange soda. Turns out it was just a Fanta sea..", 255, 170, 0);
                    }
                    if (beeType == 8)
                    {
                        Main.NewText("Ladies, if he can’t appreciate your fruit jokes, you need to let that mango.", 255, 170, 0);
                    }
                    if (beeType == 9)
                    {
                        Main.NewText("I would tell you an unemployment joke, but none of them work..", 255, 170, 0);
                    }

                }
            }
        }
        
    }
}
