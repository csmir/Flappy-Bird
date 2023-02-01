using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int ScoreValue;

    private void Start()
    {
        ScoreValue = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = ScoreValue.ToString();
    }
}
