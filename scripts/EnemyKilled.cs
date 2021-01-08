using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D info)
    {
        if (info.tag == "Player")
        {
            Destroy(gameObject);
            ObsSpawn.enemySpawned--;
            PlayerEat.score = PlayerEat.score + 1;
            PlayerEat.hp -= 10;
            Debug.Log("ye");
        }
    }
}
