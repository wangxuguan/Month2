using Volo.Abp.Settings;

namespace Month2.Settings
{
    public class Month2SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Month2Settings.MySetting1));
        }
    }
}
