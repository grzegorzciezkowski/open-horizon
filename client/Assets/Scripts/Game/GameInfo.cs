using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Game
{
    [Serializable]
    public class SinglePlayerGameInfo
    {
        public const int GENDER_MALE = 0;
        public const int GENDER_FEMALE = 1;
        public const int GENDER_OTHER = 2;

        public string Name;
        public int Gender;
    }
}
