using Content.Shared.Examine;

namespace Content.Shared._RMC14.Weapons.Ranged.Ammo;

public sealed class RMCAmmoExamineSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<RMCAmmoExamineComponent, ExaminedEvent>(OnExamined);
    }

    private void OnExamined(Entity<RMCAmmoExamineComponent> ent, ref ExaminedEvent args)
    {
        using (args.PushGroup("AmmoExamine"))
        {
            args.PushMarkup(Loc.GetString(ent.Comp.AmmoType));
        }
    }
}
