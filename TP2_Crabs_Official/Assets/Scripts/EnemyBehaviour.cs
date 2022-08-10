using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyBehaviour : MonoBehaviour

{

    //Variable de transformation Chateau et variable de Naviagation des enemis

    public Transform Castle;
    private NavMeshAgent _agent;
    public Animation _animation;


    //Au lancement du jeu, le navMesAgent est store dans la variable _agent et Castle est initie avec la position transform du gameObjet chateau
    void Start()
    {
 
        _agent = GetComponent<NavMeshAgent>();

        Castle = GameObject.Find("Chateau").transform;

        _animation = GetComponent<Animation>();
    }

    // A chaque frame la destination de _agent est update avec la position de Castle
    private void Update()
    {
        _agent.destination = Castle.position;

        //_animation.Play("walk");


        Debug.Log("Player Detected - Attack!");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Chateau")
        {
            _animation.Play("attack1");
        }

    }
}
