using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int score = 0;
    private static ScoreManager instance;
    internal Action OnScoreChanged;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
                if (instance == null)
                {
                    GameObject manager = new GameObject("ScoreManager");
                    instance = manager.AddComponent<ScoreManager>();
                }
            }
            return instance;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void IncrementScore(int value)
    {
        score += value;
    }
}
