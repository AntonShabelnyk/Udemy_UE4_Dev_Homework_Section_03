// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class S03_Building_EscapeEditorTarget : TargetRules
{
	public S03_Building_EscapeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "S03_Building_Escape" } );
	}
}
