using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    public Transform contentSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int rnd = Random.Range(0, contentSpawnPoint.childCount);
            Instantiate(prefab, contentSpawnPoint.GetChild(rnd).position, contentSpawnPoint.GetChild(rnd).rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
