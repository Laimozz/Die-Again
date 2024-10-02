using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem explosion;
    public static PlayerCollision instance;
    private void Awake()
    {
        instance = this;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Hazardt1")
        {
            PlayerMovement.instance.isDead = true;
            PlayHitEffect();
            AudioPlayer.instance.DieSound();
            Destroy(transform.gameObject);
            GameManager.instance.ReloadGame();
        }
        if(other.tag == "Hazardt2")
        {
            CameraShake.instance.Play();
            Rigidbody2D otherRigdibody = other.GetComponent<Rigidbody2D>();
            otherRigdibody.gravityScale = 5f;
        }
        if(other.tag == "Weight")
        {
            PlayHitEffect();
        }
    }
    public void PlayHitEffect()
    {
        if(explosion != null)
        {
            ParticleSystem instance = Instantiate(explosion , transform.position , Quaternion.identity);
            Destroy(instance.gameObject , explosion.main.duration + explosion.main.startLifetime.constantMax);
        }
    }
}
