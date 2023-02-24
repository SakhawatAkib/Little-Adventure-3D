using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerVFXManager : MonoBehaviour
{
    public VisualEffect footSteep;
    public ParticleSystem Blade01;
    public ParticleSystem Blade02;
    public ParticleSystem Blade03;
    public VisualEffect Slash;
    public VisualEffect Heal;
    
    public AudioSource audioSource;
    public AudioClip sword1;
    public AudioClip sword2;
    public AudioClip sword3;
    public AudioClip walking;

    public void Update_FootStep(bool state)
    {
        if (state)
        {
            audioSource.clip = walking;
            audioSource.loop = true;
            audioSource.Play();
            footSteep.Play();
        }
        else
        {
            audioSource.Stop();
            audioSource.loop = false;
            footSteep.Stop();
        }
    }

    public void PlayBlade01()
    {
        audioSource.clip = sword1;
        audioSource.Play();
        Blade01.Play();
    }
    public void PlayBlade02()
    {
        audioSource.clip = sword2;
        audioSource.Play();
        Blade02.Play();
    }
    public void PlayBlade03()
    {
        audioSource.clip = sword3;
        audioSource.Play();
        Blade03.Play();
    }

    public void StopBlade()
    {
        Blade01.Simulate(0);
        Blade01.Stop();
        
        Blade02.Simulate(0);
        Blade02.Stop();
        
        Blade03.Simulate(0);
        Blade03.Stop();
    }

    public void PlaySlash(Vector3 pos)
    {
        Slash.transform.position = pos;
        Slash.Play();
    }

    public void PlayHealVFX()
    {
        Heal.Play();
    }

}
