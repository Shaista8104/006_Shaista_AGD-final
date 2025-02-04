using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cubePrefab; // Assign the cube prefab in the Inspector
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCubes()); // Start spawning cubes
    }
    IEnumerator SpawnCubes()
    {
        while (true) // Infinite loop
        {
            GameObject newCube = Instantiate(cubePrefab, Vector3.zero, Quaternion.identity); // Spawn at (0,0,0)
            StartCoroutine(MoveCube(newCube, new Vector3(0, 0, 5), 2f)); // Move cube to (0,0,5) in 2 sec
            yield return new WaitForSeconds(2f); // Wait 2 seconds before spawning next cube
        }
    }

    IEnumerator MoveCube(GameObject obj, Vector3 target, float duration)
    {
        Vector3 startPos = obj.transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            obj.transform.position = Vector3.Lerp(startPos, target, elapsedTime / duration); // Smooth movement
            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        obj.transform.position = target; // Ensure it reaches the exact position
        Destroy(obj); // Destroy the cube after reaching the target
    }

}

