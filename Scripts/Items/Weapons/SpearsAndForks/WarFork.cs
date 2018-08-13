using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0x1405, 0x1404 )]
	public class WarFork : BaseSpear
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.BleedAttack;
		public override WeaponAbility SecondaryAbility => WeaponAbility.Disarm;

		public override int AosStrengthReq => 45;
		public override int AosMinDamage => 12;
		public override int AosMaxDamage => 13;
		public override int AosSpeed => 43;
		public override float MlSpeed => 2.50f;

		public override int OldStrengthReq => 35;
		public override int OldMinDamage => 4;
		public override int OldMaxDamage => 32;
		public override int OldSpeed => 45;

		public override int DefHitSound => 0x236;
		public override int DefMissSound => 0x238;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 110;

		public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce1H;

		[Constructible]
		public WarFork() : base( 0x1405 )
		{
			Weight = 9.0;
		}

		public WarFork( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
