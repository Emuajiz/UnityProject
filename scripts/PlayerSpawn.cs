using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public CinemachineVirtualCamera cam;
    void Start()
    {
        GameObject spawnedPlayer = Instantiate(player);
        cam.Follow = spawnedPlayer.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
