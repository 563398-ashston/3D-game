using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectable")
        {
            LevelManager.instance.playerScore += 100;
            Destroy(other.gameObject);
        }
    }
}