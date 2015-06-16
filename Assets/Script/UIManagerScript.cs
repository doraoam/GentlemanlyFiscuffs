using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public string startLevel;

    public void StartGame()
    {
        Application.LoadLevel(3);
    }

    public void StartMulti()
    {
        Application.LoadLevel(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
