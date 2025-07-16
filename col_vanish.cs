using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coll"))
        {
            // Make the coin disappear
            Destroy(other.gameObject);

            // Optional: Add score, sound, etc.
            Debug.Log("Growth collected!");
        }
    }
}
