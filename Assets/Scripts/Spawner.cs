using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Movement _enemy;
    [SerializeField] private Transform _target;

    private Movement _spawnedEnemy;

    public void SpawnEnemy()
    {
        _spawnedEnemy = Instantiate(_enemy, transform);
        _spawnedEnemy.SetTarget(_target);
        _spawnedEnemy = null;
    }
}
