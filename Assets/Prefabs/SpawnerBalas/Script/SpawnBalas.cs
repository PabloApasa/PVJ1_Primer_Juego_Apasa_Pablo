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

    private void Start()
    {
        Destroy(gameObject, tiempoVidaBala);
    }

    private void Update()
    {
        transform.Translate(-Vector3.right * velocidadBala * Time.deltaTime);
    }

    
}
