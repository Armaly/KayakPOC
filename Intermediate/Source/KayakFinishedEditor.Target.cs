using UnrealBuildTool;

public class KayakFinishedEditorTarget : TargetRules
{
	public KayakFinishedEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("KayakFinished");
	}
}
