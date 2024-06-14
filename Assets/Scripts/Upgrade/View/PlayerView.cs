using System.ComponentModel;
using UnityEngine;
using ViewModel.Extensions;

public class PlayerView : MonoBehaviour
{
    [SerializeField] TextMesh TextMesh_Name;
    [SerializeField] TextMesh TextMesh_Level;
    [SerializeField] Animator Animator_Player;
    [SerializeField] GameObject Prefab_SpecialLevelUp;

    //private PlayerViewModel _vm;

    private TempProfile_ViewModel _profile;

    private void OnEnable()
    {
        //if (_vm == null)
        //{
        //    _vm = new PlayerViewModel();
        //    _vm.PropertyChanged += OnPropertyChanged;
        //    _vm.RegisterEventsOnEnable();
        //    _vm.RefreshViewModel();
        //}

        if(_profile == null)
        {
            _profile = new TempProfile_ViewModel();
            _profile.PropertyChanged += OnPropertyChanged;
            _profile.RegisterEventOnEnable(true);
            _profile.RefreshViewModel(2);
        }
    }

    private void OnDisable()
    {
        //if (_vm != null)
        //{
        //    _vm.UnRegisterOnDisable();
        //    _vm.PropertyChanged -= OnPropertyChanged;
        //    _vm = null;
        //}

        if(_profile != null)
        {
            _profile.RegisterEventOnEnable(false);
            _profile.PropertyChanged -= OnPropertyChanged;
            _profile = null;
        }
    }

    private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(_profile.Name):
                TextMesh_Name.text = $"{_profile.Name}";
                break;
            //case nameof(_vm.Level):
            //    TextMesh_Level.text = $"Lv.{_vm.Level}";
            //    Animator_Player.SetTrigger("LevelUp");
            //    CheckSpecialLevelUP(_vm.Level);
            //    break;
        }
    }

    private void CheckSpecialLevelUP(int level)
    {
        if (level % 10 == 0)
        {
            Instantiate(Prefab_SpecialLevelUp, this.transform);
        }
    }


}
