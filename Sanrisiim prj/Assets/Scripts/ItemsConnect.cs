using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ItemsConnect : MonoBehaviour
{
    public Farovites FV;
    public Image Test = null;
    public int CurrentScene;
    private Scene scene;
    public int BoolControl = 0;

    public struct FavoriteData
    {
        public string Name;
        public string Time;
        public Sprite FoodImage;
        public int BoolControl;
        //public int CurrentScene;
    }


    private void Awake()
    {
        FV = GameObject.FindGameObjectWithTag("Button").GetComponent<Farovites>();
    }
    [SerializeField]
    public FavoriteData[] FavData = new FavoriteData[23];
    
    

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        BoolControl = FV.BoolControl;
        //CurrentScene = SceneManager.GetActiveScene().buildIndex;

        //FavData[SceneManager.GetActiveScene().buildIndex].CurrentScene = CurrentScene;        
            FavData[SceneManager.GetActiveScene().buildIndex].BoolControl = PlayerPrefs.GetInt(scene.name + "BoolControl");

            FavData[SceneManager.GetActiveScene().buildIndex].Name = GameObject.FindGameObjectWithTag("Name").GetComponent<Text>().text;

            FavData[SceneManager.GetActiveScene().buildIndex].Time = GameObject.FindGameObjectWithTag("Time").GetComponent<Text>().text;

            FavData[SceneManager.GetActiveScene().buildIndex].FoodImage = GameObject.FindGameObjectWithTag("FoodImage").GetComponent<Image>().sprite;


        


        Debug.Log(FavData[17].BoolControl);
        Debug.Log(FavData[17].Name);
        Debug.Log(FavData[17].Time);
        Debug.Log(FavData[17].FoodImage);

        Debug.Log(FavData[SceneManager.GetActiveScene().buildIndex].BoolControl);
        Debug.Log(FavData[SceneManager.GetActiveScene().buildIndex].Name);
        Debug.Log(FavData[SceneManager.GetActiveScene().buildIndex].Time);
        Debug.Log(FavData[SceneManager.GetActiveScene().buildIndex].FoodImage);



    }

    // Update is called once per frame
    void Update()
    {
        FV.Checker();
    }
}