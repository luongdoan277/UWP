using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP40.Models
{
    public class Friend
    {
        public int FriendId { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
    }

    public class DataFriend
    {
        public static List<Friend> GetFriends()
        {
            var friend = new List<Friend>();

            friend.Add(new Friend { FriendId = 1, Age = 20, FullName = "Futurum", Avatar = "Assets/1.png" });
            friend.Add(new Friend { FriendId = 2, Age = 20, FullName = "Sequiter Que", Avatar = "Assets/2.png" });
            friend.Add(new Friend { FriendId = 3, Age = 20, FullName = "Tempor", Avatar = "Assets/3.png" });
            friend.Add(new Friend { FriendId = 4, Age = 20, FullName = "Ale", Avatar = "Assets/4.png" });
            friend.Add(new Friend { FriendId = 5, Age = 20, FullName = "Tom", Avatar = "Assets/5.png" });
            friend.Add(new Friend { FriendId = 7, Age = 20, FullName = "Tomy", Avatar = "Assets/6.png" });
            friend.Add(new Friend { FriendId = 8, Age = 20, FullName = "Thomson", Avatar = "Assets/7.png" });
            friend.Add(new Friend { FriendId = 9, Age = 20, FullName = "admin", Avatar = "Assets/8.png" });
            friend.Add(new Friend { FriendId = 10, Age = 20, FullName = "Alex", Avatar = "Assets/9.png" });
            friend.Add(new Friend { FriendId = 11, Age = 20, FullName = "John", Avatar = "Assets/10.png" });
            friend.Add(new Friend { FriendId = 12, Age = 20, FullName = "Tor", Avatar = "Assets/11.png" });
            friend.Add(new Friend { FriendId = 13, Age = 20, FullName = "Temp", Avatar = "Assets/12.png" });
            friend.Add(new Friend { FriendId = 14, Age = 20, FullName = "Temple", Avatar = "Assets/13.png" });
            return friend;
        }
    }
}
