using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  ����� ��� ������ � �������� �������
/// </summary>
public class InputImages : MonoBehaviour
{
    public const int InputListsCount = 2;
    public List<Sprite> firstInputSpriteList;
    public List<Sprite> secondInputSpriteList;
    private List<Sprite>[] inputLists = new List<Sprite>[InputListsCount];
    private List<Sprite> imageList;
    void Start()
    {
        inputLists[0] = firstInputSpriteList;
        inputLists[1] = secondInputSpriteList;
    }
    public void Initialize()
    {
        Start();
        var randomIndex = Random.Range(0, inputLists.Length);
        imageList = inputLists[randomIndex];
        Debug.Log(inputLists[1][1]);
    }
    public List<Sprite> GetList()
    {
        return imageList;
    }
    public int GetListLength()
    {
        return imageList.Count;
    }
    public Sprite GetImage(int indexInArray)
    {
        return imageList[indexInArray];
    }
    public string GetImageName(int indexInList)
    {
        return imageList[indexInList].name;
    }
}
