using UnityEngine;
using UnityEngine.SceneManagement;  // Import Scene Management namespace

public class SceneSwitcher1 : MonoBehaviour
{
    // Function to switch to Scene0 when called
    public void SwitchToScene0()
    {
        SceneManager.LoadScene("Scene0");
    }
}