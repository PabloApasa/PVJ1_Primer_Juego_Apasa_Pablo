using UnityEngine;

/**public class SpawnBalas : MonoBehaviour
{
    [SerializeField]private GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CrearBala",2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CrearBala()
    {
        Instantiate(bala,transform.position,transform.rotation);
    }
}*/

public class SpawnBalas : MonoBehaviour
{
    // velcidad de la bala
    public float velocidadBala = 10f;
    // tiempo de vida de la bala
    public float tiempoVidaBala = 5f;
    // efecto particulas
    public GameObject explosionPrefab;

    private void Start()
    {
        Destroy(gameObject, tiempoVidaBala);
    }

    private void Update()
    {
        transform.Translate(-Vector3.right * velocidadBala * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision con: " + collision.gameObject.name);
        // llama a la funcion que gestiona la destruccion y el efecto
        DestruirBala();

    }

    private void DestruirBala()
    {
        //efecto de exxplosion
        if (explosionPrefab != null)
        {
            // efecto explosion en la posicion de la bala
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);

            // destruir el efecto de explosion despues de 1 segundos
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }


}
