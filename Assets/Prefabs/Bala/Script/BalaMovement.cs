using UnityEngine;

public class BalaMovement : MonoBehaviour
{
    // AÑADIR estas variables (para configurar en el Inspector)
    public GameObject explosionPrefab;
    public float velocidadBala = 4f; // Ya la tenías, pero la hacemos pública para consistencia

    // Flag para evitar doble destrucción (Recomendado)
    private bool yaExplotado = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(4f*Time.deltaTime,0,0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("¡Colisión detectada con: " + collision.gameObject.name + "!");
        DestruirBala();
    }

    public void DestruirBala()
    {
        if (yaExplotado) return;
        yaExplotado = true;

        // 1. Mostrar el efecto de explosión
        if (explosionPrefab != null)
        {
            // Instancia el efecto de explosión
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Destruye la explosión después de 3 segundos
            Destroy(explosion, 3f);
        }

        // 2. Destruir la bala actual
        Destroy(gameObject);
    }
}
