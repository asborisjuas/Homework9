using UnityEngine;
using UnityEngine.UI;

public class ChangingHealthButton : MonoBehaviour
{
    [SerializeField] private Health _character;
    [SerializeField] private int _delta;
    [SerializeField] private bool _isDamage;

    public void OnButtonClick()
    {
        _character.ChangeHealth(Mathf.Abs(_delta), _isDamage);
    }
}