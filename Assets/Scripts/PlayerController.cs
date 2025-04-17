using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    public AudioClip coinSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            audioSource.PlayOneShot(coinSound);
            GameManager.instance.AddPoint();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Obstacle"))
        {
            GameManager.instance.GameOver();
        }
    }
}
