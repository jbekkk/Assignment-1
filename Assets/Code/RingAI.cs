using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAI : MonoBehaviour
{
    Animator _animator;
    public AudioClip hitSnd;
    AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _animator =  GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            _audioSource.PlayOneShot(hitSnd);
            Destroy(other.gameObject);
            _animator.SetTrigger("Die");
            Destroy(gameObject, .2f);
        }
    }
}
