using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 1f;
    [SerializeField] private GameObject _astroid;
    private float _timer;
    void Start()
    {
        SpawnAstroid();
    }

    void Update()
    {
          if (_timer > _maxTime)
          {
            SpawnAstroid();
            _timer = 0;
          }
          _timer += Time.deltaTime; 
    }

    private void SpawnAstroid()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange,_heightRange));
        GameObject astroid = Instantiate(_astroid, spawnPos, Quaternion.identity);

        Destroy(astroid,10f);
    }
}
