using Assignment3.Utility;
using Assignment3;
using System.Runtime.Serialization;

public static class SerializationHelper
{
	public static void SerializeUsers(SLL users, string fileName)
	{
		DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
		using (FileStream stream = File.Create(fileName))
		{
			List<User> userList = new List<User>();
			for (int i = 0; i < users.Count(); i++)
			{
				userList.Add(users.GetValue(i));
			}
			serializer.WriteObject(stream, userList);
		}
	}

	public static SLL DeserializeUsers(string fileName)
	{
		DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
		using (FileStream stream = File.OpenRead(fileName))
		{
			List<User> userList = (List<User>)serializer.ReadObject(stream);
			SLL users = new SLL();
			foreach (User user in userList)
			{
				users.AddLast(user);
			}
			return users;
		}
	}
}