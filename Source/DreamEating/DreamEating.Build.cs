// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DreamEating : ModuleRules
{
	public DreamEating(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DreamEating",
			"DreamEating/Variant_Strategy",
			"DreamEating/Variant_Strategy/UI",
			"DreamEating/Variant_TwinStick",
			"DreamEating/Variant_TwinStick/AI",
			"DreamEating/Variant_TwinStick/Gameplay",
			"DreamEating/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
