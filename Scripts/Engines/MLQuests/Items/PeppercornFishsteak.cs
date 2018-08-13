using System;
using Server;

namespace Server.Items
{
	public class PeppercornFishsteak : FishSteak
	{
		public override int LabelNumber => 1075557; // peppercorn fishsteak

		[Constructible]
		public PeppercornFishsteak()
		{
			Hue = 0x222;
		}

		public PeppercornFishsteak( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
