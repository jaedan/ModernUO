using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0xE89, 0xE8a )]
	public class QuarterStaff : BaseStaff
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.DoubleStrike;
		public override WeaponAbility SecondaryAbility => WeaponAbility.ConcussionBlow;

		public override int AosStrengthReq => 30;
		public override int AosMinDamage => 11;
		public override int AosMaxDamage => 14;
		public override int AosSpeed => 48;
		public override float MlSpeed => 2.25f;

		public override int OldStrengthReq => 30;
		public override int OldMinDamage => 8;
		public override int OldMaxDamage => 28;
		public override int OldSpeed => 48;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 60;

		[Constructible]
		public QuarterStaff() : base( 0xE89 )
		{
			Weight = 4.0;
		}

		public QuarterStaff( Serial serial ) : base( serial )
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
