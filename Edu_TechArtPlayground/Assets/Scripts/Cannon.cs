using UnityEngine;

public class Cannon : MonoBehaviour
{
    //cannon = 
    //un type d’objet à instancier = faire apparaître, créer
    //un intervalle entre les tirs
    //une puissance de tir
    //(une rotation, direction)

    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private float spawnRate;
    [SerializeField] private float power;

    private float timer;

    private void Update()
    {
        //exécuté à chaque frame (60x par seconde par exemple)
        //tenir compte du temps écoulé depuis la dernière frame,
        //et le retirer du temps restant avant le prochain tir
        timer = timer + Time.deltaTime;

        //timer > 3seconde?
        if(timer > spawnRate)
        {
            //instancier projectile et l’envoyer dans la direction du canon avec la puissance power
            Rigidbody copy = Instantiate(projectilePrefab, transform.position, transform.rotation);
            timer = 0;
            copy.AddForce(transform.forward * power, ForceMode.Impulse);
        }
    }
}
