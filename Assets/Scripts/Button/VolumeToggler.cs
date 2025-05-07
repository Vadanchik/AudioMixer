using UnityEngine;
using UnityEngine.Audio;

public class VolumeToggler : ButtonEvent
{
    [SerializeField] private AudioMixerGroup _mixer;
    private bool _isMusicPlay = true;

    protected override void HandleButtonClick()
    {
        if (_isMusicPlay)
        {
            _mixer.audioMixer.SetFloat(MixerData.Params.MasterVolume, -80);
            _isMusicPlay = false;
        }
        else
        {
            _mixer.audioMixer.SetFloat(MixerData.Params.MasterVolume, 0);
            _isMusicPlay = true;
        }
    }
}
