using UnrealBuildTool;

public class KayakFinishedClientTarget : TargetRules
{
	public KayakFinishedClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("KayakFinished");
	}
}
