using System.Collections;
using UnityEngine;

public class enemySpawnManager : MonoBehaviour
{
    [SerializeField] private Transform[] enemySpawns;
    [SerializeField] private GameObject spooders;
    [SerializeField] private float delay;
    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            for (int i = 0; i < enemySpawns.Length; i++)
            {
                Instantiate(spooders, enemySpawns[i]);
                yield return new WaitForSeconds(delay);
            }
        }
    }
    
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

}
