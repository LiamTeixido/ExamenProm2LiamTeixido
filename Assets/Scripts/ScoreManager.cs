using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    instance = obj.AddComponent<ScoreManager>();
                }
            }
            return instance;
        }
    }

    private int score;
    public int Score => score;

    /*private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    */


    public void IncrementScore(int value)
    {
        score += value;
    }
}
