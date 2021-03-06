using Microsoft.Xna.Framework;
using System;
using Loot.Core.System;
using Terraria;

namespace Loot.Modifiers.WeaponModifiers
{
	public class VelocityDamage : WeaponModifier
	{
		public override ModifierTooltipLine[] TooltipLines => new[]
			{
				new ModifierTooltipLine { Text = $"Added damage based on player's velocity (multiplier: {Math.Round(Properties.RoundedPower/2, 1)}x)", Color = Color.Lime}
			};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(maxMagnitude: 2f, roundPrecision: 1);
		}

		public override void GetWeaponDamage(Item item, Player player, ref int damage)
		{
			base.GetWeaponDamage(item, player, ref damage);
			float magnitude = Properties.RoundedPower * player.velocity.Length() / 4;
			damage = (int)(damage * (1 + magnitude / 100));
		}
	}
}
