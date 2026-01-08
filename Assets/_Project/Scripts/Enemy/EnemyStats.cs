using UnityEngine;

public class EnemyStats : MonoBehaviour
{
  [Header("Base Stats")]
  public int maxHP = 5;

  [Header("Runtime")]
  public int currentHP;


  public void Awake()
  {
    currentHP = maxHP;

  }

  public void TakeDamage(int damage)
  {
    currentHP -= damage;

    if (currentHP <= 0)
    {
      Die();
    }
  }

  private void Die()
  {
    Destroy(gameObject);
  }
}