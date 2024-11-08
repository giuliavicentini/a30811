using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Desafio : MonoBehaviour
{
   {

    public GameObject Protege;
    // public (nomeclatura) ...;
    public GameObject Zona1;
    public GameObject Zona2;
    public GameObject Zona3;
    public GameObject Zona4;
    public GameObject Zona5;
    public GameObject Zona6;
    public GameObject Pla;
    public GameObject Over;
    public GameObject Wins;



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnCollisionEnter2D(Collision2D other)
   {
        
        if(other.gameObject.CompareTag ("Z1"))
        {
           // FindObjectOfType<GameObject>().DiminuirQuantidadeDeBlocos();
            //nstantiate(somDoBloco, transform.position, transform.rotation);
            
             
             Zona1.SetActive (false);
 
           
        }
        else if(other.gameObject.CompareTag("Z2")){
            Zona2.SetActive (false);
        }
        else if(other.gameObject.CompareTag("Z3")){
            Zona3.SetActive (false);
        }
        else if(other.gameObject.CompareTag("Z4")){
            Zona4.SetActive (false);
        }
        else if(other.gameObject.CompareTag("Z5")){
            Zona5.SetActive (false);
        }
        else if(other.gameObject.CompareTag("Z6")){
            Zona6.SetActive (false);
        }
        else if(other.gameObject.CompareTag("Over")){
            Over.SetActive (false);
            Play.SetActive(false);
        }
        else if(other.gameObject.CompareTag("Wins")){
            Wins.SetActive (false);
            Play.SetActive(false);
        }
     }

