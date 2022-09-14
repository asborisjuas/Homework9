using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class Bar : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Slider _slider;
    private Coroutine _coroutine;

    protected abstract int MaxValue { get; }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = MaxValue;
        _slider.value = MaxValue;
    }

    protected void OnValueChanged(int value)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(nameof(ChangeValue), value);
    }

    private IEnumerator ChangeValue(int value)
    {
        while (_slider.value != value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, value, _speed * Time.deltaTime);
            yield return null;
        }
    }
}
