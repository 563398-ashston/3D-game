using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startlevel1 : MonoBehaviour
{
    public TMP_Text buttonText;
    [SerializeField] private string Startlevel1button = "level1";

    public void StartGameButton()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "game starting";

        SceneManager.LoadScene("level1");
    }
}
