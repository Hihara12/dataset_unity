using UnityEngine;
using System.Collections;

public class ScreenRecorder : MonoBehaviour
{
    public int framerate = 60;
    public int superSize;
    public bool autoRecord;
    public int photonumber;

    int frameCount;
    bool recording;
    int shotnumber;
    string modelname;
    string filename;

    void Start ()
    {
        if (autoRecord) StartRecording ();
    }

    void StartRecording ()
    {
        foreach (GameObject obj in UnityEngine.Object.FindObjectsOfType(typeof(GameObject))){
            // シーン上に存在するオブジェクトならば処理.
            if (obj.activeInHierarchy){
                if(obj.name != "defaulut" && obj.name != "Directional Light" && obj.name != "MainCamera" ){
                    modelname = obj.name;
                    filename = "Capture_" + modelname;
                    //sfilename2 = filename + "/shot";
                    //Debug.Log(obj.name);
                }
            }
        }

        System.IO.Directory.CreateDirectory (filename);
        Time.captureFramerate = framerate;
        frameCount = -1;
        recording = true;
    }

    void Update ()
    {
        if(shotnumber + 1 <= photonumber){
            if (recording){
                if (Input.GetMouseButtonDown (0)){
                    recording = false;
                    enabled = false;
                }
                else if (frameCount % 60 == 0){
                    shotnumber++;
                    var name = "Capture/shot" + shotnumber + ".png";
                    ScreenCapture.CaptureScreenshot (name, superSize);
                    Debug.Log ((shotnumber).ToString() + " shots");
                }

                frameCount++;
            }
        }
    }

    void OnGUI ()
    {
        if (!recording && GUI.Button (new Rect (0, 0, 200, 50), "Start Recording"))
        {
            StartRecording ();
            Debug.Log ("Click Game View to stop recording.");
        }
    }
}
