using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
	public class Game
	{
        public int idGame { get; set; }

        public int? Number { get; set; }

        
        public string Title { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinish { get; set; }
        public bool isActive { get; set; }

        public virtual List<Pers> Pers { get; set; }

    }
}

