using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }
}