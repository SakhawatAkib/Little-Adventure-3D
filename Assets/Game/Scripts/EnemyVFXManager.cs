using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect FootSteep;
    public VisualEffect AttackVFX;

    public void PlayAttackVFX()
    {
        AttackVFX.SendEvent("OnPlay");
    }
    public void BurstFootStep()
    {
        FootSteep.SendEvent("OnPlay");
    }
}
