using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] levels = null;

	void Start ()
    {
        GameObject levelPrefab = levels[Game.Level];

        GameObject levelGO = Instantiate(levelPrefab);
        levelGO.name = levelPrefab.name;
        levelGO.transform.SetParent(transform, false);
	}
}
