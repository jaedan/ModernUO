﻿using System;
using Server;

namespace Server.Items
{
	public class NougatSwirl : CandyCane
	{
		public override int LabelNumber => 1096936; /* nougat swirl */

		[Constructible]
		public NougatSwirl() : this(1)
		{

		}

		[Constructible]
		public NougatSwirl( int amount )
			: base( 0x4690 )
		{
			Stackable = true;
		}

		public NougatSwirl( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( ( int )0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
