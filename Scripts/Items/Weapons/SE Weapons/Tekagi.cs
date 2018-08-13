using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlippableAttribute( 0x27Ab, 0x27F6 )]
	public class Tekagi : BaseKnife
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.DualWield;
		public override WeaponAbility SecondaryAbility => WeaponAbility.TalonStrike;

		public override int AosStrengthReq => 10;
		public override int AosMinDamage => 10;
		public override int AosMaxDamage => 12;
		public override int AosSpeed => 53;
		public override float MlSpeed => 2.00f;

		public override int OldStrengthReq => 10;
		public override int OldMinDamage => 10;
		public override int OldMaxDamage => 12;
		public override int OldSpeed => 53;

		public override int DefHitSound => 0x238;
		public override int DefMissSound => 0x232;

		public override int InitMinHits => 35;
		public override int InitMaxHits => 60;

		public override SkillName DefSkill => SkillName.Fencing;
		public override WeaponType DefType => WeaponType.Piercing;
		public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce1H;

		[Constructible]
		public Tekagi() : base( 0x27AB )
		{
			Weight = 5.0;
			Layer = Layer.TwoHanded;
		}

		public Tekagi( Serial serial ) : base( serial )
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
