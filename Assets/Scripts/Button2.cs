using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    public void OnClick()
    {
        ScoreManager.Instance.IncrementScore(2);
    }
}
