using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Startlevel1 : MonoBehaviour
{
    public TMP_Text buttonText;
    AudioSource audioSource;
    public AudioClip sfx1;
    [SerializeField] private string Startlevel1button = "level1";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(sfx1, 0.7f); // play audio clip with volume 0.7
    }

    public void StartGameButton()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "game starting";

        SceneManager.LoadScene("level1");
        PlaySoundEffect();
    }
}
