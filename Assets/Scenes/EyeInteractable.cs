using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class EyeInteractable : MonoBehaviour
{
    public bool IsHovered { get; set; }
    
    [SerializeField]
    private UnityEvent<GameObject> OnObjectHover;

    public GameObject LightButton;
    public GameObject Turnoff;
    public GameObject Turnon;
    public AudioSource Audio;


    /*
    [SerializeField]
    private Material OnHoverActiveMaterial;
    [SerializeField]
     private Material OnHoverInActiveMaterial;
    */

    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()=>meshRenderer = GetComponent<MeshRenderer>(); 
 

    // Update is called once per frame
    void Update()
    {
        if (IsHovered)
        {
            if (gameObject.CompareTag("LightUp")) { 
                OnObjectHover?.Invoke(gameObject);
                GameObject lightGameObject = GameObject.Find("LampLight");
                Light myLight = lightGameObject.GetComponent<Light>();
                myLight.intensity += 0.1f;
                if (myLight.intensity > 6)
                {
                    myLight.intensity = 6;
                }
            }
            else if (gameObject.CompareTag("LightDown"))
            {
                OnObjectHover?.Invoke(gameObject);
                GameObject lightGameObject = GameObject.Find("LampLight");
                Light myLight = lightGameObject.GetComponent<Light>();
                myLight.intensity -= 0.1f;
                if (myLight.intensity < 0)
                {
                    myLight.intensity = 0;
                }
            }
            else if (gameObject.CompareTag("LightFull"))
            {
                OnObjectHover?.Invoke(gameObject);
                GameObject lightGameObject = GameObject.Find("LampLight");
                Light myLight = lightGameObject.GetComponent<Light>();
                myLight.intensity = 6;
            }
            else if (gameObject.CompareTag("LightMiddle"))
            {
                OnObjectHover?.Invoke(gameObject);
                GameObject lightGameObject = GameObject.Find("LampLight");
                Light myLight = lightGameObject.GetComponent<Light>();
                myLight.intensity = 3;
            }
            else if (gameObject.CompareTag("LightNo"))
            {
                OnObjectHover?.Invoke(gameObject);
                GameObject lightGameObject = GameObject.Find("LampLight");
                Light myLight = lightGameObject.GetComponent<Light>();
                myLight.intensity = 0;
            }
            else if (gameObject.CompareTag("Object"))
            {
              
                OnObjectHover?.Invoke(gameObject);
                
            }
            else if (gameObject.CompareTag("Light"))
            {
                LightButton.SetActive(true);
                Turnoff.SetActive(false);
                Turnon.SetActive(true);
                OnObjectHover?.Invoke(gameObject);
              
            }
            else if (gameObject.CompareTag("LightOff"))
            {
                LightButton.SetActive(false);
                Turnon.SetActive(true);
                Turnoff.SetActive(false);
               
                OnObjectHover?.Invoke(gameObject);
                
            }
            else if (gameObject.CompareTag("TV"))
            {
                Turnon.SetActive(true);
                Turnoff.SetActive(false);
                Audio.Play();
            }
            else if (gameObject.CompareTag("Aircon"))
            {
                Turnoff.SetActive(false);
                Audio.Play();
            }

        }
        else
        {
            
        }
    }
}
