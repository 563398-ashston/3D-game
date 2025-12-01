using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public TMP_Text buttonText;
    [SerializeField] private string ReturnToLevelSelectbutton = "levelSelect";

    public void ReturnToLevelSelect()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "x";

        SceneManager.LoadScene("levelSelect");
    }
}