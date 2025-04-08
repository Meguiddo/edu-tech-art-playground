using UnityEngine;

public class Cannon : MonoBehaviour
{
    //cannon = 
    //un type d�objet � instancier = faire appara�tre, cr�er
    //un intervalle entre les tirs
    //une puissance de tir
    //(une rotation, direction)

    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private float spawnRate;
    [SerializeField] private float power;

    private float timer;

    private void Update()
    {
        //ex�cut� � chaque frame (60x par seconde par exemple)
        //tenir compte du temps �coul� depuis la derni�re frame,
        //et le retirer du temps restant avant le prochain tir
        timer = timer + Time.deltaTime;

        //timer > 3seconde?
        if(timer > spawnRate)
        {
            //instancier projectile et l�envoyer dans la direction du canon avec la puissance power
            Rigidbody copy = Instantiate(projectilePrefab, transform.position, transform.rotation);
            timer = 0;
            copy.AddForce(transform.forward * power, ForceMode.Impulse);
        }
    }
}
