using UnrealBuildTool;

public class Configurateur_VestisEditorTarget : TargetRules
{
	public Configurateur_VestisEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Configurateur_Vestis");
	}
}
