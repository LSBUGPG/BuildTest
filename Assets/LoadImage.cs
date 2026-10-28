using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    [SerializeField] private Image image;

    void Start()
    {
        string path = "Assets/Backgrounds";
        List<string> files = new(Directory.EnumerateFiles(path, "*.png"));
        int count = files.Count;
        int random = Random.Range(0, count);
        image.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(files[random]);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("BuildTest");
    }
}
