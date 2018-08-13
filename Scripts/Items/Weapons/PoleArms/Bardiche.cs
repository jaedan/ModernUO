using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0xF4D, 0xF4E )]
	public class Bardiche : BasePoleArm
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.ParalyzingBlow;
		public override WeaponAbility SecondaryAbility => WeaponAbility.Dismount;

		public override int AosStrengthReq => 45;
		public override int AosMinDamage => 17;
		public override int AosMaxDamage => 18;
		public override int AosSpeed => 28;
		public override float MlSpeed => 3.75f;

		public override int OldStrengthReq => 40;
		public override int OldMinDamage => 5;
		public override int OldMaxDamage => 43;
		public override int OldSpeed => 26;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 100;

		[Constructible]
		public Bardiche() : base( 0xF4D )
		{
			Weight = 7.0;
		}

		public Bardiche( Serial serial ) : base( serial )
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
