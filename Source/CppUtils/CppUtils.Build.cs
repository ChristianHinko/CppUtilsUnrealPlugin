// Copyright (c) 2023-2024 Christian Hinkle, Brian Hinkle.

using System.IO;
using UnrealBuildTool;

public class CppUtils : ModuleRules
{
    public CppUtils(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.NoPCHs;

        // Core is required for module functionality.
        PublicDependencyModuleNames.Add("Core");

        // Configure include paths. We make sure that these behave the same as the CMake setup.
        {
            string cppUtilsLibrarySourcePath = Path.Combine(ModuleDirectory, "CppUtils", "Source");

            PrivateIncludePaths.Add(Path.Combine(cppUtilsLibrarySourcePath, "Public"));
            PublicIncludePaths.Add(Path.Combine(cppUtilsLibrarySourcePath, "Public"));

            PrivateIncludePaths.Add(cppUtilsLibrarySourcePath);
        }
    }
}
