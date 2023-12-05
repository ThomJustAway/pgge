using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour 
    {
        void Start()
        {
            // Destroy the bullet after 10 seconds if it does not hit any object.
            StartCoroutine(Coroutine_Destroy(10.0f));
        }

        private void OnCollisionEnter(Collision collision)
        {
            IDamageable obj = collision.gameObject.GetComponent<IDamageable>();
            if (obj != null)
            {
                obj.TakeDamage();
            }
            StartCoroutine(Coroutine_Destroy(0.1f));
        }

        IEnumerator Coroutine_Destroy(float duration)
        {
            yield return new WaitForSeconds(duration);
            Destroy(gameObject);
        }

    }
}