using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AfterDarkSettings.Modules.Ext
{
    public class ModuleSetting
    {
        /// <summary>
        /// Gets the module setting's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the module setting's data type.
        /// </summary>
        public RegistryValueKind DataType { get; set; }

        /// <summary>
        /// Gets the module setting's value.
        /// </summary>
        public object Value { get; set; }
    }
}
