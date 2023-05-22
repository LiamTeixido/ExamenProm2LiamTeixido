using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IObserver : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        ScoreManager.Instance.OnScoreChanged += UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + ScoreManager.Instance.GetScore().ToString();
    }
}
