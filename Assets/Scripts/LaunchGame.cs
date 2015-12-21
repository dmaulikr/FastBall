using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchGame : MonoBehaviour
{
	void Start ()
    {
        Input.gyro.enabled = true;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Game.LoadData();
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}
}
