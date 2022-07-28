using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundPlayerMod
{
    public class SoundPlayerMod : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            Log.Out("*** SoundPlayerMod Loaded ***");
        }
    }
}
