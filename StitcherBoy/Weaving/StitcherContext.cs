﻿// Stitcher Boy - a small library to help building post-build taks
// https://github.com/picrap/StitcherBoy
// MIT License - http://opensource.org/licenses/MIT

namespace StitcherBoy.Weaving
{
    using System;
    using dnlib.DotNet;
    using Project;

    /// <summary>
    /// Arguments to stitcher
    /// </summary>
    public class StitcherContext
    {
        /// <summary>
        /// Gets or sets the module.
        /// </summary>
        /// <value>
        /// The module.
        /// </value>
        public ModuleDefMD Module { get; set; }
        /// <summary>
        /// Gets or sets the assembly path.
        /// </summary>
        /// <value>
        /// The assembly path.
        /// </value>
        public string AssemblyPath { get; set; }
        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        /// <value>
        /// The project.
        /// </value>
        public ProjectDefinition Project { get; set; }
        /// <summary>
        /// Gets or sets the project path.
        /// </summary>
        /// <value>
        /// The project path.
        /// </value>
        public string ProjectPath { get; set; }
        /// <summary>
        /// Gets or sets the solution path.
        /// </summary>
        /// <value>
        /// The solution path.
        /// </value>
        public string SolutionPath { get; set; }
        /// <summary>
        /// Gets or sets the build identifier.
        /// </summary>
        /// <value>
        /// The build identifier.
        /// </value>
        public Guid BuildID { get; set; }
        /// <summary>
        /// Gets or sets the build date.
        /// </summary>
        /// <value>
        /// The build date.
        /// </value>
        public DateTime BuildTime { get; set; }
    }
}
