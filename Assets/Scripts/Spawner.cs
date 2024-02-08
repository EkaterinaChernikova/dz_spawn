using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _target;

    private GameObject _spawnedEnemy;

    public void SpawnEnemy()
    {
        _spawnedEnemy = Instantiate(_enemy, transform);
        _spawnedEnemy.GetComponent<Movement>().SetTarget(_target.transform);
    }
}
