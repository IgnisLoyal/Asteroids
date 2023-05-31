using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollisionTeleport : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other) {
        Debug.Log("Collision Detected");
        float x = other.transform.position.x;
        float y = other.transform.position.y;
        if (other.tag == "Player" || other.tag == "Bullet" || other.tag == "Asteroid"){
            if (Mathf.Abs(x) > 10.5f){
                x = x * 0.9f;
            }
            if (Mathf.Abs(y) > 6.23f){
                y = y * 0.9f;
            }
        other.transform.position = new Vector3 (x * -1, y * -1, other.transform.position.z);
        }
    }
        
}