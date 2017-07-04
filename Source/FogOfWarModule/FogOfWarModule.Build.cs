using UnrealBuildTool;

public class FogOfWarModule : ModuleRules
{
    public FogOfWarModule(ReadOnlyTargetRules Target) : base(Target)
    {
        PublicDependencyModuleNames.AddRange(new string[]
            { "Core",
              "CoreUObject",
              "Engine",
              "InputCore",
              "RHI",
              "RenderCore"
            });
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
    }
}