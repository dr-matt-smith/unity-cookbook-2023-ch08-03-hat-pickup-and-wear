using UnityEngine;

public class AccessoryPickup : MonoBehaviour
{
    public GameObject hatInPlayer;

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Hat"))
        {
            Destroy(hit.gameObject);
            hatInPlayer.SetActive(true);
        } 
    }
}
