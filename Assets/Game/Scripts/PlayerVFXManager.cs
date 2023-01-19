using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerVFXManager : MonoBehaviour
{
    public VisualEffect footSteep;
    public ParticleSystem Blade01;
    public VisualEffect Slash;

    public void Update_FootStep(bool state)
    {
        if(state)
            footSteep.Play();
        else
            footSteep.Stop();
    }

    public void PlayBlade01()
    {
        Blade01.Play();
    }

    public void PlaySlash(Vector3 pos)
    {
        Slash.transform.position = pos;
        Slash.Play();
    }
}
