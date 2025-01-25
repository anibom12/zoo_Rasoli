using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class SpecialFeatures
{
    private bool CanFly;
    private bool IsVenomous;
    private bool CanSwim;
    private bool CanClimbTrees;
    private bool CanRunFast;
    private bool ProducesSpecialSounds;


    public bool canFly { get { return CanFly; } set { CanFly = value; } }
    public bool isVenomous { get { return IsVenomous; } set { IsVenomous = value; } }

    public bool canSwim { get { return CanSwim; } set { CanSwim = value; } }
    public bool canClimbTrees { get { return CanClimbTrees; } set { CanClimbTrees = value; } }
    public bool canRunFast { get { return CanRunFast; } set { CanRunFast = value; } }
    public bool producesSpecialSounds { get { return ProducesSpecialSounds; } set { ProducesSpecialSounds = value; } }


    public SpecialFeatures(bool canFly, bool isVenomous, bool canSwim, bool canClimbTrees, bool canRunFast, bool producesSpecialSounds)
    {
        CanFly = canFly;
        IsVenomous = isVenomous;
        CanSwim = canSwim;
        CanClimbTrees = canClimbTrees;
        CanRunFast = canRunFast;
        ProducesSpecialSounds = producesSpecialSounds;
    }
    public override string ToString()
    {
        return $"Can Fly: {canFly}, Is Venomous: {isVenomous}, Can Swim: {canSwim}, Can Climb Trees: {canClimbTrees}, Can Run Fast: {canRunFast}, Produces Special Sounds: {producesSpecialSounds}";
    }
}

