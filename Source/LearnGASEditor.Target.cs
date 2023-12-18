// Copyright Ali Amanzadegan

using UnrealBuildTool;
using System.Collections.Generic;

public class LearnGASEditorTarget : TargetRules
{
	public LearnGASEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "LearnGAS" } );
	}
}
