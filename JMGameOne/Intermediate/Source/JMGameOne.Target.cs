using UnrealBuildTool;

public class JMGameOneTarget : TargetRules
{
	public JMGameOneTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("JMGameOne");
	}
}
