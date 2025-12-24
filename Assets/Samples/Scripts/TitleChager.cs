using UnityEngine;
using OneShot.NativeTools;
public class TitleChager : MonoBehaviour
{
    private string[] randomTitles = new[]
    {
        "Testing",
        "OneShot sample test",
        "NativeToolKit test"
    };
    public void Trigger()
    {
        WindowUtil.SetWindowTitle(randomTitles[Random.Range(0, randomTitles.Length)]);
    }
}
