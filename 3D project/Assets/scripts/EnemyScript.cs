using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelManager.instance.playerHealth -= 10;
        }
    }
}
