using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SpikySpamShellExtension
{
    internal static class ExtEnum
    {
        internal static void BindEnumToCombobox<T>(this DataGridViewComboBoxColumn comboBox)
        {

            var list = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(value => new
                {
                    Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(),
                    Value = value
                })
                .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = Constants.Description;
            comboBox.ValueMember = Constants.Value;

        }

        internal static T GetResourceLookup<T>(Type resourceType, string resourceName)
        {
            if ((resourceType != null) && (resourceName != null))
            {
                PropertyInfo property = resourceType.GetProperty(resourceName, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
                if (property == null)
                {
                    return default;
                }
                return (T)property.GetValue(null, null);
            }

            return default;
        }
    }
}
