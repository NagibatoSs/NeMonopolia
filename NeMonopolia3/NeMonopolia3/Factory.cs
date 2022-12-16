using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
    [Serializable]
    public class Factory
    {


        public int idFactory { get; set; }

        public int? idStop { get; set; }
        public virtual Stop Stop { get; set; }

        public virtual List<Rate> Rates { get; set; }

        public virtual List<Hold> Holds { get; set; }


        public string Title { get; set; }


        public string Image { get; set; }

        public int? BasePrice { get; set; }


    }

}