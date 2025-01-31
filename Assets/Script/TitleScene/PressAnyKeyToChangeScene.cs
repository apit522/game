using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToChangeScene : MonoBehaviour
{
    public string sceneName; // The name of the scene to load

    private bool canChangeScene = false;

    private void Update()
    {
        if (canChangeScene && (Input.anyKeyDown || Input.GetMouseButtonDown(0)))
        {
            ChangeScene();
        }
    }

    private void OnEnable()
    {
        canChangeScene = true;
    }

    private void OnDisable()
    {
        canChangeScene = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        canChangeScene = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canChangeScene = false;
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
