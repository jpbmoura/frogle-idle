using UnityEngine;

public class PlayerStats : MonoBehaviour
{
  [Header("Base Stats")]
  public int level = 1;
  public int maxHp = 10;
  public int attack = 1;

  [Header("Runtime")]
  public int currentHp;

  private void Awake()
  {
    currentHp = maxHp;
  }
}