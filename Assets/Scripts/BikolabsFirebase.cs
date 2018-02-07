using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;

public class BikolabsFirebase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

public class MyScript : MonoBehaviour
{
  void Start()
  {
    // Set this before calling into the realtime database.
    FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://bikolabs-ar-test.firebaseio.com/");
  }
}

// Update is called once per frame
void Update () {
		
	}
}
