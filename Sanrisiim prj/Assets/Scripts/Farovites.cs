using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Farovites : MonoBehaviour
{
    public Sprite NotCheck;
    public Sprite IsCheck;
    public Button AddFavorite;

    public int BoolControl = 0;
    public GameObject parent;
    public GameObject[] PrefabFav = new GameObject[23];



    private Scene scene;

    public List<int> Current = new List<int>(23);
    
    


    public void Awake()
    {

       

        PlayerPrefs.SetInt(scene.name + "BoolControl", BoolControl);
        //PlayerPrefs.SetInt("Current", Current[SceneManager.GetActiveScene().buildIndex]);

    }

    public void Deminder()
    {
        
    }





    public void OnClick()
    {
        if (BoolControl == 0)
        {
            BoolControl++;
            //Current[SceneManager.GetActiveScene().buildIndex]++;
        }
        else
        {
            BoolControl--;
           // Current[SceneManager.GetActiveScene().buildIndex]--;
        }
    }

    private void ChangeSprite()
    {
        if (BoolControl == 1)
        {
            AddFavorite.image.sprite = IsCheck;
            Current[SceneManager.GetActiveScene().buildIndex] = 1;
        }
        else 
        {
            AddFavorite.image.sprite = NotCheck;
            Current[SceneManager.GetActiveScene().buildIndex] = 0;
        }
            
    }


    public void Checker()
    {
        PlayerPrefs.SetInt(scene.name + "BoolControl", BoolControl);
        PlayerPrefs.SetInt("Current", Current[SceneManager.GetActiveScene().buildIndex]);
    }



    void Start()
    {

        // Set the camera's position to be at the top of the screen.
        // transform.position = new Vector3(0, 0, 10);

        // Set the camera's rotation to be looking down.
        GameObject Finder = GameObject.FindGameObjectWithTag("FavList");
        if (SceneManager.GetActiveScene().buildIndex == 22)
        {
            Finder.transform.position = transform.position = new Vector3(0, -2000, 0);
        }
        


        scene = SceneManager.GetActiveScene();

        BoolControl = PlayerPrefs.GetInt(scene.name + "BoolControl");

        for (int i = 0; i < Current.Count; i++)
        {
            Current[i] = PlayerPrefs.GetInt($"Current{i}");
        }
        

        parent = GameObject.Find("Canvas/ScrollArea/FavList");




        if (SceneManager.GetActiveScene().buildIndex == 22)
        {
            for (int i = 0; i < Current.Count; i++)
            {
                if (PrefabFav[i] != null && Current[i] == 1)
                {
                    GameObject instance = Instantiate(PrefabFav[i], parent.transform);


                    
                    //switch (Current[i])
                    //{
                    //    case 5:
                    //        instance.AddComponent<Main>().M10_Smuz();
                    //        break;
                    //    case 6:
                    //        instance.AddComponent<Main>().M10_Pudding();
                    //        break;
                    //    case 7:
                    //        instance.AddComponent<Main>().M10_Tvor();
                    //        break;
                    //    case 8:
                    //        instance.AddComponent<Main>().M10_Kussia();
                    //        break;
                    //    case 9:
                    //        instance.AddComponent<Main>().M20_EggCake();
                    //        break;
                    //    case 10:
                    //        instance.AddComponent<Main>().M20_ApplePan();
                    //        break;
                    //    case 11:
                    //        instance.AddComponent<Main>().M20_EgggPomid();
                    //        break;
                    //    case 12:
                    //        instance.AddComponent<Main>().M20_Tamago();
                    //        break;
                    //    case 13:
                    //        instance.AddComponent<Main>().M40_Sand();
                    //        break;
                    //    case 14:
                    //        instance.AddComponent<Main>().M40_Blyan();
                    //        break;
                    //    case 15:
                    //        instance.AddComponent<Main>().M40_ZapTvor();
                    //        break;
                    //    case 16:
                    //        instance.AddComponent<Main>().M40_Batoni();
                    //        break;
                    //    case 17:
                    //        instance.AddComponent<Main>().M60_Rulet();
                    //        break;
                    //    case 18:
                    //        instance.AddComponent<Main>().M60_Poke();
                    //        break;
                    //    case 19:
                    //        instance.AddComponent<Main>().M60_Spin();
                    //        break;
                    //    case 20:
                    //        
                    //        break;


                    //    default:
                    //        break;
                    //}
                    instance.transform.localScale = new Vector3(1f, 1f);

                }
                
            }
        }


    }




    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
        Checker();
        for (int i = 0; i < Current.Count; i++)
        {
            PlayerPrefs.SetInt($"Current{SceneManager.GetActiveScene().buildIndex}", Current[SceneManager.GetActiveScene().buildIndex]);
        }
            
        
    }




}
