using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int playerHealth;
    private int highScore;
    public TMP_Text healthText;

    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("do not destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }

        playerHealth = 100;
    }


    //these methods are globally accessible
    public void SetHighScore(int score)
    {
        highScore = score;
    }
    public int GetHighScore()
    {
        return highScore;
    }

    private void Update()
    {
        healthText.text = "health=" + playerHealth;

      
    }
}