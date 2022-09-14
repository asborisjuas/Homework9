using UnityEngine;

public class Healthbar : Bar
{
    [SerializeField] private Health _character;

    protected override int MaxValue => Health.MaxHealth;

    private void OnEnable()
    {
        _character.Changed += OnValueChanged;
    }

    private void OnDisable()
    {
        _character.Changed -= OnValueChanged;
    }
}
