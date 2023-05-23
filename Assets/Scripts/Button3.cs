using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    public void OnClick()
    {
        ScoreManager.Instance.IncrementScore(3);
    }
}
