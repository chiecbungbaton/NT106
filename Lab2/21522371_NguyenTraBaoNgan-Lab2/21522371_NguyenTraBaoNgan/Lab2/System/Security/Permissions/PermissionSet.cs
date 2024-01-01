namespace System.Security.Permissions
{
    internal class PermissionSet
    {
        private PermissionState none;

        public PermissionSet(PermissionState none)
        {
            this.none = none;
        }

        internal void AddPermission(FileIOPermission writePermission)
        {
            throw new NotImplementedException();
        }
    }
}