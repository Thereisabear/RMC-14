using Robust.Shared.Prototypes;

namespace Content.Shared._RMC14.Medical.Surgery.Steps;

[RegisterComponent]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class SurgeryToolMultipliersComponent : Component
{
    [DataField]
    public List<SurgeryToolMultiplier> Multipliers = new();
}

[DataDefinition]
public partial struct SurgeryToolMultiplier
{
    [DataField(required: true)]
    public ComponentRegistry Tool;

    [DataField]
    public float Multiplier = 1f;
}
