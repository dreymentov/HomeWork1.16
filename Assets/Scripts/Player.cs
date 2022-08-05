using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody _rb;

    public Platform currentPlatform;

    public Game Game;

    public ParticleSystem particle;

    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
        particle.Stop();
    }
    public void Bounce()
    {
        _rb.velocity = Vector3.up * BounceSpeed;
    }

    public void Die()
    {
        particle.Play();
        Game.OnPlayerDied();
        _rb.velocity = Vector3.zero;
    }

    public void Reachfinish()
    {
        Game.OnPlayerReachfinish();
        _rb.velocity = Vector3.zero;
    }
}
