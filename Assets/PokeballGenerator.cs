using UnityEngine;
using UnityEngine.InputSystem;

public class PokeballGenerator : MonoBehaviour
{
    public GameObject pokeballPrefab;
    public Vector3 spawnPosition = new Vector3(31.3f, 0.35f, 22f);
    public Vector3 throwForce = new Vector3(120f, 170f, 0f);

    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject ball = Instantiate(pokeballPrefab, spawnPosition, Quaternion.identity);
            ball.GetComponent<PokeballController>().Throw(throwForce);
        }
    }
}