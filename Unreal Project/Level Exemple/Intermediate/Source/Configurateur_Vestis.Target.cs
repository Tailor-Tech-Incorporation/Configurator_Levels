using UnrealBuildTool;

public class Configurateur_VestisTarget : TargetRules
{
	public Configurateur_VestisTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Configurateur_Vestis");
	}
}
