using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ; 

namespace DefaultNamespace{
public class Activatin_bouton : MonoBehaviour
{
	[SerializeField] private Image backgroundImage = default;
	private bool isToggled = false;

	public void OnClick(){
		//isToggled =! isToggled;
		//backgroundImage.color = isToggled ? Color.blue : Color.red; // remplace un if 
		SceneManager.LoadScene("SampleScene");
	}
}
}
