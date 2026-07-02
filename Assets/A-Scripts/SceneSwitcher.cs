using UnityEngine;
using UnityEngine.SceneManagement;  // Import Scene Management namespace

public class SceneSwitcher : MonoBehaviour
{
    // Function to switch to Scene1 when called
    public void SwitchToScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}