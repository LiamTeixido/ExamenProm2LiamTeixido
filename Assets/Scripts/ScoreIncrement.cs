using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour
{
    protected abstract int GetIncrementValue();

    protected virtual void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(IncrementScore);
    }

    protected void IncrementScore()
    {
        int incrementValue = GetIncrementValue();
        ScoreManager.Instance.IncrementScore(incrementValue);
    }
}
