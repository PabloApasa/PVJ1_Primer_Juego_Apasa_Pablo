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

    /// <summary>
    /// atributos de la estrategia de movimiento.
    /// </summary>
    private Vector3 speed;
    private IMovementStrategy movementStrategy;

    /// <summary>
    /// clase Player
    /// </summary>
    private Player player;
    #endregion

    #region Ciclo de vida del Script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300);
        tiempoDesdeUltimaFuerza = 0f;
        IntervaloTiempo = 2f;
        player = new Player(5f, 5f);

        speed = new Vector3(5f, 0, 0);
        SetMovementStrategy(new SmoothMovement());
        SetMovementStrategy(new AcelerateMovement());
    }

    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }
    // Update is called once per frame
    private void Update()
    {
        MovePlayer();

    }

    public void MovePlayer()
    {
        movementStrategy.Move(transform, player);
    }

    // Logica para aplicarcion de fuerzas 
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
