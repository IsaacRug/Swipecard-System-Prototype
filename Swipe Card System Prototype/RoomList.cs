using System.Collections.Generic;

public class RoomList : IObservable<List<string>>
{
    private List<IObserver<List<string>>> observers = new List<IObserver<List<string>>>();
    private List<string> rooms = new List<string>();

    public void Attach(IObserver<List<string>> observer) => observers.Add(observer);
    public void Detach(IObserver<List<string>> observer) => observers.Remove(observer);
    public void NotifyObservers() => observers.ForEach(observer => observer.Update(rooms));

    public void SetState(List<string> newRooms)
    {
        rooms = newRooms;
        NotifyObservers();
    }
}