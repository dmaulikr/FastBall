using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public Vector3 startPosition;

	void Start()
    {
        SceneManager.LoadSceneAsync("GUI", LoadSceneMode.Additive);
	}
}
