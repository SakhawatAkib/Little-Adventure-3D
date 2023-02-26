using System;
using UnityEngine;

public class Enemy_02_Shoot : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject DamageOrb;
    
    public AudioSource audioSource;
    public AudioClip shootAudioClip;

    private Character cc;

    private void Awake()
    {
        cc = GetComponent<Character>();
    }

    public void ShootTheDamageOrb()
    {
        audioSource.clip = shootAudioClip;
        audioSource.Play();
        Instantiate(DamageOrb, ShootingPoint.position, Quaternion.LookRotation(ShootingPoint.forward));
    }

    private void Update()
    {
        cc.RotateToTarget();
    }
}
