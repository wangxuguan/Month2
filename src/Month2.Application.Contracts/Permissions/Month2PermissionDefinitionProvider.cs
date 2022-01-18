using Month2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Month2.Permissions
{
    public class Month2PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Month2Permissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Month2Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Month2Resource>(name);
        }
    }
}
