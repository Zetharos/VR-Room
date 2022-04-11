using System;
using UnityEngine;
using UnityEngine.Events;

public class TennisBallBounce : MonoBehaviour
{
    [Serializable] public class CollisionEvent : UnityEvent<Collision> { }
    public CollisionEvent OnEnter = new CollisionEvent();
    public AudioSource audioSource;
    public AudioClip impactSound;
    public Rigidbody rb;

    public void OnCollisionEnter(Collision collision)
    {
        float speed = 0.17f * rb.velocity.magnitude;
        audioSource.PlayOneShot(impactSound, speed);
    }
}
