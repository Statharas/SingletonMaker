namespace Statharas.Tools;
public class SingletonMaker
{
	Dictionary<Type, object> dict = new();

	public T Singleton<T>() where T : new()
	{

		dict.TryGetValue(typeof(T), out var value);
		if (value is not null) return (T)value;
		//if (dict.ContainsKey(typeof(T))) return (T)dict[typeof(T)];
		var z = new T();
		dict.Add(typeof(T), z);
		return z;
	}
}