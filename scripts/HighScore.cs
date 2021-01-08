using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        if (((int)PlayerEat.score) > PlayerPrefs.GetInt("Score", 0))
        {
            PlayerPrefs.SetInt("Score", ((int)PlayerEat.score));
            highScore.text = ((int)PlayerEat.score).ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("Score", 0);
        highScore.text = "0";
    }
}
