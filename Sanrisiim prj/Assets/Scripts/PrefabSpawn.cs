using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrefabSpawn : MonoBehaviour
{
    public GameObject Name = null;
    public GameObject Time = null;
    public GameObject FoodImage = null;
    public GameObject PrefabFav = null;
    public GameObject parent = null;
    public int BoolControl = 0;
    ItemsConnect IC = new ItemsConnect();
    
    // Start is called before the first frame update
    public void Start()
    {
        

        Name = GameObject.FindGameObjectWithTag("Name");
        Time = GameObject.FindGameObjectWithTag("Time");
        FoodImage = GameObject.FindGameObjectWithTag("FoodImage");
        parent = GameObject.Find("Canvas/ScrollArea/FavList");
        BoolControl = IC.BoolControl;
        

        


        for (int i = 0, Count = SceneManager.sceneCountInBuildSettings; i < Count ; i++)
        {
            if (IC.FavData[i].BoolControl == 1)
            {
                GameObject instance = Instantiate(PrefabFav, parent.transform);


                instance.transform.localScale = new Vector3(1f, 1f);
            }
        }
        


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
