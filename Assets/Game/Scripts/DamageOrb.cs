using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DamageOrb : MonoBehaviour
{
    public float Speed = 2f;
    public int Damage = 10;
    public ParticleSystem HitVFX;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        _rb.MovePosition(transform.position + transform.forward * (Speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        Character cc = other.gameObject.GetComponent<Character>();
        if (cc != null && cc.IsPlayer)
        {
            cc.ApplyDamage(Damage, transform.position);
        }
        Instantiate(HitVFX, transform.position, quaternion.identity);
        Destroy(gameObject);
    }
}
