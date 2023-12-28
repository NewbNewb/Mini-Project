﻿using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{
    public delegate void OnHealthChangedDelegate();
    public OnHealthChangedDelegate onHealthChangedCallback;

    private static PlayerStatManager instance;
    public static PlayerStatManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<PlayerStatManager>();
            return instance;
        }
    }

    [SerializeField]
    private int health;
    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int maxTotalHealth;

    public int Health { get { return health; } }
    public int MaxHealth { get { return maxHealth; } }
    public int MaxTotalHealth { get { return maxTotalHealth; } }

    public void Heal(int health)
    {
        this.health += health;
        ClampHealth();
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        ClampHealth();
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
