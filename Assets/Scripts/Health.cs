using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public const int MaxHealth = 100;

    private int _currentHealth = MaxHealth;

    public event Action<int> Changed;

    public void TakeHealing()
    {
        const int AmountOfHealing = 10;

        ChangeHealth(AmountOfHealing);
    }

    public void TakeDamage()
    {
        const int AmountOfDamage = 10;

        ChangeHealth(AmountOfDamage * -1);
    }

    private void ChangeHealth(int delta)
    {
        _currentHealth += delta;

        if (_currentHealth > MaxHealth)
        {
            _currentHealth = MaxHealth;
        }
        else if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }

        Changed?.Invoke(_currentHealth);
    }
}