using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.IO;

[System.Serializable]

public class QuestionHandler : MonoBehaviour
{
    private List<QuestionAnswer> qa = new List<QuestionAnswer>();
    private QuestionLoader ql;
    public QuestionAnswer current;
    private string path;

    public void Awake()
    {
        path = Application.dataPath + "/MathQ/";
    }

    public void loadQuestion()
    {
        current = qa[0];
        qa.RemoveAt(0);
    }

    public string getCurrentQuestion()
    {
        return current.getQuestion();
    }

    public string getCurrentAnswer()
    {
        return current.getAnswer();
    }

    public void load(string set)
    {
        //string line;
        //StreamReader file;
        //switch (set)
        //{
        //    case "addition":
        //        path = Application.dataPath + "/MathQ/SampleQuestion.txt";
        //        break;
        //}

        //file = new System.IO.StreamReader(path);
        //while ((line = file.ReadLine()) != null)
        //{
        //    string[] split = line.Split(',');
        //    qa.Add(new QuestionAnswer(split[0], split[1]));
        //}
        qa.Add(new QuestionAnswer("2+2", "4"));
        qa.Add(new QuestionAnswer("5+7", "12"));
        qa.Add(new QuestionAnswer("4-2", "2"));
        qa.Add(new QuestionAnswer("6+11", "17"));
        qa.Add(new QuestionAnswer("2*2", "4"));
        loadQuestion();
    }
}

//code from:
//https://stackoverflow.com/questions/273313/randomize-a-listt
static class Extensions
{
    private static System.Random rng = new System.Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

