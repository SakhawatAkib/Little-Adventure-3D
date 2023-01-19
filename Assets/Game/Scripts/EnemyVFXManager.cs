using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect FootSteep;
    public VisualEffect AttackVFX;
    public ParticleSystem BeingHitVFX;

    public void PlayAttackVFX()
    {
        AttackVFX.SendEvent("OnPlay");
    }
    public void BurstFootStep()
    {
        FootSteep.SendEvent("OnPlay");
    }

    public void PlayBeingHitVFX(Vector3 attackerPos)
    {
        Vector3 forceForward = transform.position - attackerPos;
        forceForward.Normalize();
        forceForward.y = 0;
        BeingHitVFX.transform.rotation = Quaternion.LookRotation(forceForward);
        BeingHitVFX.Play();
    }
}
