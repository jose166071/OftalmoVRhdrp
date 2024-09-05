using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private GameEvent OnButtonPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            OnButtonPressed.Raise(this, "Audio Clip Playing");
        }
    }

    public void AudioPlay(Component sender, object data)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
