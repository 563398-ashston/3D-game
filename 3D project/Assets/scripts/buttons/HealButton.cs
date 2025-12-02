using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using JetBrains.Annotations;

public class HealButton : MonoBehaviour
{
    public TMP_Text buttonText;

    public void Start()
    {
       
    }

    public void HealingButton()
    {
        LevelManager.instance.playerHealth = 100;
        buttonText.text = "healed";
        FindFirstObjectByType<AudioManager>().Play("menusfx");
        LevelManager.instance.playerScore += 75;
    }
}