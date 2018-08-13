using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class WindSpirit : Item
	{
		public override int LabelNumber => 1094925; // Wind Spirit [Replica]

		[Constructible]
		public WindSpirit() : base( 0x1F1F )
		{
		}

		public WindSpirit( Serial serial ) : base( serial )
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
