using UnityEngine;

public class HealthBarHUDTester : MonoBehaviour
{
    public void AddHealth()
    {
        PlayerStatManager.instance.AddHealth();
    }

    public void Heal(int health)
    {
        PlayerStatManager.instance.Heal(health);
    }

    public void Hurt(int dmg)
    {
        PlayerStatManager.instance.TakeDamage(dmg);
    }
}
