namespace Statharas.Tools;
public static class SingletonMaker
{
	static Dictionary<Type, object> dict = new();

	public static T Singleton<T>() where T : new()
	{

		dict.TryGetValue(typeof(T), out var value);
		if (value is not null) return (T)value;
		//if (dict.ContainsKey(typeof(T))) return (T)dict[typeof(T)];
		var z = new T();
		dict.Add(typeof(T), z);
		return z;
	}
}