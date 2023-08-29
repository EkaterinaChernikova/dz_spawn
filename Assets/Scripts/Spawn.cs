using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private GameObject _enemy;

    private Transform[] _pointsArray;

    private Coroutine _enemySpawnCoroutine;

    private int _randomPoint;

    void Start()
    {
        _pointsArray = GetComponentsInChildren<Transform>();
        _enemySpawnCoroutine = StartCoroutine(SpawnEnemyes());
    }

    private IEnumerator SpawnEnemyes()
    {
        while (true)
        {
            _randomPoint = Random.Range(0, _pointsArray.Length);
            Instantiate(_enemy, 
                new Vector3(
                    _pointsArray[_randomPoint].position.x,
                    _pointsArray[_randomPoint].position.y,
                    _pointsArray[_randomPoint].position.z),
                _pointsArray[_randomPoint].rotation);
            yield return new WaitForSeconds(_delay);
        }
    }
}
