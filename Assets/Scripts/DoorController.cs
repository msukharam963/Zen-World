using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorController : MonoBehaviour
{
    [Header("Settings")]
    public string sceneToLoad; // Name of the scene (e.g., "NorthernLights")
    public string requiredKeyTag; // Tag of the key (e.g., "Key_Northern")

    [Header("References")]
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socketInteractor;

    private void OnEnable()
    {
        // Listen for when an object enters the socket
        socketInteractor.selectEntered.AddListener(OnKeyInserted);
    }

    private void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(OnKeyInserted);
    }

    private void OnKeyInserted(SelectEnterEventArgs args)
    {
        // Check if the object placed in the socket has the correct tag
        if (args.interactableObject.transform.CompareTag(requiredKeyTag))
        {
            Debug.Log("Correct Key! Loading World...");
            LoadWorld();
        }
    }

    private void LoadWorld()
    {
        // In a real game, you would want to fade the screen to black here first!
        SceneManager.LoadScene(sceneToLoad);
    }
}