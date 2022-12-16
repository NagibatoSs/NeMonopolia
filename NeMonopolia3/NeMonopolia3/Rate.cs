using System;
namespace NeMonopolia3
{
    [Serializable]
    public class Rate
	{
        
       
            public int idRate { get; set; }

            public int? idFactory { get; set; }

            public virtual Factory Factory { get; set; }

            public int? Level { get; set; }

            
            public string Subtitle { get; set; }

            public int? UpgradePrice { get; set; }

            public int? Rent { get; set; }

            public int? Security { get; set; }
        
    }

}

