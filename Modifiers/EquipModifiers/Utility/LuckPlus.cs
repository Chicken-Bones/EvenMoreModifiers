using Loot.Core.Attributes;
using Loot.Core.System;
using Microsoft.Xna.Framework;
using Terraria;

namespace Loot.Modifiers.EquipModifiers.Utility
{
	// Here, LuckEffect is only used as a container to store Luck per player instance
	// This is an example of an Effect with no functionality by itself
	public class LuckEffect : ModifierEffect
	{
		public float Luck;

		public override void ResetEffects(ModifierPlayer player)
		{
			Luck = 0f;
		}
	}

	[UsesEffect(typeof(LuckEffect))]
	public class LuckPlus : EquipModifier
	{
		public override ModifierTooltipLine[] TooltipLines => new[]
		{
			new ModifierTooltipLine { Text = $"+{Properties.RoundedPower} luck", Color =  Color.LimeGreen},
		};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(maxMagnitude: 2f);
		}

		public override void UpdateEquip(Item item, Player player)
		{
			ModifierPlayer.Player(player).GetEffect<LuckEffect>().Luck += (int)Properties.RoundedPower;
		}
	}
}
