using UnityEngine;

public class EjemploInvokes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("MostrarMensajeUnico", 5f);
        
        InvokeRepeating("MostrarMensajeContinuo", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarMensajeUnico()
    {
        Debug.Log("ejecutado luego de x segundos");
    }

    public void MostrarMensajeContinuo ()
    {
        Debug.Log("Programacion de VIdeoJuegos 1");
    }
}
