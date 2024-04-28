using UnrealBuildTool;

public class KayakFinishedServerTarget : TargetRules
{
	public KayakFinishedServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("KayakFinished");
	}
}
