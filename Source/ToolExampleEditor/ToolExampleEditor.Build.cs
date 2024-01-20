// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;

public class ToolExampleEditor : ModuleRules
{
	public ToolExampleEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicIncludePaths.AddRange(
			new string[] {
					// ... add public include paths required here ...
				}
			);

		PrivateIncludePaths.AddRange(
			new string[] {
                // ... add other private include paths required here ...
            }
		);

		PCHUsage = ModuleRules.PCHUsageMode.NoSharedPCHs;
		PrivatePCHHeaderFile = "ToolExampleEditor.h";

		PublicDependencyModuleNames.AddRange(
			new string[] {
				"AnimGraph",
				"AssetTools",
				"BlueprintGraph",
				"ComponentVisualizers",
				"Core",
				"CoreUObject",
				"EditorStyle",
				"EditorWidgets",
				"Engine",
				"InputCore",
				"LevelEditor",
				"Slate",
				"ToolExample",
				"UnrealEd",
			}
		);

		if (Target.Version.MajorVersion > 4)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"EditorFramework",
				}
			);
		}

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"AppFramework",
				"KismetWidgets",
				"MainFrame",
				"PropertyEditor",
				"SlateCore",
			// ... add private dependencies that you statically link with here ...
			}
		);
	}
}
