using Loot.Core;
using Loot.Core.System;
using Microsoft.Xna.Framework;

namespace Loot.Rarities
{
	public class LegendaryRarity : ModifierRarity
	{
		public override string Name => "Legendary";
		public override Color Color => Color.Red;
		//public override Color? OverrideNameColor => Color;
		//public override string ItemPrefix => "Legendary";
		public override float RequiredRarityLevel => 4f;
	}
}
