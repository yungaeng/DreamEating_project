// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DreamEating_project : ModuleRules
{
	public DreamEating_project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DreamEating_project",
			"DreamEating_project/Variant_Platforming",
			"DreamEating_project/Variant_Platforming/Animation",
			"DreamEating_project/Variant_Combat",
			"DreamEating_project/Variant_Combat/AI",
			"DreamEating_project/Variant_Combat/Animation",
			"DreamEating_project/Variant_Combat/Gameplay",
			"DreamEating_project/Variant_Combat/Interfaces",
			"DreamEating_project/Variant_Combat/UI",
			"DreamEating_project/Variant_SideScrolling",
			"DreamEating_project/Variant_SideScrolling/AI",
			"DreamEating_project/Variant_SideScrolling/Gameplay",
			"DreamEating_project/Variant_SideScrolling/Interfaces",
			"DreamEating_project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
