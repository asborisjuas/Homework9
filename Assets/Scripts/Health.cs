using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public const int MaxHealth = 100;

    private int _currentHealth = MaxHealth;

    public event Action<int> Changed;

    public void Heal(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Math.Min(_currentHealth, MaxHealth);
        Changed?.Invoke(_currentHealth);
    }

    public void Damage(int amount)
    {
        _currentHealth -= amount;
        _currentHealth = Math.Max(0, _currentHealth);
        Changed?.Invoke(_currentHealth);
    }
}