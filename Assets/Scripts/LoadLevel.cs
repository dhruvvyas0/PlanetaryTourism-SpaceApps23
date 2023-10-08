using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int levelNumber;
    public void LoadMercury()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadVenus()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadEarth()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadMars()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadJupiter()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadSaturn()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadUranus()
    {
        SceneManager.LoadScene(7);
    }
    public void LoadNeptune()
    {
        SceneManager.LoadScene(8);
    }
    public void LoadMoon()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadSun()
    {
        SceneManager.LoadScene(10);
    }
}
