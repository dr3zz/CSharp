namespace GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute(string version)
        {
            this.version = version;
        }

        public override string ToString()
        {
            string ret = "Version: " + this.version;
            return ret;
        }
    }
}