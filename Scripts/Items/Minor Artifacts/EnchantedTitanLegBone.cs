using System;
using Server;

namespace Server.Items
{
	public class EnchantedTitanLegBone : ShortSpear
	{
		public override int LabelNumber => 1063482;

		public override int InitMinHits => 255;
		public override int InitMaxHits => 255;

		[Constructible]
		public EnchantedTitanLegBone()
		{
			Hue = 0x8A5;
			WeaponAttributes.HitLowerDefend = 40;
			WeaponAttributes.HitLightning = 40;
			Attributes.AttackChance = 10;
			Attributes.WeaponDamage = 20;
			WeaponAttributes.ResistPhysicalBonus = 10;
		}

		public EnchantedTitanLegBone( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
