using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    /// <summary>
    ///     Adds to the score when the pipe trigger is hit.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.ScoreValue++;
    }
}
