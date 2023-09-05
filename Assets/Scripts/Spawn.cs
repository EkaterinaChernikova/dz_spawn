using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private Movement _enemy;

    private Transform[] _points;

    private Coroutine _enemySpawnCoroutine;

    private int _randomPoint;
    private WaitForSeconds _timer;

    private void Start()
    {
        _points = GetComponentsInChildren<Transform>();
        _timer = new WaitForSeconds(_delay);
        _enemySpawnCoroutine = StartCoroutine(SpawnEnemyes());
    }

    private IEnumerator SpawnEnemyes()
    {
        while (true)
        {
            _randomPoint = Random.Range(0, _points.Length);
            Instantiate(_enemy, 
                new Vector3(
                    _points[_randomPoint].position.x,
                    _points[_randomPoint].position.y,
                    _points[_randomPoint].position.z),
                _points[_randomPoint].rotation);
            yield return _timer;
        }
    }
}
