
using System.Xml.Serialization;

public static class TempProfil_Extension
{
    public static void RefreshViewModel(this TempProfile_ViewModel viewModel, int tempId)
    {
        GameLogicManager.Inst.RefreshCharacterInfo(tempId, viewModel.OnRefreshViewModel);
    }

    public static void OnRefreshViewModel(this TempProfile_ViewModel viewModel, int tempId, string name)
    {
        viewModel.Id = tempId;
        viewModel.Name = name;
    }

    public static void RegisterEventOnEnable(this TempProfile_ViewModel viewModel, bool isRegister)
    {
        if (isRegister)
        {
            GameLogicManager.Inst.RegisterNameCallback(viewModel.OnResponseNameChangeed);
        }
        else
        {
            GameLogicManager.Inst.UnRegisterNameCallback(viewModel.OnResponseNameChangeed);
        }
    }

    public static void OnResponseNameChangeed(this TempProfile_ViewModel viewModel, int useId, string name)
    {
        if(viewModel.Id != useId) return;

        viewModel.Name = name;
    }
}
