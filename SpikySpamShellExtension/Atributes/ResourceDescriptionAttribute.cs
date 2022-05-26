using System;
using System.ComponentModel;

namespace SpikySpamShellExtension
{
    internal class ResourceDescriptionAttribute : DescriptionAttribute
    {

        internal ResourceDescriptionAttribute(Type resourceType, string resourceName)
        {
            DescriptionValue = ExtEnum.GetResourceLookup<string>(resourceType, resourceName);
        }

    }

}
