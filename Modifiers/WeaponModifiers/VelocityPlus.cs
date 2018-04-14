﻿using Loot.System;
using Microsoft.Xna.Framework;
using Terraria;

namespace Loot.Modifiers.WeaponModifiers
{
	public class VelocityPlus : WeaponModifier
	{
		public override ModifierTooltipLine[] Description => new[]
			{
				new ModifierTooltipLine { Text = $"+{Properties.RoundedPower}% velocity", Color = Color.Lime}
			};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(maxMagnitude: 20f);
		}

		public override bool CanRoll(ModifierContext ctx)
			=> base.CanRoll(ctx) && ctx.Item.shoot > 0 && ctx.Item.shootSpeed > 0;

		public override void Apply(Item item)
		{
			base.Apply(item);
			item.shootSpeed *= Properties.RoundedPower / 100 + 1;
		}
	}
}
