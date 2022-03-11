using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstermoving : MonoBehaviour
{
    public float distance;
    public float speed;
    private bool movingRight = true;

    public Transform groundDetection;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0,-180,0);
                movingRight = false;
            }else{
                transform.eulerAngles = new Vector3(0,0,0);
                movingRight = true;
            }
        }
    }
}
