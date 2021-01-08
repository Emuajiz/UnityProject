using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{

    public float averageTimeSpan = 30f;
    float timeLife = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeLife += Time.deltaTime;
        if (timeLife > averageTimeSpan)
        {
            objectDestroy();
        }
    }

    void objectDestroy()
    {
        ObsSpawn.enemySpawned--;
        Destroy(gameObject);
    }

}
