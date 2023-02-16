using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class BirdFlight : MonoBehaviour
{
    /// <summary>
    ///     A reference to the game manager.
    /// </summary>
    public GameManager GameManager;

    /// <summary>
    ///     The velocity of jumps.
    /// </summary>
    public float Velocity = 0;

    // A reference to the bird.
    private Rigidbody2D _rb;

    void Start()
    {
        // Set the bird reference.
        _rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    ///     Apply the velocity when an input triggers jumps.
    /// </summary>
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = (Vector2.up * Velocity);
        }
    }

    /// <summary>
    ///     Reset the game when the bird hits collision.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }
}
