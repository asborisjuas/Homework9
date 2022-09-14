using UnityEngine;

public abstract class ChangingHealthButton : MonoBehaviour
{
    [SerializeField] protected Health Character;
    [SerializeField] protected int Amount;

    private void OnValidate()
    {
        if (Amount < 0)
        {
            Amount *= -1;
        }
    }

    public abstract void OnButtonClick();
}