using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEat : MonoBehaviour
{

    static public int score = 0;
    static public float hp = 100;
    public float maxHP = 100;

    void FixedUpdate()
    {
        hp -= 1 * Time.fixedDeltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obs = collision.gameObject;

        if (obs.tag == "musuh")
        {
            ObsSpawn.enemySpawned--;
            score = score + 5;
            hp -= 5;
            Destroy(collision.gameObject);
        }
        else if (obs.tag == "musuh1") 
        {
            ObsSpawn.enemySpawned--;
            score = score + 10;
            hp -= 10;
            Destroy(collision.gameObject);
        }
        else if (obs.tag == "musuh2")
        {
            ObsSpawn.enemySpawned--;
            score = score + 20;
            hp -= 40;
            Destroy(collision.gameObject);
        }
        else if (obs.name == "Health(Clone)")
        {
            ObsSpawn.healthSpawned--;
            hp += 50;
            Destroy(collision.gameObject);
        }
        if (hp > maxHP)
        {
            hp = 100;
        }
        else if (hp < 0)
        {
            PauseMenu.GameIsOver = true;
        }
    }
}
