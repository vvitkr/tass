using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
   
    public Text scoreText;
    public GameObject shopPan;
    private int score = 0;
   

    public void OnClick()
    {
        score++;
        scoreText.text = score + " enemies turned to dust";
    }

    public  void shopPanel()
    {
        shopPan.SetActive(!shopPan.activeSelf);
    }

   
}
