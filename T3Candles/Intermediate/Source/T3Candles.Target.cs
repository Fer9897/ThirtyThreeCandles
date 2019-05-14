using UnrealBuildTool;

public class T3CandlesTarget : TargetRules
{
	public T3CandlesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("T3Candles");
	}
}
