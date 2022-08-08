using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    //initiation d'une variable enemies, position X, postition Y et nombre d'enemies
    public GameObject enemies;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {

        //Initiation d'une coroutine qui reprend tant que la condition de l'enumerator Enemy drop n'est pas remplie

        StartCoroutine(EnemyDrop());

    }

    //Enumerator enemyDrop, Tant que enemyCount est plus petit que 10, le enumerator creer des instances du game object store dans enemies dans un range random de 2 vecteurs
    //3. de 4 a 18 et de 1 a 13. le enumerator yield un retour de 1.5 second puis incremente le enemie count.
    IEnumerator EnemyDrop()
    {

        while (enemyCount < 10)
        {


            xPos = Random.Range(25, 35);
            zPos = Random.Range(14, 40);
            Instantiate(enemies, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            enemyCount += 1;

        }
    }
}
