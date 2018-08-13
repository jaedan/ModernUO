﻿using System;
using Server;

namespace Server.Items
{
	/*
	first seen halloween 2009.  subsequently in 2010,
	2011 and 2012. GM Beggar-only Semi-Rare Treats
	*/

	public class SkullsOnPike : Item
	{
		public override double DefaultWeight => 1;

		[Constructible]
		public SkullsOnPike()
			: base( 0x42B5 )
		{
		}

		public SkullsOnPike( Serial serial )
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
