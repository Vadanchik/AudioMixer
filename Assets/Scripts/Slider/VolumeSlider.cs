using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : SliderEvent
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private MixerData.MixerGroup _group;

    private const float Ñoefficient = 0.25f;

    protected override void HandleSliderChange(float value)
    {
        base.HandleSliderChange(value);
        _mixer.audioMixer.SetFloat(MixerData.EnumToString(_group), Mathf.Log10(Mathf.Clamp01(value)) * (MixerData.Params.MaxVolume - MixerData.Params.ZeroVolume) * Ñoefficient + MixerData.Params.MaxVolume);
    }
}
