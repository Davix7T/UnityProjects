using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private CoinCounter coinCounter;
    [SerializeField] private AudioClip collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aumenta el contador
            if (coinCounter != null)
            {
                coinCounter.AddCoin();
            }

            // Reproduce el sonido en el mundo (incluso si el objeto se destruye)
            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, transform.position);
            }

            // Destruye la moneda de inmediato
            Destroy(gameObject);
        }
    }
}
