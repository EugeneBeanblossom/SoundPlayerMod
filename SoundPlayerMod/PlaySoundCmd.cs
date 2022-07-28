using Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundPlayerMod
{
    public class PlaySoundCmd : ConsoleCmdAbstract
    {
        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            if (_params.Count > 1)
            {
                SingletonMonoBehaviour<SdtdConsole>.Instance.Output("Too many arguments given.");
            }
            else if (_params.Count == 0 || string.IsNullOrWhiteSpace(_params[0]))
            {
                SingletonMonoBehaviour<SdtdConsole>.Instance.Output("No sound name given.");
            } 
            else
            {
                PlaySound(_params[0]);
            }
        }

        private void PlaySound(string name)
        {

            Manager.PlayInsidePlayerHead(name);
        }

        public override string[] GetCommands() => new string[1] { "playsound" };

        public override string GetDescription() => "Plays a sound";

        public override string GetHelp() => "Plays the sound locally.\nUsage:\n   playsound sound_name";
    }
}
