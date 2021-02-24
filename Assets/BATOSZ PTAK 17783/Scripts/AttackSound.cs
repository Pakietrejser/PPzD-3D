using UnityEngine;

namespace BATOSZ_PTAK_17783.Scripts
{
    public class AttackSound : MonoBehaviour
    {
        public GameObject torch;
        public GameObject pickaxe;

        public AudioSource source;
        public AudioClip torchSwing;
        public AudioClip pickaxeSwing;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (torch.activeSelf)
                {
                    source.PlayOneShot(torchSwing);
                }

                if (pickaxe.activeSelf)
                {
                    source.PlayOneShot(pickaxeSwing);
                }
            }
        }
    }
}