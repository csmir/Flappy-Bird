using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    /// <summary>
    ///     Represents the total hopped pipes.
    /// </summary>
    public static int ScoreValue;

    /// <summary>
    ///     Start the score behavior and set the score to 0.
    /// </summary>
    private void Start()
    {
        ScoreValue = 0;
    }

    /// <summary>
    ///     Set the score in a text box at the top of the screen.
    /// </summary>
    private void Update()
    {
        // Get the text element and set it to the current score value.
        GetComponent<UnityEngine.UI.Text>().text = ScoreValue.ToString();
    }
}
