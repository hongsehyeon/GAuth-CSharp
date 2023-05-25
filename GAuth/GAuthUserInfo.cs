using System.Collections.Generic;

namespace GAuth_CSharp
{
    public class GAuthUserInfo
    {
        public string Email { get; private set; }
        public string Name { get; private set; }
        public int Grade { get; private set; }
        public int ClassNum { get; private set; }
        public int Num { get; private set; }
        public string Gender { get; private set; }
        public string ProfileUrl { get; private set; }
        public string Role { get; private set; }

        public GAuthUserInfo(Dictionary<string, object> dic)
        {
            Email = (string)dic["email"];
            Name = (string)dic["name"];
            Grade = (int)(long)dic["grade"];
            ClassNum = (int)(long)dic["classNum"];
            Num = (int)(long)dic["num"];
            Gender = (string)dic["gender"];
            ProfileUrl = (string)dic["profileUrl"];
            Role = (string)dic["role"];
        }
    }
}