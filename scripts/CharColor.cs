using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int color = PlayerPrefs.GetInt("charColor", 1);
        if(color == 1) {
            Transform player = transform.Find("hijau");
            player.gameObject.SetActive(true);
        }
        else if(color == 2) {
            Transform player = transform.Find("merah");
            player.gameObject.SetActive(true);
        }
        else {
            Transform player = transform.Find("putih");
            player.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
