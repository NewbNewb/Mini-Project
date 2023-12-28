using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public delegate void OnHealthChangedDelegate();
    public OnHealthChangedDelegate onHealthChangedCallback;
    private Animator _animator;
    private GameObject dim;

    [SerializeField]
    private int health;
    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int maxTotalHealth;
    public int Health { get { return health; } }
    public int MaxHealth { get { return maxHealth; } }
    public int MaxTotalHealth { get { return maxTotalHealth; } }

    public static PlayerStat instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        dim = GameObject.Find("Canvas").transform.GetChild(2).gameObject;
        _animator = GetComponentInChildren<Animator>();
    }

    public void Heal(int health)
    {
        this.health += health;
        ClampHealth();
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        ClampHealth();
        if (health <= 0)
        {
            _animator.SetBool("isDeath",true);
            Invoke("GameOver", 3f);
        }
    }

    private void GameOver()
    {
        dim.SetActive(true);
    }

    public void AddHealth()
    {
        if (maxHealth < maxTotalHealth)
        {
            maxHealth += 1;
            health = maxHealth;

            if (onHealthChangedCallback != null)
                onHealthChangedCallback.Invoke();
        }   
    }

    void ClampHealth()
    {
        health = Mathf.Clamp(health, 0, maxHealth);

        if (onHealthChangedCallback != null)
            onHealthChangedCallback.Invoke();
    }
}
