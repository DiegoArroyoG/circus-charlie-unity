using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Final final;

    public GameObject aro;
    public GameObject caldera;
    public Renderer fondo;
    public float velocidad = 2;
    public List<GameObject> obstaculos;

    public bool start = false;
    public bool gameOver = false;
    public bool win = false;
    public bool spawnFinal = false;
    public GameObject menuInicio;
    public GameObject menuGameOver;
    public GameObject menuFinal;
    public int saltos = 0;
    private AudioSource claps;
    // Start is called before the first frame update
    void Start()
    {
        obstaculos.Add(Instantiate(aro, new Vector2(10, 2.46f), Quaternion.identity));
        obstaculos.Add(Instantiate(caldera, new Vector2(10, -2), Quaternion.identity));
        obstaculos.Add(Instantiate(aro, new Vector2(20, 2.46f), Quaternion.identity));
        obstaculos.Add(Instantiate(caldera, new Vector2(20, -2), Quaternion.identity));
        claps = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!start && !gameOver)
        {
            menuFinal.SetActive(false);
            menuGameOver.SetActive(false);
            menuInicio.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
            }
        }
        else if(gameOver)
        {
            menuFinal.SetActive(false);
            menuInicio.SetActive(false);
            menuGameOver.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if(win)
        {
            menuInicio.SetActive(false);
            menuGameOver.SetActive(false);
            menuFinal.SetActive(true);
            if(spawnFinal)
            {
                final.Spawn(JugadorStorage.index);
            }
            spawnFinal=false;
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            menuInicio.SetActive(false);
            menuGameOver.SetActive(false);
            menuFinal.SetActive(false);

            fondo.material.mainTextureOffset=fondo.material.mainTextureOffset+new Vector2(0.05f, 0)*Time.deltaTime;
            for (int i = 0; i < obstaculos.Count; i++)
            {
                if (obstaculos[i].transform.position.x <= -10)
                {
                    float randomObs = Random.Range(10, 20);
                    obstaculos[i].transform.position = new Vector3(randomObs, 2.46f, 0);
                    obstaculos[i+1].transform.position = new Vector3(randomObs, -2, 0);
                    saltos++;
                    if(saltos>=2)
                    {
                        claps.Play();
                        spawnFinal = true;
                        win = true;
                    } 
                }
                obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(-1, 0, 0) * velocidad * Time.deltaTime;
            }
        }
    }
}
