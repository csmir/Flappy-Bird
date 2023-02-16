using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    ///     The canvas to load when <see cref="GameOver"/> is called.
    /// </summary>
    public GameObject GameOverCanvas;

    /// <summary>
    ///     Load the <see cref="GameOverCanvas"/> screen.
    /// </summary>
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);

        // Freeze time
        Time.timeScale = 0f;
    }

    /// <summary>
    ///     Reset the scene, starting the game.
    /// </summary>
    public void Replay()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);

        // Set time
        Time.timeScale = 1f;
    }
}
