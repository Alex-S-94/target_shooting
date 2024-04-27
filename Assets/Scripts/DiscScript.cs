using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscScript : MonoBehaviour
{
  public discs disc;

  void OnMouseDown ()
  {
  transform.parent.GetComponent<TargetScript>().ClickFuntion(disc);
  }

}
