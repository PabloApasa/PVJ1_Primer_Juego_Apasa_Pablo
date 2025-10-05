using UnityEngine;

public class BalaMovement : MonoBehaviour
{
    // A�ADIR estas variables (para configurar en el Inspector)
    public GameObject explosionPrefab;
    public float velocidadBala = 4f; // Ya la ten�as, pero la hacemos p�blica para consistencia

    // Flag para evitar doble destrucci�n (Recomendado)
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
        Debug.Log("�Colisi�n detectada con: " + collision.gameObject.name + "!");
        DestruirBala();
    }

    public void DestruirBala()
    {
        if (yaExplotado) return;
        yaExplotado = true;

        // 1. Mostrar el efecto de explosi�n
        if (explosionPrefab != null)
        {
            // Instancia el efecto de explosi�n
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Destruye la explosi�n despu�s de 3 segundos
            Destroy(explosion, 3f);
        }

        // 2. Destruir la bala actual
        Destroy(gameObject);
    }
}
