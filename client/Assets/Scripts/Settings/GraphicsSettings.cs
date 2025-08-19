using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Settings
{
    public enum AntiAliasing
    {
        NO_ANTI_ALIASING=0, FAST_ANTI_ALIASING=1, FULL_ANTI_ALIASING=2
    }

    [System.Serializable]
    public class GraphicsSettings
    {
        public AntiAliasing antiAliasing;
    }
}
