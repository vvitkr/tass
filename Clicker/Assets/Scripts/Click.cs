using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
   
    public Text scoreText;
    private int score = 0;

    public void OnClick()
    {
        score++;   
        scoreText.text = score + '$';
    }

    
}
