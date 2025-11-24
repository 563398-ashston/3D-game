using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealButton : MonoBehaviour
{
    public TMP_Text buttonText;

    public void HealingButton()
    {
        LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "healed";
    }
}
