﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace AspNetCoreSdkTests
{
    // https://docs.microsoft.com/en-us/dotnet/core/rid-catalog
    public class RuntimeIdentifier
    {
        public static RuntimeIdentifier None = new RuntimeIdentifier() {
            Name = "none",
            OSPlatforms = new[] { OSPlatform.Linux, OSPlatform.OSX, OSPlatform.Windows, },
        };

        public static RuntimeIdentifier Win_x64 = new RuntimeIdentifier() {
            Name = "win-x64",
            OSPlatforms = new[] { OSPlatform.Windows, },
        };

        public static RuntimeIdentifier Linux_x64 = new RuntimeIdentifier() {
            Name = "linux-x64",
            OSPlatforms = new[] { OSPlatform.Linux, },
        };

        private RuntimeIdentifier() { }

        public string Name { get; private set; }
        public string RuntimeArgument => (this == None) ? string.Empty : $"--runtime {Name}";
        public string Path => (this == None) ? string.Empty : Name;
        public IEnumerable<OSPlatform> OSPlatforms { get; private set; }

        public override string ToString() => Name;
    }
}