using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using ViewModel.Extensions;

public class Skill_View : MonoBehaviour
{
    [SerializeField] private Text _Name;
    [SerializeField] private Text _Level;
    [SerializeField] private Image _Icon;

    //ºä ¸ðµ¨À» µé°í ÀÖ´Ù.
    private Skill_ViewModel _vm;

    private void OnEnable()
    {
        if(_vm == null)
        {
            _vm = new Skill_ViewModel();
            _vm.PropertyChanged += OnPropertyChanged;
            _vm.RegisterEventsOnEnable();
            _vm.RefreshSkillViewModel();
        }
    }

    private void OnDisable()
    {
        if(_vm != null)
        {
            _vm.UnRegisterEventsOnDisable();
            _vm.PropertyChanged -= OnPropertyChanged;
            _vm = null;
        }
    }

    private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        switch(args.PropertyName)
        {
            case nameof(_vm.Name):
                _Name.text = _vm.Name;
                break;
            case nameof(_vm.Level):
                _Level.text = $"LV.{_vm.Level}";
                break;
            case nameof(_vm.IconName):
                //
                break;
        }
    }

    private void LevelEffectPlay()
    {

    }
}
