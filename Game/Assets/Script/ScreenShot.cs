using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class ScreenShot : MonoBehaviour {
    static int Count=499;
    public Camera camera;       //보여지는 카메라.
 
    private int resWidth;
    private int resHeight;
    string path;
    // Use this for initialization
    void Start () {
        resWidth = Screen.width;
        resHeight = Screen.height;
        path = Application.dataPath+"/ScreenShot/";
        Debug.Log(path);
        Shot();
        
    }
 
    public void Shot()
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        if (!dir.Exists)
        {
            Directory.CreateDirectory(path);
        }
        if (Count < (int)0)
        {
            Quit();
        }
        string name;
        name = Count + ".png";
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        camera.targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        Rect rec = new Rect(0, 0, screenShot.width, screenShot.height);
        camera.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        screenShot.Apply();
 
        byte[] bytes = screenShot.EncodeToPNG();
        File.WriteAllBytes(name, bytes);
        SceneManager.LoadScene("Main");
        Count -= 1;
        Debug.Log(Count);
    }
    public static void Quit()
     {
         #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
         #elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
         #else
         Application.Quit();
         #endif
     }
}