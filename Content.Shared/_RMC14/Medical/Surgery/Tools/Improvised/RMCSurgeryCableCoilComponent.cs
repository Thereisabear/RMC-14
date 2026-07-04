using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Medical.Surgery.Tools.Improvised;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class RMCSurgeryCableCoilComponent : Component, ICMSurgeryToolComponent
{
    public string ToolName => "a cable coil";
}
