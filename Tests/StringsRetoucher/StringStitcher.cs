﻿namespace StringsRetoucher
{
    using System;
    using dnlib.DotNet;
    using StitcherBoy.Project;
    using StitcherBoy.Weaving;

    public class StringStitcher: SingleStitcher
    {
        protected override bool Process(ModuleDefMD moduleDef, string assemblyPath, ProjectDefinition project, string projectPath, string solutionPath)
        {
            var a = AppDomain.CurrentDomain;
            var n = a.FriendlyName;
            return false;
        }
    }
}