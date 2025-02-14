using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public GameObject drinkPrefab; // Prefab del objeto Drink
    public Transform spawnPoint;  // Punto donde aparece el objeto
    public float launchForce = 5f; // Fuerza con la que se lanza el objeto
    public float launchInterval = 2f; // Tiempo entre lanzamientos
    public bool launchRight = true; // Define la dirección (true = derecha, false = izquierda)

    private void Start()
    {
        StartCoroutine(LaunchDrinks());
    }

    private IEnumerator LaunchDrinks()
    {
        while (true)
        {
            yield return new WaitForSeconds(launchInterval);
            LaunchDrink();
        }
    }

    private void LaunchDrink()
    {
        GameObject drink = Instantiate(drinkPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = drink.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            float direction = launchRight ? 1f : -1f;
            rb.velocity = new Vector2(direction * launchForce, 0);
        }
    }
}
