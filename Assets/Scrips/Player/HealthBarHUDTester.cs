using UnityEngine;

public class HealthBarHUDTester : MonoBehaviour
{
    public void AddHealth()
    {
        PlayerStatManager.Instance.AddHealth();
    }

    public void Heal(int health)
    {
        PlayerStatManager.Instance.Heal(health);
    }

    public void Hurt(int dmg)
    {
        PlayerStatManager.Instance.TakeDamage(dmg);
    }
}
