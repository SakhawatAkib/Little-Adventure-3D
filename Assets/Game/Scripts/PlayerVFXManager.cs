using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerVFXManager : MonoBehaviour
{
    public VisualEffect footSteep;

    public void Update_FootStep(bool state)
    {
        if(state)
            footSteep.Play();
        else
            footSteep.Stop();
    }
}
