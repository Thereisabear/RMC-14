using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Weapons.Ranged.Ammo;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(RMCAmmoExamineSystem))]
public sealed partial class RMCAmmoExamineComponent : Component
{
    [DataField(required: true), AutoNetworkedField]
    public LocId AmmoType;
}
