using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
    [Serializable]
    public class Stop
	{
        
        
            public int idStop { get; set; }

            public virtual List<Factory> factory { get; set; }
            
            public string TItle { get; set; }

            public double? Latitude { get; set; }

            public double? Longitude { get; set; }

            public int? chMoney { get; set; }

            public int? chIntellect { get; set; }

            public int? chHonesty { get; set; }

            public int? chCommunication { get; set; }

            public int? chLuck { get; set; }
    }
}

