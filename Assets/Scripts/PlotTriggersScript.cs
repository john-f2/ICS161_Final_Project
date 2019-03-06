using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotTriggersScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.name == "StartPlotTrigger")
        {
            LevelManagerScript.instance.WriteText("My home has been trapped in winter for years. I must pray at the temple in hope it will end.");
        }
        else if (this.name == "NoticeArtifactTrigger")
        {
            LevelManagerScript.instance.WriteText("What is that stone? It looks like the one the goddess uses to control the seasons.");
        }
        else if (this.name == "TempleGatesClosedTrigger")
        {
            LevelManagerScript.instance.WriteText("The gates are closed, but I must get in. I'll find the two levers to open them.");
        }
        Destroy(this.gameObject);
    }
}
