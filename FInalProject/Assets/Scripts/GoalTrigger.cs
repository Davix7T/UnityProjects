using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject victorySign; // Asigna aquí el letrero de victoria (imagen o texto)

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasWon && other.CompareTag("Player"))
        {
            hasWon = true;

            // Reproduce el audio si está asignado
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
                Debug.Log("¡Felicidades! Has llegado al final.");
            }

            // Activa el letrero de victoria
            if (victorySign != null)
            {
                victorySign.SetActive(true);
            }
        }
    }
}
