using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private int _platformCount = 300;

    private void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < _platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-10f, 10f);
            Instantiate(_platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
