using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	[FlippableAttribute( 0xF43, 0xF44 )]
	public class Hatchet : BaseAxe
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.ArmorIgnore;
		public override WeaponAbility SecondaryAbility => WeaponAbility.Disarm;

		public override int AosStrengthReq => 20;
		public override int AosMinDamage => 13;
		public override int AosMaxDamage => 15;
		public override int AosSpeed => 41;
		public override float MlSpeed => 2.75f;

		public override int OldStrengthReq => 15;
		public override int OldMinDamage => 2;
		public override int OldMaxDamage => 17;
		public override int OldSpeed => 40;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 80;

		[Constructible]
		public Hatchet() : base( 0xF43 )
		{
			Weight = 4.0;
		}

		public Hatchet( Serial serial ) : base( serial )
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
