using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // load file of student names
    // on button click in UI, randomly pick a student name
    // assign chosen student name to test object in GUI

    public string fileName = "default.txt";
    public Text displayName;

    private string[] studentNames;
 

    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        Debug.Log(studentNames[0]);
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, studentNames.Length);
        string name = this.studentNames[i];
        displayName.text = name;
    }

    private void LoadStudentNames()
    {
        this.studentNames = File.ReadAllLines(fileName);
    }
}
