﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AspNetCoreSdkTests.Templates
{
    public class ClassLibraryTemplate : Template
    {
        public virtual string OutputPath { get; } = Path.Combine("Debug", "netstandard2.0");

        public override string Name => "classlib";

        public override TemplateType Type => TemplateType.ClassLibrary;

        public override IEnumerable<string> ExpectedObjFilesAfterBuild => Enumerable.Concat(base.ExpectedObjFilesAfterBuild, new[]
        {
            $"{Name}.AssemblyInfo.cs",
            $"{Name}.AssemblyInfoInputs.cache",
            $"{Name}.assets.cache",
            $"{Name}.csproj.CoreCompileInputs.cache",
            $"{Name}.csproj.FileListAbsolute.txt",
            $"{Name}.csprojAssemblyReference.cache",
            $"{Name}.dll",
            $"{Name}.pdb",
        }.Select(p => Path.Combine(OutputPath, p)));

        public override IEnumerable<string> ExpectedBinFilesAfterBuild => new[]
        {
            $"{Name}.deps.json",
            $"{Name}.dll",
            $"{Name}.pdb",
        }.Select(p => Path.Combine(OutputPath, p));
    }
}