using UnityEngine;

namespace BATOSZ_PTAK_17783.Scripts
{
    public class SoundtrackSwitcher : MonoBehaviour
    {
        public AudioSource source1;
        public AudioSource source2;

        public Collider[] switchColliders;
        
        Transform playerTransform;

        public bool source1Active = false;
        public bool source2Active = false;
        
        void Start()
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void Update()
        {
            bool foundPlayer = false;
            foreach (Collider c in switchColliders)
                if (c.bounds.Contains(playerTransform.position))
                    foundPlayer = true;
            

            if (foundPlayer && !source2Active)
            {
                source1.Stop();
                source2.Play();
                source2Active = true;
                source1Active = false;
            }
            
            if (!foundPlayer && !source1Active)
            {
                source2.Stop();
                source1.Play();
                source1Active = true;
                source2Active = false;
            }
        }
    }
}