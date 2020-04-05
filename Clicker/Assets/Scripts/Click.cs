using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    

    public Text scoreText;
    private int score;
    private int bonus = 1;

    [Header("Магазин")]
    public int[] shopCosts;
    public int[] shopBonuses;
    public Text[] shopBtnText;
    public GameObject shopPan;

    private void Update()
    {
        scoreText.text = score + " $";
    }
    public void OnClick()
    {
        score += bonus;
    }

    public  void shopPanel()
    {
        shopPan.SetActive(!shopPan.activeSelf);
    }

    public void addBonus(int index)
    {
        if (score >= shopCosts[index])
        {
            bonus += shopBonuses[index];
            score -= shopCosts[index];
            shopCosts[index] *= 2;
            shopBtnText[index].text = "Купить улучшение 1\n" + shopCosts[index] + '$';
        }
        else
        {
            Debug.Log("Недостаточно денег ");
        }
    }

}
