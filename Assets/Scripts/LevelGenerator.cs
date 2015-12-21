using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public static ushort cubes = 20;

    [SerializeField]
    private GameObject[] cubePrefabs = null;

    public float pointSize = 0.25F;
    public Vector3 origin = Vector3.zero;

    //readonly Color[] colors = { Color.blue, Color.blue, Color.green, Color.green, Color.red, Color.red };

    public void Start()
    {
        System.Random rnd = new System.Random();
        Transform parentTransform = gameObject.transform;
        GameObject cubePrefab = cubePrefabs[rnd.Next(cubePrefabs.Length)];
        int value;
        int lastValue = -1;

        // first
        GameObject cube = Instantiate(cubePrefab);
        cube.transform.parent = parentTransform;
        cube.transform.position = origin;
        cube.GetComponent<BlockComponent>().pointGameObject.SetActive(false);

        for (ushort i = 0; i < cubes; ++i)
        {
            do
            {
                value = rnd.Next(8);
            } while (value == lastValue);

            switch (value)
            {
                case 0:
                    origin.x += 1;
                    lastValue = 1;
                    break;
                case 1:
                    origin.x -= 1;
                    lastValue = 0;
                    break;
                case 2:
                    origin.z -= 1;
                    lastValue = 3;
                    break;
                case 3:
                    origin.z += 1;
                    lastValue = 2;
                    break;

                case 4:
                    origin.x += 1;
                    origin.z += 1;
                    lastValue = 7;
                    break;
                case 5:
                    origin.x -= 1;
                    origin.z += 1;
                    lastValue = 6;
                    break;
                case 6:
                    origin.x += 1;
                    origin.z -= 1;
                    lastValue = 5;
                    break;
                case 7:
                    origin.x -= 1;
                    origin.z -= 1;
                    lastValue = 4;
                    break;
            }

            cube = Instantiate(cubePrefab);
            cube.transform.parent = parentTransform;
            cube.transform.position = origin;
        }

        Game.MaxPoints = cubes;
    }

}
