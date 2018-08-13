using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0x27A8, 0x27F3 )]
	public class Bokuto : BaseSword
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.Feint;
		public override WeaponAbility SecondaryAbility => WeaponAbility.NerveStrike;

		public override int AosStrengthReq => 20;
		public override int AosMinDamage => 9;
		public override int AosMaxDamage => 11;
		public override int AosSpeed => 53;
		public override float MlSpeed => 2.00f;

		public override int OldStrengthReq => 20;
		public override int OldMinDamage => 9;
		public override int OldMaxDamage => 11;
		public override int OldSpeed => 53;

		public override int DefHitSound => 0x536;
		public override int DefMissSound => 0x23A;

		public override int InitMinHits => 25;
		public override int InitMaxHits => 50;

		[Constructible]
		public Bokuto() : base( 0x27A8 )
		{
			Weight = 7.0;
		}

		public Bokuto( Serial serial ) : base( serial )
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
