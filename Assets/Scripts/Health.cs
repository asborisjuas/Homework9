using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public const int MaxHealth = 100;

    private int _currentHealth = MaxHealth;

    public event Action<int> Changed;

    public void ChangeHealth(int delta, bool isDamage)
    {
        if (isDamage)
        {
            _currentHealth -= delta;
        }
        else
        {
            _currentHealth += delta;
        }

        _currentHealth = Math.Clamp(_currentHealth, 0, MaxHealth);
        Changed?.Invoke(_currentHealth);
    }
}