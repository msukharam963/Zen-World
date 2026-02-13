using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void LoadZenGarden()
    {
        // Optional: Add a fade out effect here
        SceneManager.LoadScene("zenGarden");
    }
}