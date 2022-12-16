using System;
namespace NeMonopolia3
{
	public class Hold
	{
        
        public int idHold { get; set; }

        public int? idPers { get; set; }

        public virtual Pers Pers { get; set; }

        public virtual Factory Factory { get; set; }

        public int? idFactory { get; set; }

        public int? Level { get; set; }

        public int? Security { get; set; }

        public int? CurrentPrice { get; set; }
    }
}

