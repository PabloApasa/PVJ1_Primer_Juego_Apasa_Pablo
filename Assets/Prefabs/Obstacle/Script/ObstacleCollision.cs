using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("esta colisionando");

        if (collision.collider.name == "Player")
        { 
            Destroy(gameObject);
        }
    }
}