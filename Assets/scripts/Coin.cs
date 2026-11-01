
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Catcher")
        {
           GameManager manager = FindAnyObjectByType<GameManager>();

            if (manager != null)
            {
                manager.AddScore();
            }

            Destroy(gameObject);
        }
    }
}
