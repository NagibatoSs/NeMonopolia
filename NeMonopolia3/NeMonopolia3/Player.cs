using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeMonopolia3
{
    [Serializable]
    public class Player
    {
        
        public int idPlayer { get; set; }

        public virtual List<Pers> Persons { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string Login { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        public string Phone { get; set; }

        public bool isBanned { get; set; }
    }
}

