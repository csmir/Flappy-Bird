using UnityEngine;

public class Spawner : MonoBehaviour
{
    /// <summary>
    ///     The amount of time between pipe spawns.
    /// </summary>
    public float MaxTime = 1;

    // An internal timer to track how long its taken to run the timer
    private float _timer = 0;

    /// <summary>
    ///     The pipe to spawn.
    /// </summary>
    public GameObject Pipe;
    public float Height;

    // Update is called once per frame
    void Update()
    {
        // If the timer goes over maxtime
        if (_timer > MaxTime)
        {
            // Spawn a new pipe and apply height
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);

            // Destroy the pipe after 15s
            Destroy(newPipe, 15);

            // Reset the timer
            _timer = 0;
        }

        // Add delta time to the timer.
        _timer += Time.deltaTime;
    }
}
