using System;

namespace LegalityChecker
{
	public class KorHGSSPPData : HGSSPPData
	{
		private static readonly string m_Slot1 = "00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00";
		private static readonly string m_Slot2 = "00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00";

		public KorHGSSPPData( PokemonData pkm ) : base( pkm )
		{
			GetTrashByteEntry( m_Slot1, m_Slot2 );
		}
	}
}