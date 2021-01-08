using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    // Start is called before the first frame update

    // int color = PlayerPrefs.GetInt("charColor", 1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectColor(int flag) {
        Debug.Log(flag);
        PlayerPrefs.SetInt("charColor", flag);
    }
}
