using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public TMP_Text buttonText;
    [SerializeField] private string ReturnToMenuButton = "menu";

    public void ReturnToMenu()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "returning...";

        SceneManager.LoadScene("Frontend");
    }
}
