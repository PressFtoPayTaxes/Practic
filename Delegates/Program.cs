using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DotNetXmlHttpRequest;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Reflection;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите идентификатор персонажа: ");
            int identifier = int.Parse(Console.ReadLine());
            string urlIdentifier = $"https://swapi.co/api/people/{identifier}/";

            bool needSwapi = false;

            string filePath = "characters.xml";

            Character character = new Character();

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                while (stream.Position != stream.Length)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Character));
                    character = serializer.Deserialize(stream) as Character;

                    if (character.Url == urlIdentifier)
                        break;
                }

                if (stream.Position == stream.Length && character.Url != urlIdentifier)
                {
                    needSwapi = true;
                    character = null;
                }
            }

            int currentPage = 1;
            if (needSwapi)
            {
                while (character == null)
                {
                    Character[] temporaryCharacters;

                    string jsonUrl = "https://swapi.co/api/people/?format=json&page=" + currentPage;

                    XMLHttpRequest request = new XMLHttpRequest();
                    try
                    {
                        request.Open(XMLHttpRequest.EnumMethod.Get, jsonUrl);
                        request.Send();
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine("Закончились страницы, или нет подключения к интернету");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                    using (StreamReader stream = new StreamReader(request.ResponseStream))
                    {
                        string jsonFile = stream.ReadToEnd();

                        var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd-MM-yyyy" };

                        var xmlNode = JsonConvert.DeserializeXmlNode(jsonFile, "results");

                        RootObject root = JsonConvert.DeserializeObject<RootObject>(jsonFile, dateTimeConverter);
                        temporaryCharacters = root.results;


                        foreach (var temporaryCharacter in temporaryCharacters)
                        {
                            if (temporaryCharacter.Url == urlIdentifier)
                            {
                                character = temporaryCharacter;
                                break;
                            }
                        }
                    }
                    currentPage++;
                }

                using (FileStream stream = new FileStream(filePath, FileMode.Append))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Character));
                    serializer.Serialize(stream, character);
                }
            }

            Type type = typeof(Character);

            foreach (var member in type.GetMembers())
            {
                if (member is PropertyInfo)
                {
                    var property = member as PropertyInfo;

                    Console.Write($"{property.Name}: ");

                    if (property.PropertyType == typeof(List<string>))
                    {
                        foreach (var item in property.GetValue(character) as List<string>)
                            Console.WriteLine($"{item}, ");
                        Console.Write("\b\b");
                    }
                    else
                        Console.WriteLine(property.GetValue(character));
                }
            }

            Console.ReadLine();
        }
    }
}
