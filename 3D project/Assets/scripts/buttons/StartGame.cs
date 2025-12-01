using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_Text buttonText;
    AudioSource audioSource;
    public AudioClip sfx1;
    [SerializeField] private string StartMenu = "menu";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(sfx1, 0.7f); // play audio clip with volume 0.7
    }

    public void StartMenuButton()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "game loading";

        SceneManager.LoadScene("levelSelect");
        PlaySoundEffect();
    }
}
