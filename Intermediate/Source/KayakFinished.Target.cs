using UnrealBuildTool;

public class KayakFinishedTarget : TargetRules
{
	public KayakFinishedTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("KayakFinished");
	}
}
