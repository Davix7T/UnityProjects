using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private CoinCounter coinCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (coinCounter != null)
            {
                coinCounter.AddCoin();
            }

            Destroy(this.gameObject);
        }
    }
}
