//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreDailies.cs
using RBot;

public class FungiforaFunGuy
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreDailies Daily = new();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        Daily.FungiforaFunGuy();

        Core.SetOptions(false);
    }
}