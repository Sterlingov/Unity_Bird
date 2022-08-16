using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pipes;
    void Start()
    {
        StartCoroutine(PipesSpawner());
    }

    IEnumerator PipesSpawner()
    {   while (true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-3.5f, 0.7f);
            GameObject newPipe = Instantiate(Pipes, new Vector3(10, rand, -4), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
}
