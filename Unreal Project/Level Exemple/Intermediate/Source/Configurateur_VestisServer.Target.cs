using UnrealBuildTool;

public class Configurateur_VestisServerTarget : TargetRules
{
	public Configurateur_VestisServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Configurateur_Vestis");
	}
}
