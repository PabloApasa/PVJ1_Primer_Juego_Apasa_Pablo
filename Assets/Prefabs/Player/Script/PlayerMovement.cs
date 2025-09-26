using UnityEngine;
/// <summary>
/// Permite el comportamiento de movimiento del jugador.
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// fuerza utilizada para aplicar el movimiento.
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Represanta el tiempo transcurrido desde la ultima vez que se aplico una fuerza.
    /// </summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo debe aplicarse una fuerza.
    /// </summary>
    private float IntervaloTiempo;
    #endregion

    #region Ciclo de vida del Script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300);
        tiempoDesdeUltimaFuerza = 0f;
        IntervaloTiempo = 2f;
    }

    // FixedUpdate 
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= IntervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
    #endregion


}
