using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitGame()
    {
        // Logs a message to the console so you know it was clicked
        Debug.Log("Quit Game Requested");

        // This works in the final build (Quest/PC VR)
        Application.Quit();

        // This makes it work in the Unity Editor (for testing)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}