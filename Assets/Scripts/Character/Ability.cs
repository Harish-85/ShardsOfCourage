using System;
using Unity.VisualScripting;

namespace ShardsOfCourage.Character
{
    
    [Serializable]
    public class Ability
    {
        public string id;
        public bool obtained;
        
        public Ability(string id)
        {
            this.id = id;
            obtained = false;
        }
        
    }
}
