using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        
    }
}
