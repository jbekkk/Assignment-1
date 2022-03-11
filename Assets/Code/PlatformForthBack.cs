using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformForthBack : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.5f;
    public float distance = 5;
    private float startPosition;

    void Start()
    {
        startPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x = Mathf.SmoothStep(startPosition, startPosition - distance, Mathf.PingPong(Time.time * speed, 1));
        transform.position = newPosition;
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            other.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            other.transform.SetParent(null);
        }
    }

}
