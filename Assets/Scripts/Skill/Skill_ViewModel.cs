using System.ComponentModel;

public class Skill_ViewModel 
{
    //VIew의 데이터만 수정하는 역할을 맡는다.

    private int _userId;
    private string _name;
    private int _level;
    private string _iconName;

    public int UserId
    {
        get { return _userId; }
        set { _userId = value; }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if(_name == value) return;

            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public int Level
    {
        get { return _level; }
        set
        {
            if(_level == value) return;

            _level = value; 
            OnPropertyChanged(nameof(Level));
        }
    }

    public string IconName
    {
        get { return _iconName; }
        set
        {
            if(_iconName == value) return;

            _iconName = value;
            OnPropertyChanged(nameof(IconName));
        }
    }

    #region PropChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
