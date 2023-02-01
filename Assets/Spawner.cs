using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float MaxTime = 1;
    private float _timer = 0;
    public GameObject Pipe;
    public float Height;

    // Update is called once per frame
    void Update()
    {
        if (_timer > MaxTime)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);

            Destroy(newPipe, 15);

            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
