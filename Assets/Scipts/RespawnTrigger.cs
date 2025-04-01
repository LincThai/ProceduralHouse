using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    // respawn point empty game object transform
    public Transform respawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // move player to that position
            other.gameObject.transform.position = respawnPosition.position;
            Debug.Log("respawn");
        }
    }
}
