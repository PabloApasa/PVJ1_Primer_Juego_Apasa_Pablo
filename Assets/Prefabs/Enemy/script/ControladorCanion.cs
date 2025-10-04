using UnityEngine;

public class ControladorCanion : MonoBehaviour
{
    public GameObject prefabDeLaBala;// Prefab de la bala a instanciar

    public float intervaloDeDisparo = 2f; // Intervalo de tiempo entre disparos en segundos
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //llama a la funcion disparar cada intervaloDeDisparo segundos
        InvokeRepeating("DispararBala", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispararBala()
    {
        //verificar si el prefab esta asignado
        if (prefabDeLaBala != null)
        {
            // Instanciar la bala en la posicion y rotacion del canion
            Instantiate(prefabDeLaBala, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogWarning("El prefab de la bala no esta asignado en el inspector.");
        }
    }
}
