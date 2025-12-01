using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startlevel2 : MonoBehaviour
{
    public TMP_Text buttonText;
    [SerializeField] private string Startlevel2button = "level2";

    public void StartGameButton()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "game starting";

        SceneManager.LoadScene("level2");
    }
}
