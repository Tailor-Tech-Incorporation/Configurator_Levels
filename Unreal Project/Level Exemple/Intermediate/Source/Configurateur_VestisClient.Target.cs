using UnrealBuildTool;

public class Configurateur_VestisClientTarget : TargetRules
{
	public Configurateur_VestisClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Configurateur_Vestis");
	}
}
