using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class TempProfileUI : MonoBehaviour
{
    [SerializeField] private Text Name;

    private TempProfile_ViewModel _vm;

    private void OnEnable()
    {
        if(_vm == null)
        {
            _vm = new TempProfile_ViewModel();
            _vm.PropertyChanged += OnPropertyChanged;
            _vm.RegisterEventOnEnable(true);

            //юс╫ц©К
            _vm.Id = 2;

            _vm.RefreshViewModel(_vm.Id);
        }
    }

    private void OnDisable()
    {
        if( _vm != null )
        {
            _vm.RegisterEventOnEnable(false);
            _vm.PropertyChanged -= OnPropertyChanged;
            _vm = null;
        }
    }

    private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        switch (args.PropertyName)
        {
            case nameof(_vm.Name):
                Name.text = _vm.Name;
                break;
        }
    }
}
