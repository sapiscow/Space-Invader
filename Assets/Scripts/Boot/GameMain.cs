using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Audios;
using System.Collections;

namespace Sapi.SpaceInvader.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new AudioController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}