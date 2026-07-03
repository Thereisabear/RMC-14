using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Medical.Surgery;

[RegisterComponent, NetworkedComponent]
public sealed partial class RMCSurgerySurfaceComponent : Component
{
    public const float FloorDelayMultiplier = 2f;

    // Applies when buckled.
    [DataField]
    public float DelayMultiplier = 1f;
}
