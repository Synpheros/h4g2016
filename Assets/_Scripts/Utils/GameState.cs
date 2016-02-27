using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameState {
    private static GameState instance;

    public static GameState S
    {
        get {
            if (instance == null)
                instance = new GameState ();
            return instance;
        }
    }

    public class SceneDef
    {
        public string title;
        public string subtitle;
        public string next_scene;

        public SceneDef(string title, string subtitle, string next_scene){
            this.title = title;
            this.subtitle = subtitle;
            this.next_scene = next_scene;
        }
    }

    private List<SceneDef> scenes;
    private GameState()
    {
        scenes = new List<SceneDef> ();

        scenes.Add (new SceneDef("Lunes","Instituto - 9:32 AM","day1"));
        scenes.Add (new SceneDef("Lunes","Casa - 10:46 PM","room1"));
        scenes.Add (new SceneDef("Lunes","","dream1"));

        scenes.Add (new SceneDef("Martes","Instituto - 9:56 AM","day2"));
        scenes.Add (new SceneDef("Martes","Casa - 9:04 PM","room2"));
        scenes.Add (new SceneDef("Martes","","dream2"));

        scenes.Add (new SceneDef("Miercoles","Instituto - 10:05 AM","day3"));
        scenes.Add (new SceneDef("Miercoles","Casa - 9:23 PM","room3"));
        scenes.Add (new SceneDef("Miercoles","","dream3"));

        scenes.Add (new SceneDef("Jueves","Instituto - 9:28 AM","day4"));
        scenes.Add (new SceneDef("Jueves","Casa - 10:04 PM","room4"));
        scenes.Add (new SceneDef("Jueves","","dream4"));

        scenes.Add (new SceneDef("Martes","Instituto - 9:47 AM","day5"));
        scenes.Add (new SceneDef("Martes","Casa - 10:28 PM","room5"));
        scenes.Add (new SceneDef("Martes","","dream5"));
    }

    public SceneDef nextScene()
    {
        SceneDef ret = scenes [0];
        scenes.Remove (ret);

        return ret;
    }
}
