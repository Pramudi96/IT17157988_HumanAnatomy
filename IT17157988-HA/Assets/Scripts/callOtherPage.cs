using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callOtherPage : MonoBehaviour
{

    public void changePageScene(string scenename){
		
		
	Application.LoadLevel(scenename);
    }
}
