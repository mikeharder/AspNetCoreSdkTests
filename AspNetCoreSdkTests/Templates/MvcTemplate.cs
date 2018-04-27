﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AspNetCoreSdkTests.Templates
{
    public class MvcTemplate : RazorBaseTemplate
    {
        public override string Name => "mvc";

        protected override string RazorPath => "Views";

        public override IEnumerable<string> ExpectedObjFilesAfterBuild => Enumerable.Concat(base.ExpectedObjFilesAfterBuild, new[]
        {
            Path.Combine("Razor", RazorPath, "Home", "About.g.cshtml.cs"),
            Path.Combine("Razor", RazorPath, "Home", "Contact.g.cshtml.cs"),
            Path.Combine("Razor", RazorPath, "Home", "Index.g.cshtml.cs"),
            Path.Combine("Razor", RazorPath, "Home", "Privacy.g.cshtml.cs"),
            Path.Combine("Razor", RazorPath, "Shared", "Error.g.cshtml.cs"),
        }.Select(p => Path.Combine(OutputPath, p)));
    }
}