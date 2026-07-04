using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Medical.Surgery.Tools.Improvised;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class RMCSurgeryWirecutterComponent : Component, ICMSurgeryToolComponent
{
    public string ToolName => "a pair of wirecutters";
}
