using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public GameObject enemyPrefab;
  public Transform spawnPoint;
  public CombatSystem combatSystem;

  private GameObject currentEnemy;

  private void Start()
  {
    SpawnEnemy();
  }

  private void Update()
  {
    if (currentEnemy == null)
    {
      SpawnEnemy();
    }
  }

  void SpawnEnemy()
  {
    currentEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    combatSystem.enemy = currentEnemy.GetComponent<EnemyStats>();
  }
}
