using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundButton : ButtonEvent
{
    [SerializeField] private AudioSource _audioSource;

    protected override void Awake()
    {
        base.Awake();
        _audioSource = GetComponent<AudioSource>();
    }

    protected override void HandleButtonClick()
    {
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}
