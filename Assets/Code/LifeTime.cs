using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToLive = 2;
    void Start()
    {
        Destroy(gameObject, timeToLive);
    }

    // Update is called once per frame

}
