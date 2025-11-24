using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] private string NewGameLevel = "level1";

    public void NewGameButton()
    {
        SceneManager.LoadScene(NewGameLevel);
    }
}
