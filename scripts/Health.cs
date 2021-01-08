using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI health;

    void Start()
    {
        health = GameObject.Find("Health and Score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // health.text = "asd";
        health.text = "Health  : " + ((int)PlayerEat.hp).ToString() + "\nScore   : " + ((int)PlayerEat.score).ToString();
    }
}
