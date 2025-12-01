using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static int playerHealthMax;
    Rigidbody rb;
    AudioSource audioSource;
    public AudioClip sfx1;  // sound effect asset from sfx folder 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //LevelManager.instance.SetHighScore(0);
        rb = GetComponent<Rigidbody>();
        playerHealthMax = 100;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xvel, yvel, zvel;

        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;
        zvel = rb.linearVelocity.z;

        if (Input.GetKey("w"))
        {
            xvel = 10;
            print("player moving forwards");
        }

       
        if (Input.GetKey("s"))
        {
            xvel = -10;
            print("player moving left");
        }
       

        if (Input.GetKey("d"))
        {
            zvel = -10;
            print("player moving right");
        }
        

        if (Input.GetKey("a"))
        {
            zvel = 10;
            print("player moving backwards");
            
        }


        rb.linearVelocity = new Vector3(xvel, yvel, zvel);


        rb.linearVelocity = new Vector3(rb.linearVelocity.x * 0.7f, rb.linearVelocity.y, rb.linearVelocity.z * 0.7f );



    }
    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(sfx1, 0.7f); // play audio clip with volume 0.7
    }


    //debug text output
    private void OnGUI()
     {/*
        //read variable from LevelManager singleton
        int score = LevelManager.instance.GetHighScore();

        string text = "High score: " + score;

        //text += "\nThis is more text";

        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();*/
     }
}

