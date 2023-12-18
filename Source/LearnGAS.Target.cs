// Copyright Ali Amanzadegan

using UnrealBuildTool;
using System.Collections.Generic;

public class LearnGASTarget : TargetRules
{
	public LearnGASTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "LearnGAS" } );
	}
}
