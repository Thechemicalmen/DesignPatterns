var textEditor = new TextEditor();
var careTaker = new Caretaker(textEditor);

while (true)
{
    Console.Clear();
    Console.WriteLine("Tapez une phrase et finir par Entrée");
    Console.WriteLine("Tapez 'u' pour annuler la dernière saisie");
    Console.WriteLine("Tapez 'r' pour restaurer la dernière saisie");

    Console.WriteLine("--------------");
    Console.WriteLine(textEditor.Text);
    Console.WriteLine("--------------");

    var saisie = Console.ReadLine();

    switch(saisie)
    {
        case "u":
            careTaker.Undo();
            break;
        case "r":
            careTaker.Redo();
            break;
        default:
            textEditor.Text += $"{saisie}{Environment.NewLine}";
            careTaker.Backup();
        break;
    }
}

public class MyMemento(string text)
{
    public string Text { get; } = text;
}

public class TextEditor
{
    public string Text { get; set; }

    public MyMemento Save() => new(Text);

    public void Restore(MyMemento memento) => Text = memento.Text;
}

public class Caretaker(TextEditor textEditor)
{
    private List<MyMemento> _states = [];
    private int _index = -1;

    public void Backup()
    {
        _states.Add(textEditor.Save());
        _index++;
    }

    public void Undo()
    {
        if (_index <= 0)
            return;
        _index--;
        textEditor.Restore(_states[_index]);
    }

    public void Redo()
    {
        if (_index + 1 >= _states.Count)
            return;
        _index++;
        textEditor.Restore(_states[_index]);
    }
}