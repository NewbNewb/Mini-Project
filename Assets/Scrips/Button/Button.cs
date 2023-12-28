using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public void CallMainGameScene()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void CallTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}
