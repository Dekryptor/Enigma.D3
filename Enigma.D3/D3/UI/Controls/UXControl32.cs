using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl32 : UXLabel
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC88;
		public const int VTable = 0x017C2C58;

		public UXControl32(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xC78_Neg1 { get { return Field<int>(0xC78); } }
		public int xC7C { get { return Field<int>(0xC7C); } }
		public int xC80 { get { return Field<int>(0xC80); } }
		public int xC84 { get { return Field<int>(0xC84); } }
	}
}
