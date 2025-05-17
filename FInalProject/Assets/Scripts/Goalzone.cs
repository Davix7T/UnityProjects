using UnityEngine;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private GameObject victoryImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (victoryImage != null)
            {
                victoryImage.SetActive(true);
            }
        }
    }
}
