namespace ViewModel.Extensions
{
    public static class Skill_ViewModel_Extension
    {
        public static void RefreshSkillViewModel(this Skill_ViewModel viewModel)
        {
            int tempId = 2;
            GameLogicManager.Inst.RefreshCharacterInfo(tempId, viewModel.OnRefreshViewModel);
        }

        public static void OnRefreshViewModel(this Skill_ViewModel viewModel, int userId, string name, int level)
        {
            viewModel.UserId = userId;
            viewModel.Name = name;
            viewModel.Level = level;
        }

        //public static void BintRegisterEventsOnEnable(this Skill_ViewModel viewModel, bool isRegister)
        //{
        //    if(isRegister)
        //    {
        //        GameLogicManager
        //    }
        //    else
        //    {

        //    }
        //}

        public static void RegisterEventsOnEnable(this Skill_ViewModel viewModel)
        {
            GameLogicManager.Inst.RegisterLevelUpCallback(viewModel.OnResponseLevelUp);
        }

        public static void UnRegisterEventsOnDisable(this Skill_ViewModel viewModel)
        {
            GameLogicManager.Inst.UnRegisterLevelUpCallback(viewModel.OnResponseLevelUp);
        }

        public static void OnResponseLevelUp(this Skill_ViewModel viewModel, int userId, int level)
        {
            if (viewModel.UserId != userId) return;

            viewModel.Level = level;
        }
    }

}
