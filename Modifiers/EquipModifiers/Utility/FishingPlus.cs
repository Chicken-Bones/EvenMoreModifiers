using Loot.Core.System;
using Microsoft.Xna.Framework;
using Terraria;

namespace Loot.Modifiers.EquipModifiers.Utility
{
	public class FishingPlus : EquipModifier
	{
		public override ModifierTooltipLine[] TooltipLines => new[]
		{
			new ModifierTooltipLine { Text = $"+{Properties.RoundedPower} fishing skill [WIP]", Color =  Color.LimeGreen},
		};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(maxMagnitude: 2f);
		}

		public override void UpdateEquip(Item item, Player player)
		{
			player.fishingSkill += (int)Properties.RoundedPower;
		}
	}
}
