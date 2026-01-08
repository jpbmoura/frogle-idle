using UnityEngine;
using System.Collections;

public class CombatSystem : MonoBehaviour
{
  public PlayerStats player;
  public EnemyStats enemy;

  public float attackInterval = 1.5f;

  private void Start()
  {
    StartCoroutine(AutoAttack());
  }

  IEnumerator AutoAttack()
  {
    while (true)
    {
      if (enemy != null)
      {
        enemy.TakeDamage(player.attack);
      }

      yield return new WaitForSeconds(attackInterval);
    }
  }
}