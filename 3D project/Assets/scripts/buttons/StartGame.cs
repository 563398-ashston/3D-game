using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_Text buttonText;
    [SerializeField] private string StartMenu = "menu";

    public void StartMenuButton()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "game loading";

        SceneManager.LoadScene("levelSelect");
    }
}
