using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
	public class Team
	{
		public Team()
		{
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual List<PlayerInfo> Players { get; set; }
		public virtual List<PlayerCharacteristic> PlayerCharacteristics { get; set; }

	}
}

