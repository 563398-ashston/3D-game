using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public TMP_Text buttonText;
    AudioSource audioSource;
    public AudioClip sfx1;
    [SerializeField] private string ReturnToLevelSelectbutton = "levelSelect";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(sfx1, 0.7f); // play audio clip with volume 0.7
    }

    public void ReturnToLevelSelect()
    {
        //LevelManager.instance.playerHealth = 100;

        //gameObject.GetComponent<PlayerScript>().ResetHealth();
        buttonText.text = "x";

        SceneManager.LoadScene("levelSelect");
        PlaySoundEffect();
    }
}