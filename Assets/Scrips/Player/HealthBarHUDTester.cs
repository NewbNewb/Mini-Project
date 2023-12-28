using UnityEngine;

public class HealthBarHUDTester : MonoBehaviour
{
    public void AddHealth()
    {
        PlayerStat.instance.AddHealth();
    }

    public void Heal(int health)
    {
        PlayerStat.instance.Heal(health);
    }

    public void Hurt(int dmg)
    {
        PlayerStat.instance.TakeDamage(dmg);
    }
}
