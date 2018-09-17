// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TPS_NorthernWoodsTarget : TargetRules
{
	public TPS_NorthernWoodsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TPS_NorthernWoods");
	}
}
