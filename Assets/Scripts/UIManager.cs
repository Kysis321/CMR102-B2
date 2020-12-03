using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    public void UpdateScoreText(int currentScore)
    {
        scoreText.text = "Bubbles Popped: " + currentScore;
    }
}
