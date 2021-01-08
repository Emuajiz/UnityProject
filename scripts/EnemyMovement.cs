using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    float randX, randY;
    Vector2 force;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        randX = Random.Range(-100f, 100f);
        randY = Random.Range(-100f, 100f);
        force = new Vector2(randX, randY);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
