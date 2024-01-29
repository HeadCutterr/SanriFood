using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text SRZ; //Строка меняющая название

    public void Update()
    {
        SRZ.text = "SanriFood"; // в скобках текст на что меняется название
        SRZ.color = Color.white;
    }

    public void More()
    {
        SceneManager.LoadScene(21);
    }

    public void Favorite()
    {
        SceneManager.LoadScene(22);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0); // все  SceneManager.LoadScene, это загрузка сцены с определённой цифрой, цифра пишется в круглых скобочках

    }

    public void Min5_Rec()
    {
        SceneManager.LoadScene(1);

    }

    public void Min15_Rec()
    {
        SceneManager.LoadScene(2);

    }

    public void Min30_Rec()
    {
        SceneManager.LoadScene(3);

    }

    public void Min60_Rec()
    {
        SceneManager.LoadScene(4);

    }

    public void M10_Smuz()
    {
        SceneManager.LoadScene(5);

    }
    public void M10_Pudding()
    {
        SceneManager.LoadScene(6);

    }
    public void M10_Tvor()
    {
        SceneManager.LoadScene(7);

    }
    public void M10_Kussia()
    {
        SceneManager.LoadScene(8);

    }

    //20 минут
    public void M20_EggCake()
    {
        SceneManager.LoadScene(9);

    }
    public void M20_ApplePan()
    {
        SceneManager.LoadScene(10);

    }
    public void M20_EgggPomid()
    {
        SceneManager.LoadScene(11);

    }
    public void M20_Tamago()
    {
        SceneManager.LoadScene(12);

    }

    //40 минут 
    public void M40_Sand()
    {
        SceneManager.LoadScene(13);

    }
    public void M40_Blyan()
    {
        SceneManager.LoadScene(14);

    }
    public void M40_ZapTvor()
    {
        SceneManager.LoadScene(15);

    }
    public void M40_Batoni()
    {
        SceneManager.LoadScene(16);

    }

    //60 минут
    public void M60_Rulet()
    {
        SceneManager.LoadScene(17);

    }
    public void M60_Poke()
    {
        SceneManager.LoadScene(18);

    }
    public void M60_Spin()
    {
        SceneManager.LoadScene(19);

    }
    public void M60_Kiks()
    {
        SceneManager.LoadScene(20);

    }
}
