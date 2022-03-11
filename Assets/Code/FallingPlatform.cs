using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    Vector2 startPosition;
    Collider2D _collider;
    SpriteRenderer _renderer;
    Color clear;
    Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody.isKinematic = true;
        startColor = _renderer.color;
        clear = _renderer.color;
        clear.a = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
           StartCoroutine(Fall());
        }
    }

    IEnumerator Fall(){
        yield return new WaitForSeconds(.5f);
        _rigidbody.isKinematic = false;

        yield return new WaitForSeconds(7f);
        _rigidbody.isKinematic = true;
        _collider.enabled = false;

        float t = 0;
        while (t < 1){
            _renderer.color = Color.Lerp(startColor, clear, t);
            t += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(1f);

        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        _collider.enabled = true;

        t = 0;
        while (t < 1){
            _renderer.color = Color.Lerp(startColor, startColor, t);
            t += Time.deltaTime;
            yield return null;
        }

    }
}
