using CounterStrikeSharp.API.Core;

namespace MetaCommandBlocker
{
    public class Plugin : BasePlugin
    {
        public Plugin()
        {

        }

        public override string ModuleName => "MetaCommandBlocker";
        public override string ModuleVersion => "0.0.1";
        public override string ModuleAuthor => "abnerfs";
        public override string ModuleDescription => "Blocks meta command for users";

        public override void Load(bool hotReload)
        {
            base.Load(hotReload);
            AddCommandListener("meta", (player, _info) =>
            {
                if (player is null)
                    return HookResult.Continue;

                return HookResult.Stop;
            });
        }
    }
}
