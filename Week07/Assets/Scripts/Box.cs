using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Box : MonoBehaviour , IDamageable
    {
        public AudioSource AudioSource;
        public AudioClip metallicHitAudio;
        public void TakeDamage()
        {
            Debug.Log("Box: I am hit by a bullet!");  
            AudioSource.clip = metallicHitAudio;
            AudioSource.Play();
        }

        private void OnCollisionEnter(Collision collision)
        {
            TakeDamage();
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        
    }
}