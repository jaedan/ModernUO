using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0x26BF, 0x26C9 )]
	public class DoubleBladedStaff : BaseSpear
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.DoubleStrike;
		public override WeaponAbility SecondaryAbility => WeaponAbility.InfectiousStrike;

		public override int AosStrengthReq => 50;
		public override int AosMinDamage => 12;
		public override int AosMaxDamage => 13;
		public override int AosSpeed => 49;
		public override float MlSpeed => 2.25f;

		public override int OldStrengthReq => 50;
		public override int OldMinDamage => 12;
		public override int OldMaxDamage => 13;
		public override int OldSpeed => 49;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 80;

		[Constructible]
		public DoubleBladedStaff() : base( 0x26BF )
		{
			Weight = 2.0;
		}

		public DoubleBladedStaff( Serial serial ) : base( serial )
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
