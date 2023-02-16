using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    /// <summary>
    ///     Movement speed of the bird.
    /// </summary>
    public float Speed;

    /// <summary>
    ///     Set the bird's speed.
    /// </summary>
    void Update()
    {
        // Apply speed to the bird.
        transform.position += Speed * Time.deltaTime * Vector3.left;
    }
}
