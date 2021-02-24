using UnityEngine;

namespace BATOSZ_PTAK_17783.Scripts
{
    public class AudioManager : MonoBehaviour // not used
    {
        static AudioSource source;
        
        public static AudioManager Instance;

        void Awake()
        {
            Instance = this;
            source = GetComponent<AudioSource>();
        }

        public static void PlayClip(AudioClip clip) => source.PlayOneShot(clip);
    }
}