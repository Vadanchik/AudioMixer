using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderEvent : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Start()
    {
        HandleSliderChange(_slider.value);
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(HandleSliderChange);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(HandleSliderChange);
    }

    protected virtual void HandleSliderChange(float value)
    {
        
    }
}
